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
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }
        private void FormBooks_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            RefreshDataGridView();
        }
        private List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            using (var context = new LibraryContext())
            {
                books = context.Books
                    .Where(book => (!book.IsRemoved))
                    .Include(book => book.Genre)
                    .Include(book => book.Records.OrderByDescending(r => r.Date).Take(1))
                    .ToList();
            }
            return books;
        }
        private void RemoveBook(int id)
        {
            using (var context = new LibraryContext())
            {
                Book book = (Book)context.Books
                    .Where(b => b.Id == id)
                    .First();
                book.IsRemoved = true;
                context.Books.Update(book);
                context.SaveChanges();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormBook form = new FormBook();
            form.ShowDialog();
            RefreshDataGridView();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenSelectedBook();
        }

        private void OpenSelectedBook()
        {
            Book book;
            using (var context = new LibraryContext())
            {
                book = context.Books
                    .Where(b => b.Id == (int)dataGridView.SelectedRows[0].Cells[0].Value)
                    .Include(b => b.Records.OrderByDescending(r => r.Date).Take(1))
                    .FirstOrDefault() ?? new Book();
            }
            FormBook form = new FormBook(book);
            form.ShowDialog();
            RefreshDataGridView();
        }


        private void SetupDataGridView()
        {
            dataGridView.ColumnCount = 7;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[1].Name = "Name";
            dataGridView.Columns[2].Name = "Author";
            dataGridView.Columns[3].Name = "Genre";
            dataGridView.Columns[4].Name = "Year";
            dataGridView.Columns[5].Name = "Publisher";
            dataGridView.Columns[6].Name = "Available";

            dataGridView.Columns[0].FillWeight = 70;
            dataGridView.Columns[1].FillWeight = 370;
            dataGridView.Columns[2].FillWeight = 300;
            dataGridView.Columns[3].FillWeight = 200;
            dataGridView.Columns[4].FillWeight = 120;
            dataGridView.Columns[5].FillWeight = 300;
            dataGridView.Columns[6].FillWeight = 110;

            dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn c in dataGridView.Columns)
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.RowHeadersVisible = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void PopulateDataGridView(List<Book> books)
        {
            dataGridView.Rows.Clear();
            foreach (var b in books)
            {
                var available = b.IsAvailable ? "Yes" : "No";
                dataGridView.Rows.Add(b.Id, b.Name, b.Author, b.Genre.Name, b.Year, b.Publisher, available);
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
                var str = $"Are you sure you want to remove book: \n" +
                    $" {item.Cells[0].Value} - «{item.Cells[1].Value}» {item.Cells[2].Value}";
                DialogResult dr = MessageBox.Show(str, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    RemoveBook((int)item.Cells[0].Value);
                }
            }
            RefreshDataGridView();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim();
            List<Book> books = new List<Book>();
            using (var context = new LibraryContext())
            {
                books = context.Books
                    .Where(book => !book.IsRemoved &&
                   (book.Id.ToString().Contains(search) ||
                    book.Name.Contains(search) ||
                    book.Author.Contains(search) ||
                    book.Year.ToString().Contains(search) ||
                    book.Publisher.Contains(search) ||
                    book.Genre.Name.Contains(search)))
                    .Include(book => book.Genre)
                    .Include(book => book.Records.OrderByDescending(r => r.Date).Take(1))
                    .ToList();
            }
            PopulateDataGridView(books);
        }

        private void RefreshDataGridView()
        {
            PopulateDataGridView(GetAllBooks());
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenSelectedBook();
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            FormRecord form = new FormRecord();
        }
    }
}
