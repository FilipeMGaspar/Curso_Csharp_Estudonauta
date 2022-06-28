namespace M01A14_EX002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnInicio_Click(object sender, EventArgs e)
        {
            await Task.Delay(300);
            lblMeu.Visible = true;
            await Task.Delay(300);
            lblBr.Visible = true;
            await Task.Delay(300);
            lblBrleiro.Visible = true;
            await Task.Delay(1000);
            lblMeu.BackColor = Color.Blue;
            lblMeu.ForeColor = Color.White;
        }
    }
}