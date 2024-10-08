﻿namespace WinFormsApp.Forms
{
    partial class FormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelUser = new Label();
            labelId = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelBirthday = new Label();
            labelJoiningDate = new Label();
            labelRecordsNumber = new Label();
            textBoxId = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxJoiningDate = new TextBox();
            textBoxRecordsNumber = new TextBox();
            textBoxLastName = new TextBox();
            buttonSave = new Button();
            buttonEdit = new Button();
            checkBoxIsRemoved = new CheckBox();
            labelIsRemoved = new Label();
            dateTimePickerBirthday = new DateTimePicker();
            SuspendLayout();
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelUser.Location = new Point(230, 25);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(71, 32);
            labelUser.TabIndex = 0;
            labelUser.Text = "USER";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(165, 121);
            labelId.Name = "labelId";
            labelId.Size = new Size(25, 20);
            labelId.TabIndex = 1;
            labelId.Text = "Id:";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(107, 164);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(83, 20);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(108, 207);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(82, 20);
            labelLastName.TabIndex = 3;
            labelLastName.Text = "Last Name:";
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(123, 252);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(67, 20);
            labelBirthday.TabIndex = 4;
            labelBirthday.Text = "Birthday:";
            // 
            // labelJoiningDate
            // 
            labelJoiningDate.AutoSize = true;
            labelJoiningDate.Location = new Point(93, 293);
            labelJoiningDate.Name = "labelJoiningDate";
            labelJoiningDate.Size = new Size(95, 20);
            labelJoiningDate.TabIndex = 5;
            labelJoiningDate.Text = "Joining Date:";
            // 
            // labelRecordsNumber
            // 
            labelRecordsNumber.AutoSize = true;
            labelRecordsNumber.Location = new Point(125, 336);
            labelRecordsNumber.Name = "labelRecordsNumber";
            labelRecordsNumber.Size = new Size(65, 20);
            labelRecordsNumber.TabIndex = 7;
            labelRecordsNumber.Text = "Records:";
            // 
            // textBoxId
            // 
            textBoxId.BackColor = SystemColors.Window;
            textBoxId.Location = new Point(199, 118);
            textBoxId.Margin = new Padding(6, 8, 6, 8);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(87, 27);
            textBoxId.TabIndex = 11;
            textBoxId.Tag = "DisableFields";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(199, 161);
            textBoxFirstName.Margin = new Padding(6, 8, 6, 8);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(175, 27);
            textBoxFirstName.TabIndex = 12;
            textBoxFirstName.Tag = "EditFields";
            // 
            // textBoxJoiningDate
            // 
            textBoxJoiningDate.BackColor = SystemColors.Window;
            textBoxJoiningDate.Location = new Point(201, 290);
            textBoxJoiningDate.Margin = new Padding(6, 8, 6, 8);
            textBoxJoiningDate.Name = "textBoxJoiningDate";
            textBoxJoiningDate.ReadOnly = true;
            textBoxJoiningDate.Size = new Size(175, 27);
            textBoxJoiningDate.TabIndex = 13;
            textBoxJoiningDate.Tag = "DisableFields";
            // 
            // textBoxRecordsNumber
            // 
            textBoxRecordsNumber.BackColor = SystemColors.Window;
            textBoxRecordsNumber.Location = new Point(199, 333);
            textBoxRecordsNumber.Margin = new Padding(6, 8, 6, 8);
            textBoxRecordsNumber.Name = "textBoxRecordsNumber";
            textBoxRecordsNumber.ReadOnly = true;
            textBoxRecordsNumber.Size = new Size(87, 27);
            textBoxRecordsNumber.TabIndex = 15;
            textBoxRecordsNumber.Tag = "DisableFields";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(199, 204);
            textBoxLastName.Margin = new Padding(6, 8, 6, 8);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(175, 27);
            textBoxLastName.TabIndex = 17;
            textBoxLastName.Tag = "EditFields";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(341, 457);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(131, 29);
            buttonSave.TabIndex = 19;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(341, 457);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(131, 29);
            buttonEdit.TabIndex = 18;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // checkBoxIsRemoved
            // 
            checkBoxIsRemoved.AutoSize = true;
            checkBoxIsRemoved.Location = new Point(147, 464);
            checkBoxIsRemoved.Name = "checkBoxIsRemoved";
            checkBoxIsRemoved.Size = new Size(18, 17);
            checkBoxIsRemoved.TabIndex = 21;
            checkBoxIsRemoved.Tag = "EditFields";
            checkBoxIsRemoved.UseVisualStyleBackColor = true;
            // 
            // labelIsRemoved
            // 
            labelIsRemoved.AutoSize = true;
            labelIsRemoved.Location = new Point(64, 462);
            labelIsRemoved.Name = "labelIsRemoved";
            labelIsRemoved.Size = new Size(75, 20);
            labelIsRemoved.TabIndex = 20;
            labelIsRemoved.Text = "Removed:";
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(199, 247);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(177, 27);
            dateTimePickerBirthday.TabIndex = 22;
            dateTimePickerBirthday.Tag = "EditFields";
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 524);
            Controls.Add(dateTimePickerBirthday);
            Controls.Add(checkBoxIsRemoved);
            Controls.Add(labelIsRemoved);
            Controls.Add(buttonSave);
            Controls.Add(buttonEdit);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxRecordsNumber);
            Controls.Add(textBoxJoiningDate);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxId);
            Controls.Add(labelRecordsNumber);
            Controls.Add(labelJoiningDate);
            Controls.Add(labelBirthday);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelId);
            Controls.Add(labelUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUser";
            Text = "User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUser;
        private Label labelId;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelBirthday;
        private Label labelJoiningDate;
        private Label labelRecordsNumber;
        private TextBox textBoxId;
        private TextBox textBoxFirstName;
        private TextBox textBoxJoiningDate;
        private TextBox textBoxRecordsNumber;        
        private TextBox textBoxLastName;
        private Button buttonSave;
        private Button buttonEdit;
        private CheckBox checkBoxIsRemoved;
        private Label labelIsRemoved;
        private DateTimePicker dateTimePickerBirthday;
    }
}