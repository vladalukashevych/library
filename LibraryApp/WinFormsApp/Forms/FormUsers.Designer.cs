namespace WinFormsApp.Forms
{
    partial class FormUsers
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
            buttonAdd = new Button();
            buttonOpen = new Button();
            buttonRemove = new Button();
            dataGridView = new DataGridView();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(910, 769);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(798, 769);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(94, 29);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(1025, 769);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 29);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 72);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1150, 639);
            dataGridView.TabIndex = 3;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(810, 23);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(213, 27);
            textBoxSearch.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(1035, 21);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;           
            // 
            // FormUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 840);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridView);
            Controls.Add(buttonRemove);
            Controls.Add(buttonOpen);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUsers";
            Text = "FormUsers";
            Load += FormUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonOpen;
        private Button buttonRemove;
        private DataGridView dataGridView;
        private TextBox textBoxSearch;
        private Button buttonSearch;
    }
}