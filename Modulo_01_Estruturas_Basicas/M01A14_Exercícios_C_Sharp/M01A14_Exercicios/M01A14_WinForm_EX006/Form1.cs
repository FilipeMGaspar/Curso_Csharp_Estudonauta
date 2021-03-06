namespace M01A14_WinForm_EX006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            int anoAtual = DateTime.Now.Year;
            int anoNasc;
            int.TryParse(txtAnoNasc.Text, out anoNasc);
            await Task.Delay(500);
            lblAnoAtual.Visible = true;
            lblAnoAtual.Text += anoAtual;

            await Task.Delay(500);
            lbl_Idade.Text = $"Quem nasceu {anoNasc}, vai ter {anoAtual - anoNasc} anos";
            lbl_Idade.Visible = true;
        }
    }
}