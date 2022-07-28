using Sarjakuvakokoelmarekisteri.Kasittelija;

namespace Sarjakuvakokoelmarekisteri.Nakyma
{
    public partial class Paaikkuna : Form
    {
        private Kokoelmavalinta kokoelmavalinta;
        private Rekisterihallinta rekisterihallinta = new();
        public Paaikkuna()
        {
            InitializeComponent();
            kokoelmavalinta = new Kokoelmavalinta(rekisterihallinta);
        }

        private void avaaKokoelmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kokoelmavalinta.ShowDialog();
        }
    }
}