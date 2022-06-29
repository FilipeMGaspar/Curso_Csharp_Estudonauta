namespace M01A14_EX004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            float num = 0f;

            float.TryParse(txtNum.Text, out num);
            lblVal.Text += num;
        }
    }
}