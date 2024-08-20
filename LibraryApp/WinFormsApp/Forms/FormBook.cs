using Logic.Data;
using Logic.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp.Forms
{
    public partial class FormBook : Form
    {
        public Book CurrentBook { get; set; }
        public FormBook()
        {
            InitializeComponent();
            SetComboBoxGenre();
        }
        public FormBook(Book book)
        {
            CurrentBook = book;
            InitializeComponent();
            DisableEdit();
            PopulateForm();
        }

        private void SetComboBoxGenre()
        {
            List<Genre> genres = new List<Genre>();
            using (LibraryContext context = new LibraryContext())
            {
                genres = context.Genres.ToList();
            }
            comboBoxGenre.DataSource = genres;
            comboBoxGenre.DisplayMember = "Name";
            comboBoxGenre.ValueMember = "Id";
        }

        private void PopulateForm()
        {
            textBoxId.Text = CurrentBook.Id.ToString();
            textBoxName.Text = CurrentBook.Name;
            textBoxAuthor.Text = CurrentBook.Author;
            textBoxPublisher.Text = CurrentBook.Publisher;
            richTextBoxDescription.Text = CurrentBook.Description;
            textBoxYear.Text = CurrentBook.Year.ToString();
            checkBoxIsRemoved.Checked = CurrentBook.IsRemoved;
            checkBoxIsAvailable.Checked = CurrentBook.Records.Count != 0 &&
                CurrentBook.Records.FirstOrDefault().IsTaken ? false : true;      
            SetComboBoxGenre();            
        }
        private void EnableEdit()
        {
            textBoxName.ReadOnly = false;
            textBoxAuthor.ReadOnly = false;
            textBoxPublisher.ReadOnly = false;
            textBoxYear.ReadOnly = false;
            richTextBoxDescription.ReadOnly = false;
            comboBoxGenre.Enabled = true;
            checkBoxIsRemoved.Enabled = true;
            buttonEdit.Visible = false;
            buttonSave.Visible = true;
            foreach (Control c in this.Controls)
            {
                if (c.Tag == "FieldsToEdit")
                    c.BackColor = Color.LightYellow;
            }

        }
        private void DisableEdit()
        {
            textBoxName.ReadOnly = true;
            textBoxAuthor.ReadOnly = true;
            textBoxPublisher.ReadOnly = true;
            textBoxYear.ReadOnly = true;
            richTextBoxDescription.ReadOnly = true;
            comboBoxGenre.Enabled = false;
            checkBoxIsRemoved.Enabled = false;
            buttonEdit.Visible = true;
            buttonSave.Visible = false;
            foreach (Control c in this.Controls)
            {
                if (c.Tag == "FieldsToEdit")
                {
                    c.BackColor = Color.White;
                    c.ForeColor = Color.Black;
                }
            }
        }

        public Book GetData()
        {
            Book book = new Book();
            book.Name = textBoxName.Text.Trim();
            book.Author = textBoxAuthor.Text.Trim();
            book.Description = richTextBoxDescription.Text.Trim();
            book.GenreId = (int)comboBoxGenre.SelectedValue;
            book.Year = Int16.Parse(textBoxYear.Text.Trim());
            book.Publisher = textBoxPublisher.Text.Trim();
            book.IsRemoved = checkBoxIsRemoved.Checked;
            return book;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EnableEdit();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!Validation(out string message))
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CurrentBook == null)
            {
                using (LibraryContext context = new LibraryContext())
                {
                    CurrentBook = GetData();
                    context.Books.Add(CurrentBook);
                    context.SaveChanges();
                }
            }
            else
            {
                using (LibraryContext context = new LibraryContext())
                {
                    UpdateBook(CurrentBook, GetData());
                    context.Update(CurrentBook);
                    context.SaveChanges();
                }
            }
            
            DisableEdit();
        }

        public void UpdateBook(Book target, Book source)
        {
            target.Name = source.Name;
            target.Author = source.Author;
            target.GenreId = source.GenreId; 
            if (!string.IsNullOrEmpty(source.Description)) 
                target.Description = source.Description;
            target.Publisher = source.Publisher;
            target.Year = source.Year;
            target.IsRemoved = source.IsRemoved;
        }

        private bool Validation(out string message)
        {
            bool yearValid = Int16.TryParse(textBoxYear.Text.Trim(), out Int16 year);
            if (textBoxName.Text.Trim() == "")
            {
                message = "Please, enter the name of the book.";
                return false;
            }
            else if (textBoxAuthor.Text.Trim() == "")
            {
                message = "Please, enter the author of the book.";
                return false;
            }
            else if (textBoxPublisher.Text.Trim() == "")
            {
                message = "Please, enter the publisher of the book.";
                return false;
            }
            else if (!yearValid)
            {
                message = "Please, enter the year of the book.";
                return false;
            }            
                
            message = "Validation is successfull.";
            return true;
        }
    }
}
