namespace M01A11B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "Olá";
            await Task.Delay(1000); //utilizando esse comando podemos utilizar em modo janela
            lblMsg.Text += ", tudo bem?";

            //Ficar de olho na versão do visual studio pois o task fica dentro da biblioteca (using Systems.Threading.Tasks;)
            //await Task.Delay(tempo em milesegundos);
        }
    }
}