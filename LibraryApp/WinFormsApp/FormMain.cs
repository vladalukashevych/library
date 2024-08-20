using WinFormsApp.Forms;

namespace WinFormsApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public void LoadForm(object form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = (Form)form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            LoadForm(new FormBooks());
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            LoadForm(new FormRecords());
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            LoadForm(new FormUsers());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadForm(new FormBooks());
        }
    }
}
