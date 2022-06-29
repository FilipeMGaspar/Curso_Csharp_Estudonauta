namespace M01A14_EX004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {

            float num = 0f;

            float.TryParse(txtNum.Text, out num);
            
            await Task.Delay(500);
            lblVal.Text += num;
            lblVal.Visible = true;

            await Task.Delay(500);
            lbl_Int.Text += (int)num;
            lbl_Int.Visible = true;

            await Task.Delay(500);
            lbl_IntRd.Text += Convert.ToInt16(num);
            lbl_IntRd.Visible = true;

            txtNum.Visible = false;
            btnOK.Visible = false;
            lblTxt.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}