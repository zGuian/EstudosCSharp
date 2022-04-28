namespace M01A12B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMos_Click(object sender, EventArgs e)
        {
            lblMsg.Text = $"Hoje é dia {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";
            lblMsg.Visible = true;
        }
    }
}