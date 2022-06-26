namespace M01A12WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTxt.Text = $"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";
        }
    }
}