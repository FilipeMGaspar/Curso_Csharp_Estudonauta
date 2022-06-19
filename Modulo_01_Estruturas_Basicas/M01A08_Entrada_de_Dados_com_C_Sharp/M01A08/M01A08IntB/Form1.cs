namespace M01A08IntB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            int d = num * 2;
            lblNum.Text = "O dobro de " + num + " é igual a " + d;
            lblNum.Visible = true;
        }
    }
}