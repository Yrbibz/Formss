using System.Windows.Forms;

namespace copiaecola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb1.Text);
            Clipboard.SetText(rtb1.SelectedText);
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb2.Text = Clipboard.GetText();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Text = null;
            rtb2.Text = null;
        }
    }
}