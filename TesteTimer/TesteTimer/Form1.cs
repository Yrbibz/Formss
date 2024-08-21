namespace TesteTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            
            btnPausar.Enabled = true;
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
           
            btnZerar.Enabled = true;
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {

        }

        private void prgTimer_Click(object sender, EventArgs e)
        {
        }

        private void tmrProgresso_Tick(object sender, EventArgs e)
        {
           tmrProgresso.Start();
            prgTimer.Value = prgTimer.Value + 10;
            lblPorcentagem.Text = prgTimer.Value.ToString() + "%";
           
            if (prgTimer.Value == prgTimer.Maximum )
            {
                tmrProgresso.Stop();
                MessageBox.Show("Terminado");
                btnIniciar.Enabled = true;
                lblPorcentagem.Text = "0%";
                prgTimer.Value = 0;
           
            }

        }
    }
}