namespace M01A08WFormTentConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int num = 0; // variavel inteiro
            int.TryParse(txtNum.Text, out num);
            int d = num * 2;
            lblNum.Text = "O dobro de " + num + " é " + d;
            lblNum.Visible = true;
        }
    }
}