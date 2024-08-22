using Logic.Data;
using Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Forms
{
    public partial class FormUser : Form
    {
        public User CurrentUser { get; set; }
        public FormUser()
        {
            InitializeComponent();
        }

        public FormUser(User user)
        {
            CurrentUser = user;
            InitializeComponent();
            DisableEdit();
            PopulateForm();
        }

        private void PopulateForm()
        {
            textBoxId.Text = CurrentUser.Id.ToString();
            textBoxFirstName.Text = CurrentUser.FirstName;
            textBoxLastName.Text = CurrentUser.LastName;
            dateTimePickerBirthday.Value = CurrentUser.Birthday.ToDateTime(new TimeOnly());
            textBoxJoiningDate.Text = CurrentUser.JoiningDate.ToString("dd/MM/yy HH:mm");
            textBoxRecordsNumber.Text = CurrentUser.Records.Count.ToString();
            checkBoxIsRemoved.Checked = CurrentUser.IsRemoved;            
        }

        private void EnableEdit()
        {
            textBoxFirstName.ReadOnly = false;
            textBoxLastName.ReadOnly = false;
            dateTimePickerBirthday.Enabled = true;          
            checkBoxIsRemoved.Enabled = true;
            buttonEdit.Visible = false;
            buttonSave.Visible = true;
            foreach (Control c in this.Controls)
            {
                if (c.Tag == "DisableFields")
                    c.Enabled = false;
            }
        }

        private void DisableEdit()
        {
            textBoxFirstName.ReadOnly = true;
            textBoxLastName.ReadOnly = true;
            dateTimePickerBirthday.Enabled = false;        
            checkBoxIsRemoved.Enabled = false;
            buttonEdit.Visible = true;
            buttonSave.Visible = false;
            foreach (Control c in this.Controls)
            {
                if (c.Tag == "DisableFields")
                    c.Enabled = true;
                else if (c.Tag == "EditFields")
                    c.BackColor = Color.White;
            }
        }

        public User GetData()
        {
            User user = new User();
            user.FirstName = textBoxFirstName.Text.Trim();
            user.LastName = textBoxLastName.Text.Trim();
            user.Birthday = DateOnly.FromDateTime(dateTimePickerBirthday.Value);
            user.JoiningDate = DateTime.Now;
            user.IsRemoved = checkBoxIsRemoved.Checked;
            return user;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!Validation(out string message))
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CurrentUser == null)
            {
                using (LibraryContext context = new LibraryContext())
                {
                    CurrentUser = GetData();
                    context.Users.Add(CurrentUser);
                    context.SaveChanges();
                }
            }
            else
            {
                using (LibraryContext context = new LibraryContext())
                {
                    UpdateUser(CurrentUser, GetData());
                    context.Update(CurrentUser);
                    context.SaveChanges();
                }
            }

            DisableEdit();
        }
        
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EnableEdit();
        }

        public void UpdateUser(User target, User source)
        {
            target.FirstName = source.FirstName;
            target.LastName = source.LastName;
            target.Birthday = source.Birthday;
            target.IsRemoved = source.IsRemoved;
        }

        private bool Validation(out string message)
        {
            bool yearValid = Int16.TryParse(textBoxJoiningDate.Text.Trim(), out Int16 year);
            if (textBoxFirstName.Text.Trim() == "")
            {
                message = "Please, enter the first name of the user.";
                return false;
            }
            else if (textBoxLastName.Text.Trim() == "")
            {
                message = "Please, enter the last name of the user.";
                return false;
            }
            else if (dateTimePickerBirthday.Value == null)
            {
                message = "Please, enter the birthday of the user.";
                return false;
            }

            message = "Validation is successfull.";
            return true;
        }
    }
}
