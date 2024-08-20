namespace WinFormsApp.Forms
{
    partial class FormBook
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
            labelName = new Label();
            labelYear = new Label();
            labelPublisher = new Label();
            labelDescription = new Label();
            labelAuthor = new Label();
            labelGenre = new Label();
            labelId = new Label();
            labelBook = new Label();
            buttonEdit = new Button();
            textBoxId = new TextBox();
            textBoxName = new TextBox();
            textBoxYear = new TextBox();
            textBoxPublisher = new TextBox();
            textBoxAuthor = new TextBox();
            comboBoxGenre = new ComboBox();
            richTextBoxDescription = new RichTextBox();
            buttonSave = new Button();
            labelIsRemoved = new Label();
            checkBoxIsRemoved = new CheckBox();
            labelIsAvailable = new Label();
            checkBoxIsAvailable = new CheckBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(76, 115);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 1;
            labelName.Text = "Name:";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(83, 385);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(40, 20);
            labelYear.TabIndex = 2;
            labelYear.Text = "Year:";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Location = new Point(83, 346);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(72, 20);
            labelPublisher.TabIndex = 3;
            labelPublisher.Text = "Publisher:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(76, 189);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(88, 20);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "Description:";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(76, 152);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(57, 20);
            labelAuthor.TabIndex = 5;
            labelAuthor.Text = "Author:";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(83, 420);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(51, 20);
            labelGenre.TabIndex = 6;
            labelGenre.Text = "Genre:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(76, 80);
            labelId.Name = "labelId";
            labelId.Size = new Size(25, 20);
            labelId.TabIndex = 7;
            labelId.Text = "Id:";
            // 
            // labelBook
            // 
            labelBook.AutoSize = true;
            labelBook.Location = new Point(266, 20);
            labelBook.Name = "labelBook";
            labelBook.Size = new Size(49, 20);
            labelBook.TabIndex = 8;
            labelBook.Text = "BOOK";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(451, 532);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(135, 77);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(125, 27);
            textBoxId.TabIndex = 10;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(144, 114);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 11;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(142, 378);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(125, 27);
            textBoxYear.TabIndex = 12;
            // 
            // textBoxPublisher
            // 
            textBoxPublisher.Location = new Point(175, 343);
            textBoxPublisher.Name = "textBoxPublisher";
            textBoxPublisher.Size = new Size(125, 27);
            textBoxPublisher.TabIndex = 13;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(144, 149);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(125, 27);
            textBoxAuthor.TabIndex = 14;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(149, 418);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(151, 28);
            comboBoxGenre.TabIndex = 15;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(170, 189);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(246, 106);
            richTextBoxDescription.TabIndex = 16;
            richTextBoxDescription.Text = "";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(451, 532);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 17;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelIsRemoved
            // 
            labelIsRemoved.AutoSize = true;
            labelIsRemoved.Location = new Point(83, 478);
            labelIsRemoved.Name = "labelIsRemoved";
            labelIsRemoved.Size = new Size(75, 20);
            labelIsRemoved.TabIndex = 18;
            labelIsRemoved.Text = "Removed:";
            // 
            // checkBoxIsRemoved
            // 
            checkBoxIsRemoved.AutoSize = true;
            checkBoxIsRemoved.Location = new Point(166, 480);
            checkBoxIsRemoved.Name = "checkBoxIsRemoved";
            checkBoxIsRemoved.Size = new Size(18, 17);
            checkBoxIsRemoved.TabIndex = 19;
            checkBoxIsRemoved.UseVisualStyleBackColor = true;
            // 
            // labelIsAvailable
            // 
            labelIsAvailable.AutoSize = true;
            labelIsAvailable.Location = new Point(351, 77);
            labelIsAvailable.Name = "labelIsAvailable";
            labelIsAvailable.Size = new Size(74, 20);
            labelIsAvailable.TabIndex = 20;
            labelIsAvailable.Text = "Available:";
            // 
            // checkBoxIsAvailable
            // 
            checkBoxIsAvailable.AutoSize = true;
            checkBoxIsAvailable.Enabled = false;
            checkBoxIsAvailable.Location = new Point(431, 80);
            checkBoxIsAvailable.Name = "checkBoxIsAvailable";
            checkBoxIsAvailable.Size = new Size(18, 17);
            checkBoxIsAvailable.TabIndex = 21;
            checkBoxIsAvailable.UseVisualStyleBackColor = true;
            // 
            // FormBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 601);
            Controls.Add(checkBoxIsAvailable);
            Controls.Add(labelIsAvailable);
            Controls.Add(checkBoxIsRemoved);
            Controls.Add(labelIsRemoved);
            Controls.Add(buttonSave);
            Controls.Add(richTextBoxDescription);
            Controls.Add(comboBoxGenre);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxPublisher);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxName);
            Controls.Add(textBoxId);
            Controls.Add(buttonEdit);
            Controls.Add(labelBook);
            Controls.Add(labelId);
            Controls.Add(labelGenre);
            Controls.Add(labelAuthor);
            Controls.Add(labelDescription);
            Controls.Add(labelPublisher);
            Controls.Add(labelYear);
            Controls.Add(labelName);
            Name = "FormBook";
            Text = "Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelYear;
        private Label labelPublisher;
        private Label labelDescription;
        private Label labelAuthor;
        private Label labelGenre;
        private Label labelId;
        private Label labelBook;
        private Button buttonEdit;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private TextBox textBoxYear;
        private TextBox textBoxPublisher;
        private TextBox textBoxAuthor;
        private ComboBox comboBoxGenre;
        private RichTextBox richTextBoxDescription;
        private Button buttonSave;
        private Label labelIsRemoved;
        private CheckBox checkBoxIsRemoved;
        private Label labelIsAvailable;
        private CheckBox checkBoxIsAvailable;
    }
}