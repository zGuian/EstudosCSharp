namespace M01A08B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(txtBox.Text);
            int d = n * 2;
            lblMsg.Text = "O dobro de " + n + " é de " + d;
            lblMsg.Visible = true;
        }
    }
}