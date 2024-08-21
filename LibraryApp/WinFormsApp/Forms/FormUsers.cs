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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }
        private void FormUsers_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            RefreshDataGridView();
        }
        private List<User> GetAllUsers()
        {
            List<User> books = new List<User>();
            using (var context = new LibraryContext())
            {
                books = context.Users
                    .Where(u => (!u.IsRemoved))
                    .Include(u => u.Records.OrderByDescending(r => r.Date))
                    .ToList();
            }
            return books;
        }
        private void RemoveUser(int id)
        {
            using (var context = new LibraryContext())
            {
                User user = context.Users
                    .Where(u => u.Id == id)
                    .FirstOrDefault() ?? new User();
                user.IsRemoved = true;
                context.Users.Update(user);
                context.SaveChanges();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormUser form = new FormUser();
            form.ShowDialog();
            RefreshDataGridView();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenSelectedUser();
        }

        private void OpenSelectedUser()
        {
            User user;
            using (var context = new LibraryContext())
            {
                user = context.Users
                    .Where(u => u.Id == (int)dataGridView.SelectedRows[0].Cells[0].Value)
                    .Include(u => u.Records)
                    .FirstOrDefault() ?? new User();
            }
            FormUser form = new FormUser(user);
            form.ShowDialog();
            RefreshDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridView.ColumnCount = 6;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[1].Name = "First Name";
            dataGridView.Columns[2].Name = "Last Name";
            dataGridView.Columns[3].Name = "Birthday";
            dataGridView.Columns[4].Name = "Joining Date";
            dataGridView.Columns[5].Name = "Records";

            dataGridView.Columns[0].FillWeight = 70;
            dataGridView.Columns[1].FillWeight = 300;
            dataGridView.Columns[2].FillWeight = 300;
            dataGridView.Columns[3].FillWeight = 300;
            dataGridView.Columns[4].FillWeight = 300;
            dataGridView.Columns[5].FillWeight = 200;

            dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn c in dataGridView.Columns)
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.RowHeadersVisible = false;
            dataGridView.AllowUserToAddRows = false;                   
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PopulateDataGridView(List<User> users)
        {
            dataGridView.Rows.Clear();
            foreach (var u in users)
            {
                dataGridView.Rows.Add(u.Id, u.FirstName, u.LastName, u.Birthday,
                    u.JoiningDate.ToString("dd/MM/yy HH:mm"), u.Records.Count());
            }
            if (dataGridView.Rows.Count > 0)
            {
                buttonRemove.Enabled = true;
                buttonOpen.Enabled = true;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView.SelectedRows)
            {
                var str = $"Are you sure you want to remove user: \n" +
                    $" {item.Cells[0].Value} - {item.Cells[1].Value} {item.Cells[2].Value}";
                DialogResult dr = MessageBox.Show(str, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    RemoveUser((int)item.Cells[0].Value);
                }
            }
            RefreshDataGridView();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim();
            List<User> users = new List<User>();
            using (var context = new LibraryContext())
            {
                users = context.Users
                    .Where(u => !u.IsRemoved &&
                   (u.Id.ToString().Contains(search) ||
                    u.FirstName.Contains(search) ||
                    u.LastName.Contains(search) ||
                    u.Birthday.ToString().Contains(search)))
                    .Include(book => book.Records.OrderByDescending(r => r.Date))
                    .ToList();
            }
            PopulateDataGridView(users);
        }

        private void RefreshDataGridView()
        {
            PopulateDataGridView(GetAllUsers());
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenSelectedUser();
        }
    }
}
