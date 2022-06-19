namespace M01A08B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblMsg.Text = txtNome.Text;
            lblMsg.Visible = true;
        }
    }
}