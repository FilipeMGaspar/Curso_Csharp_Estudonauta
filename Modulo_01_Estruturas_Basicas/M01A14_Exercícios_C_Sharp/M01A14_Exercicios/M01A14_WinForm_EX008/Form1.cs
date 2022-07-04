namespace M01A14_WinForm_EX008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Btn_sorteia_Click(object sender, EventArgs e)
        {
            int inicio;
            int fim;
            int sorteado;
            Random gerador = new Random();

            int.TryParse(txt_Inicio.Text, out inicio);
            int.TryParse(txt_Fim.Text, out fim);
            sorteado = gerador.Next(inicio, (fim + 1));

           
            
            await Task.Delay(700);            
            lblSorte.Text = "Vou sortear um número";
            await Task.Delay(200);
            lblSorte.Visible = true;
            await Task.Delay(500);
            lblSorte.Text += " . ";
            await Task.Delay(500);
            lblSorte.Text += ". ";
            await Task.Delay(500);
            lblSorte.Text += ". ";
            await Task.Delay(500);
            lblSorte.Text += ". ";
            await Task.Delay(500);
            lblSorte.Text += ". ";
            await Task.Delay(1000);

            lblSorte.Text = $"Entre o {inicio} e o {fim} sorteei o nº {sorteado}";
        }
    }
}