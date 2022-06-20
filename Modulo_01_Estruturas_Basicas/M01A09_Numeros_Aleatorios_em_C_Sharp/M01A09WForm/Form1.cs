namespace M01A09WForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Random gerador = new Random();
            int n = gerador.Next(1, 11);
            lblNum.Text = n.ToString();
            
        }
    }
}