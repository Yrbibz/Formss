namespace diretórioTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //File.WriteAllText(txtCaminho.Text, txtConteudo.Text);
            try
            {
                File.WriteAllText(txtCaminho.Text, txtConteudo.Text);
                MessageBox.Show("Arquivo salvo com sucesso.");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar o arquivo");
            }
        }
    
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(txtCaminho.Text))
                {
                    txtConteudo.Text = File.ReadAllText(txtCaminho.Text);
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao abrir o arquivo");
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryPath = "C:\\Gaby";
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                    MessageBox.Show("Diretório criado com sucesso.");
                }
                else
                {
                    MessageBox.Show("O diretório já existe.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erro");
            }
        }
    }
}