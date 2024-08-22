namespace WinFormsApp.Forms
{
    partial class FormRecord
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
            labelRecord = new Label();
            textBoxId = new TextBox();
            labelId = new Label();
            labelUser = new Label();
            textBoxUser = new TextBox();
            textBoxBook = new TextBox();
            labelBook = new Label();
            buttonSave = new Button();
            labelDate = new Label();
            textBoxDate = new TextBox();
            listBoxBooks = new ListBox();
            listBoxUsers = new ListBox();
            labelStatus = new Label();
            textBoxStatus = new TextBox();
            SuspendLayout();
            // 
            // labelRecord
            // 
            labelRecord.AutoSize = true;
            labelRecord.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRecord.Location = new Point(243, 18);
            labelRecord.Name = "labelRecord";
            labelRecord.Size = new Size(106, 32);
            labelRecord.TabIndex = 9;
            labelRecord.Text = "RECORD";
            // 
            // textBoxId
            // 
            textBoxId.BackColor = SystemColors.Window;
            textBoxId.Location = new Point(126, 91);
            textBoxId.Margin = new Padding(6);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(87, 27);
            textBoxId.TabIndex = 12;
            textBoxId.Tag = "DisableFields";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(91, 94);
            labelId.Margin = new Padding(10);
            labelId.Name = "labelId";
            labelId.Size = new Size(25, 20);
            labelId.TabIndex = 11;
            labelId.Text = "Id:";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(75, 326);
            labelUser.Margin = new Padding(3);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(41, 20);
            labelUser.TabIndex = 16;
            labelUser.Text = "User:";
            // 
            // textBoxUser
            // 
            textBoxUser.BackColor = SystemColors.Window;
            textBoxUser.Location = new Point(125, 323);
            textBoxUser.Margin = new Padding(6);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.ReadOnly = true;
            textBoxUser.Size = new Size(344, 27);
            textBoxUser.TabIndex = 17;
            textBoxUser.Tag = "EditFields";
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            // 
            // textBoxBook
            // 
            textBoxBook.BackColor = SystemColors.Window;
            textBoxBook.Location = new Point(126, 171);
            textBoxBook.Margin = new Padding(6);
            textBoxBook.Name = "textBoxBook";
            textBoxBook.ReadOnly = true;
            textBoxBook.Size = new Size(344, 27);
            textBoxBook.TabIndex = 19;
            textBoxBook.Tag = "EditFields";
            textBoxBook.TextChanged += textBoxBook_TextChanged;
            // 
            // labelBook
            // 
            labelBook.AutoSize = true;
            labelBook.Location = new Point(70, 174);
            labelBook.Margin = new Padding(3);
            labelBook.Name = "labelBook";
            labelBook.Size = new Size(46, 20);
            labelBook.TabIndex = 18;
            labelBook.Text = "Book:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(426, 532);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(131, 29);
            buttonSave.TabIndex = 21;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(72, 481);
            labelDate.Margin = new Padding(3);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(44, 20);
            labelDate.TabIndex = 22;
            labelDate.Text = "Date:";
            // 
            // textBoxDate
            // 
            textBoxDate.BackColor = SystemColors.Window;
            textBoxDate.Location = new Point(125, 478);
            textBoxDate.Margin = new Padding(6);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.ReadOnly = true;
            textBoxDate.Size = new Size(170, 27);
            textBoxDate.TabIndex = 23;
            textBoxDate.Tag = "DisableFields";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(125, 207);
            listBoxBooks.Margin = new Padding(6);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(345, 104);
            listBoxBooks.TabIndex = 24;
            listBoxBooks.Tag = "EditFields";
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.Location = new Point(126, 362);
            listBoxUsers.Margin = new Padding(6);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(345, 104);
            listBoxUsers.TabIndex = 25;
            listBoxUsers.Tag = "EditFields";
            listBoxUsers.SelectedIndexChanged += listBoxUsers_SelectedIndexChanged;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(64, 136);
            labelStatus.Margin = new Padding(3);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(52, 20);
            labelStatus.TabIndex = 26;
            labelStatus.Text = "Status:";
            // 
            // textBoxStatus
            // 
            textBoxStatus.BackColor = SystemColors.Window;
            textBoxStatus.Location = new Point(125, 133);
            textBoxStatus.Margin = new Padding(6);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(170, 27);
            textBoxStatus.TabIndex = 27;
            textBoxStatus.Tag = "DisableFields";
            // 
            // FormRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 592);
            Controls.Add(textBoxStatus);
            Controls.Add(labelStatus);
            Controls.Add(listBoxUsers);
            Controls.Add(listBoxBooks);
            Controls.Add(textBoxDate);
            Controls.Add(labelDate);
            Controls.Add(buttonSave);
            Controls.Add(textBoxBook);
            Controls.Add(labelBook);
            Controls.Add(textBoxUser);
            Controls.Add(labelUser);
            Controls.Add(textBoxId);
            Controls.Add(labelId);
            Controls.Add(labelRecord);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRecord";
            Text = "Record";
            Load += FormRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRecord;
        private TextBox textBoxId;
        private Label labelId;        
        private Label labelUser;
        private TextBox textBoxUser;
        private TextBox textBoxBook;
        private Label labelBook;
        private Button buttonSave;
        private Label labelDate;
        private TextBox textBoxDate;
        private ListBox listBoxBooks;
        private ListBox listBoxUsers;
        private Label labelStatus;
        private TextBox textBoxStatus;
    }
}