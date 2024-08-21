using Logic.Data;
using Logic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsApp.Forms
{
    public partial class FormRecords : Form
    {
        private List<Record> RecordsOfTaken;
        public FormRecords()
        {
            InitializeComponent();
        }
        private void FormRecords_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            RefreshDataGridView();
        }
        private List<Record> GetRecordsOfTaken()
        {
            List<Record> records;
            using (var context = new LibraryContext())
            {
                var maxDateByBookId = context.Records
                    .GroupBy(r => r.BookId)
                    .Select(g => new
                    {
                        BookId = g.Key,
                        MaxDate = g.Max(r => r.Date)
                    });

                records = context.Records
                    .Join(maxDateByBookId,
                        r => new { r.BookId, r.Date },
                        m => new { m.BookId, Date = m.MaxDate },
                        (r, m) => r)
                    .Where(r => r.IsTaken).ToList();
            }
            return records;
        }

        private List<Record> GetAllRecords()
        {
            List<Record> records = new List<Record>();
            using (var context = new LibraryContext())
            {
                records = context.Records
                    .Include(r => r.Book)
                    .Include(r => r.User)
                    .ToList();
            }
            return records;
        }
        private void DeleteRecord(int id)
        {
            using (var context = new LibraryContext())
            {
                Record record = context.Records
                    .Where(r => r.Id == id)
                    .First();
                context.Records.Remove(record);
                context.SaveChanges();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormRecord form = new FormRecord();
            form.ShowDialog();
            RefreshDataGridView();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenSelectedRecord();
        }

        private void OpenSelectedRecord(bool makeReturn = false)
        {
            Record record;
            using (var context = new LibraryContext())
            {
                record = context.Records
                    .Where(r => r.Id == (int)dataGridView.SelectedRows[0].Cells[0].Value)
                    .Include(r => r.Book)
                    .Include(r => r.User)
                    .FirstOrDefault() ?? new Record();
            }
            FormRecord form = new FormRecord(record, makeReturn);
            form.ShowDialog();
            RefreshDataGridView();
        }


        private void SetupDataGridView()
        {
            dataGridView.ColumnCount = 6;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[1].Name = "Book";
            dataGridView.Columns[2].Name = "User";
            dataGridView.Columns[3].Name = "Date";
            dataGridView.Columns[4].Name = "Status";

            dataGridView.Columns[5].Name = "Last Taken";
            dataGridView.Columns[5].Visible = false;

            dataGridView.Columns[0].FillWeight = 50;
            dataGridView.Columns[1].FillWeight = 420;
            dataGridView.Columns[2].FillWeight = 200;
            dataGridView.Columns[3].FillWeight = 140;
            dataGridView.Columns[4].FillWeight = 130;


            dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn c in dataGridView.Columns)
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.RowHeadersVisible = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;            
        }

        private void PopulateDataGridView(List<Record> records)
        {
            dataGridView.Rows.Clear();
            foreach (var r in records)
            {
                bool lastTaken = false;
                foreach (var rot in RecordsOfTaken)
                {
                    if (rot.Id == r.Id)
                        lastTaken = true;
                }
                var status = r.IsTaken ? "Taken" : "Returned";
                dataGridView.Rows.Add(r.Id, r.Book.NameForRecord, r.User.NameForRecord,
                    r.Date.ToString("dd/MM/yy HH:mm"), status, lastTaken);
            }
            if (dataGridView.Rows.Count > 0)
            {
                buttonDelete.Enabled = true;
                buttonOpen.Enabled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView.SelectedRows)
            {
                var str = $"Are you sure you want to delete record: \n" +
                    $" {item.Cells[0].Value} - {item.Cells[1].Value}, {item.Cells[2].Value}";
                DialogResult dr = MessageBox.Show(str, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    DeleteRecord((int)item.Cells[0].Value);
                }
            }
            RefreshDataGridView();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim();
            List<Record> records = new List<Record>();
            using (var context = new LibraryContext())
            {
                records = context.Records
                    .Where(r => r.Id.ToString().Contains(search) ||
                    r.Book.Id.ToString().Contains(search) ||
                    r.Book.Name.Contains(search) ||
                    r.Book.Author.Contains(search) ||
                    r.Book.Year.ToString().Contains(search) ||
                    r.User.Id.ToString().Contains(search) ||
                    r.User.FirstName.Contains(search) ||
                    r.User.LastName.Contains(search))
                    .Include(r => r.Book)
                    .Include(r => r.User)
                    .ToList();
            }
            PopulateDataGridView(records);
        }

        private void RefreshDataGridView()
        {
            RecordsOfTaken = GetRecordsOfTaken();
            PopulateDataGridView(GetAllRecords());
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenSelectedRecord();
        }

        private void buttonMakeReturn_Click(object sender, EventArgs e)
        {
            OpenSelectedRecord(true);
        }

        private void dataGridView_CurrentCellChanged(object sender, EventArgs e)
        {            
            if (dataGridView.SelectedRows.Count > 0 &&
                (bool)dataGridView.SelectedRows[0].Cells[5].Value == true)
                buttonMakeReturn.Enabled = true;
            else 
                buttonMakeReturn.Enabled = false;            
        }
    }
}
