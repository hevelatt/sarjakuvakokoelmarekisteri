namespace Sarjakuvakokoelmarekisteri.Nakyma
{
    public partial class Paaikkuna : Form
    {
        private Kokoelmavalinta kokoelmavalinta; 
        public Paaikkuna()
        {
            InitializeComponent();
            kokoelmavalinta = new Kokoelmavalinta();
        }

        private void avaaKokoelmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kokoelmavalinta.ShowDialog();
        }
    }
}