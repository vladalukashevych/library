namespace WinFormsApp.Forms
{
    partial class FormBooks
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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(831, 783);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(146, 29);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(679, 783);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(146, 29);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(983, 783);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(146, 29);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 83);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1150, 663);
            dataGridView.TabIndex = 3;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(810, 27);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(213, 27);
            textBoxSearch.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(1029, 25);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(16, 20);
            label1.Name = "label1";
            label1.Size = new Size(91, 38);
            label1.TabIndex = 7;
            label1.Text = "Books";
            // 
            // FormBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 840);
            Controls.Add(label1);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridView);
            Controls.Add(buttonRemove);
            Controls.Add(buttonOpen);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBooks";
            Text = "FormBooks";
            Load += FormBooks_Load;
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
        private Label label1;
    }
}