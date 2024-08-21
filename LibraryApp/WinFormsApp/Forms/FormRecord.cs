using Logic.Data;
using Logic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using static System.Reflection.Metadata.BlobBuilder;


namespace WinFormsApp.Forms
{
    public partial class FormRecord : Form
    {
        public Record? CurrentRecord { get; set; }
        public Book? SelectedBook { get; set; }
        public User? SelectedUser { get; set; }
        public List<Book>? AvailableBooks { get; set; }
        public List<User>? Users { get; set; }

        private readonly bool _makeReturn;
        public FormRecord()
        {
            InitializeComponent();
            EnableEdit();
        }

        public FormRecord(Record record, bool makeReturn = false)
        {
            CurrentRecord = record;
            SelectedBook = record.Book;
            SelectedUser = record.User;
            _makeReturn = makeReturn;
            InitializeComponent();
            DisableEdit();
        }

        public FormRecord(Book book)
        {
            SelectedBook = book;
            InitializeComponent();
            EnableEdit();            
        }

        private void FormRecord_Load(object sender, EventArgs e)
        {
            Users = GetUsers();
            AvailableBooks = GetAvailableBooks();
            PopulateForm();
        }

        private void SetListBoxes()
        {
            if (_makeReturn)
                AvailableBooks.Add(SelectedBook);
            listBoxBooks.Items.Clear();
            listBoxUsers.Items.Clear();
            foreach (var b in AvailableBooks)
                listBoxBooks.Items.Add(b);
            foreach (var u in Users)
                listBoxUsers.Items.Add(u);
            listBoxBooks.ValueMember = "Id";
            listBoxUsers.ValueMember = "Id";
            listBoxBooks.DisplayMember = "NameForRecord";
            listBoxUsers.DisplayMember = "NameForRecord";
            listBoxBooks.SelectionMode = SelectionMode.One;
            listBoxUsers.SelectionMode = SelectionMode.One;

            if (SelectedBook != null)
                listBoxBooks.SelectedItem = SelectedBook;
            if (SelectedUser != null)
                listBoxUsers.SelectedItem = SelectedUser;
        }

        private List<User> GetUsers()
        {
            List<User> users;
            using (LibraryContext context = new LibraryContext())
            {
                users = context.Users
                    .Where(u => !u.IsRemoved)
                    .ToList();
            }
            return users;
        }

        private List<Book> GetAvailableBooks()
        {
            List<Book> books;
            using (LibraryContext context = new LibraryContext())
            {
                books = context.Books
                    .Where(b => !b.IsRemoved && (b.Records.Count() == 0 ||
                    !b.Records.OrderByDescending(r => r.Date).First().IsTaken))
                    .Include(b => b.Records.OrderByDescending(r => r.Date).Take(1))
                    .ToList();
            }
            return books;
        }

        private void PopulateForm()
        {
            SetListBoxes();
            if (CurrentRecord != null)
            {
                textBoxId.Text = _makeReturn ? "" : CurrentRecord.Id.ToString();
                textBoxBook.Text = CurrentRecord.Book.NameForRecord;
                textBoxUser.Text = CurrentRecord.User.NameForRecord;
                if (!_makeReturn)
                    textBoxDate.Text = CurrentRecord.Date.ToString("dd/MM/yy HH:mm");
            }
            textBoxStatus.Text = _makeReturn ? "Returned" : "Taken";
            
        }
        private void EnableEdit()
        {
            textBoxBook.ReadOnly = false;
            textBoxUser.ReadOnly = false;
            listBoxBooks.Enabled = true;
            listBoxUsers.Enabled = true;
            buttonSave.Visible = true;
        }
        private void DisableEdit()
        {
            textBoxBook.ReadOnly = true;
            textBoxUser.ReadOnly = true;
            listBoxBooks.Enabled = false;
            listBoxUsers.Enabled = false;
            buttonSave.Visible = false;
            if (_makeReturn)
            {
                buttonSave.Visible = true;
            }
        }

        public Record GetData()
        {
            Record record = new Record();
            if (_makeReturn)
            {
                record.BookId = CurrentRecord.BookId;
                record.UserId = CurrentRecord.UserId;
                record.Date = DateTime.Now;
            }
            else
            {
                record.BookId = ((Book)listBoxBooks.SelectedItem).Id;
                record.UserId = ((User)listBoxUsers.SelectedItem).Id;
                record.Date = DateTime.Now;
            }
            record.IsTaken = textBoxStatus.Text.Trim().ToLower() == "returned" ? false : true;
            return record;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!Validation(out string message))
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (LibraryContext context = new LibraryContext())
            {
                CurrentRecord = GetData();
                context.Records.Add(CurrentRecord);
                context.SaveChanges();
            }
            this.Close();
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItems.Count > 0)
            {
                textBoxBook.Text = ((Book)listBoxBooks.SelectedItem).NameForRecord;
            }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItems.Count > 0)
            {
                textBoxUser.Text = ((User)listBoxUsers.SelectedItem).NameForRecord;
            }
        }

        private void textBoxBook_TextChanged(object sender, EventArgs e)
        {
            if (AvailableBooks == null)
                return;
            listBoxBooks.Items.Clear();
            foreach (var b in AvailableBooks)
            {
                if (b.NameForRecord.Contains(textBoxBook.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    listBoxBooks.Items.Add(b);
                }
            }
            if (listBoxBooks.Items.Count == 1)
                listBoxBooks.SelectedIndex = 0;
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            if (Users == null)
                return;
            listBoxUsers.Items.Clear();
            foreach (var u in Users)
            {
                if (u.NameForRecord.Contains(textBoxUser.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    listBoxUsers.Items.Add(u);
                }                
            }
            if (listBoxUsers.Items.Count == 1)
                listBoxUsers.SelectedIndex = 0;
        }

        private bool Validation(out string message)
        {            
            if (listBoxBooks.SelectedItems.Count == 0)
            {
                message = "Please, select the book.";
                return false;
            }
            else if (listBoxUsers.SelectedItems.Count == 0)
            {
                message = "Please, select the user.";
                return false;
            }

            message = "Validation is successfull.";
            return true;
        }


    }
}
