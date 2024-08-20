namespace WinFormsApp.Forms
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
            labelUser.Location = new Point(281, 36);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(44, 20);
            labelUser.TabIndex = 0;
            labelUser.Text = "USER";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(130, 110);
            labelId.Name = "labelId";
            labelId.Size = new Size(25, 20);
            labelId.TabIndex = 1;
            labelId.Text = "Id:";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(121, 162);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(83, 20);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(130, 206);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(82, 20);
            labelLastName.TabIndex = 3;
            labelLastName.Text = "Last Name:";
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(130, 248);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(67, 20);
            labelBirthday.TabIndex = 4;
            labelBirthday.Text = "Birthday:";
            // 
            // labelJoiningDate
            // 
            labelJoiningDate.AutoSize = true;
            labelJoiningDate.Location = new Point(130, 285);
            labelJoiningDate.Name = "labelJoiningDate";
            labelJoiningDate.Size = new Size(99, 20);
            labelJoiningDate.TabIndex = 5;
            labelJoiningDate.Text = "Joining Date: ";
            // 
            // labelRecordsNumber
            // 
            labelRecordsNumber.AutoSize = true;
            labelRecordsNumber.Location = new Point(130, 325);
            labelRecordsNumber.Name = "labelRecordsNumber";
            labelRecordsNumber.Size = new Size(65, 20);
            labelRecordsNumber.TabIndex = 7;
            labelRecordsNumber.Text = "Records:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(161, 107);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(125, 27);
            textBoxId.TabIndex = 11;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(215, 161);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(125, 27);
            textBoxFirstName.TabIndex = 12;
            // 
            // textBoxJoiningDate
            // 
            textBoxJoiningDate.Location = new Point(235, 278);
            textBoxJoiningDate.Name = "textBoxJoiningDate";
            textBoxJoiningDate.ReadOnly = true;
            textBoxJoiningDate.Size = new Size(125, 27);
            textBoxJoiningDate.TabIndex = 13;
            // 
            // textBoxRecordsNumber
            // 
            textBoxRecordsNumber.Location = new Point(201, 318);
            textBoxRecordsNumber.Name = "textBoxRecordsNumber";
            textBoxRecordsNumber.ReadOnly = true;
            textBoxRecordsNumber.Size = new Size(125, 27);
            textBoxRecordsNumber.TabIndex = 15;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(227, 203);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(125, 27);
            textBoxLastName.TabIndex = 17;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(515, 527);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 19;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(515, 527);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 18;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // checkBoxIsRemoved
            // 
            checkBoxIsRemoved.AutoSize = true;
            checkBoxIsRemoved.Location = new Point(235, 511);
            checkBoxIsRemoved.Name = "checkBoxIsRemoved";
            checkBoxIsRemoved.Size = new Size(18, 17);
            checkBoxIsRemoved.TabIndex = 21;
            checkBoxIsRemoved.UseVisualStyleBackColor = true;
            // 
            // labelIsRemoved
            // 
            labelIsRemoved.AutoSize = true;
            labelIsRemoved.Location = new Point(152, 509);
            labelIsRemoved.Name = "labelIsRemoved";
            labelIsRemoved.Size = new Size(75, 20);
            labelIsRemoved.TabIndex = 20;
            labelIsRemoved.Text = "Removed:";
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Checked = false;
            dateTimePickerBirthday.CustomFormat = "dd/MM/yyyy";
            dateTimePickerBirthday.Location = new Point(215, 243);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(185, 27);
            dateTimePickerBirthday.TabIndex = 22;
            dateTimePickerBirthday.Value = new DateTime(2024, 8, 20, 20, 52, 43, 0);
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 622);
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
            Name = "FormUser";
            Text = "FormUser";
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