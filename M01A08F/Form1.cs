namespace M01A08F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int n = 0;
            int.TryParse(txtBox.Text, out n);
            int d = 2 * n;
            lblMsg.Text = "O dobro de " + n + " é de " + d;
            lblMsg.Visible = true;
        }
    }
}