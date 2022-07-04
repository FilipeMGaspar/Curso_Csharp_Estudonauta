namespace M01A14_WinForm_EX008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_sorteia_Click(object sender, EventArgs e)
        {
            int inicio;
            int fim;
            Random gerador = new Random();

            int.TryParse(txt_Inicio.Text, out inicio);
            int.TryParse(txt_Fim.Text, out fim);
        }
    }
}