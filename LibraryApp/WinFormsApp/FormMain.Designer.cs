namespace WinFormsApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            pictureBoxBook = new PictureBox();
            buttonRecords = new Button();
            buttonUsers = new Button();
            buttonBooks = new Button();
            panelMain = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBook).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlDarkDark;
            panelMenu.Controls.Add(pictureBoxBook);
            panelMenu.Controls.Add(buttonRecords);
            panelMenu.Controls.Add(buttonUsers);
            panelMenu.Controls.Add(buttonBooks);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(280, 840);
            panelMenu.TabIndex = 0;
            // 
            // pictureBoxBook
            // 
            pictureBoxBook.Image = Properties.Resources.icons8_open_book_100;
            pictureBoxBook.Location = new Point(91, 61);
            pictureBoxBook.Name = "pictureBoxBook";
            pictureBoxBook.Size = new Size(100, 100);
            pictureBoxBook.TabIndex = 0;
            pictureBoxBook.TabStop = false;
            // 
            // buttonRecords
            // 
            buttonRecords.FlatAppearance.BorderSize = 0;
            buttonRecords.FlatStyle = FlatStyle.Flat;
            buttonRecords.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRecords.ForeColor = SystemColors.ButtonFace;
            buttonRecords.Location = new Point(0, 281);
            buttonRecords.Margin = new Padding(0);
            buttonRecords.Name = "buttonRecords";
            buttonRecords.Size = new Size(280, 75);
            buttonRecords.TabIndex = 2;
            buttonRecords.Text = "RECORDS";
            buttonRecords.UseVisualStyleBackColor = true;
            buttonRecords.Click += buttonRecords_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.FlatAppearance.BorderSize = 0;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonUsers.ForeColor = SystemColors.ButtonFace;
            buttonUsers.Location = new Point(0, 356);
            buttonUsers.Margin = new Padding(0);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(280, 75);
            buttonUsers.TabIndex = 1;
            buttonUsers.Text = "USERS";
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonBooks
            // 
            buttonBooks.FlatAppearance.BorderSize = 0;
            buttonBooks.FlatStyle = FlatStyle.Flat;
            buttonBooks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonBooks.ForeColor = SystemColors.ButtonFace;
            buttonBooks.Location = new Point(0, 206);
            buttonBooks.Margin = new Padding(0);
            buttonBooks.Name = "buttonBooks";
            buttonBooks.Size = new Size(280, 75);
            buttonBooks.TabIndex = 0;
            buttonBooks.Text = "BOOKS";
            buttonBooks.UseVisualStyleBackColor = true;
            buttonBooks.Click += buttonBooks_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(280, 0);
            panelMain.Margin = new Padding(0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1150, 840);
            panelMain.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 840);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            Text = "Library";
            Load += FormMain_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBook).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelMain;
        private Button buttonBooks;
        private Button buttonRecords;
        private Button buttonUsers;
        private PictureBox pictureBoxBook;
    }
}
