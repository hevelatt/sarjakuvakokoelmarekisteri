using Sarjakuvakokoelmarekisteri.Kasittelija;

namespace Sarjakuvakokoelmarekisteri.Nakyma
{
    public partial class Paaikkuna : Form
    {
        private Kokoelmavalinta kokoelmavalinta;
        private Rekisterihallinta rekisterihallinta = new();

        public Paaikkuna()
        {
            // Kuuntele kokoelman avaamista.
            rekisterihallinta.KokoelmaAvattu += (_, __) => NaytaJulkaisut();

            InitializeComponent();
            kokoelmavalinta = new Kokoelmavalinta(rekisterihallinta);
        }

        private void NaytaJulkaisut()
        {
            listViewJulkaisut.Items.Clear();
            foreach (var julkaisu in rekisterihallinta.Julkaisut)
            {
                listViewJulkaisut.Items.Add(new ListViewItem(new[]{
                    julkaisu.Nimi,
                    julkaisu.Numero.ToString(),
                    julkaisu.SarjaID.HasValue ? rekisterihallinta.Sarjat[julkaisu.SarjaID.Value] : "",
                    julkaisu.Vuosi.ToString()
                }){ BackColor = Color.WhiteSmoke });
            }
        }

        private void avaaKokoelmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kokoelmavalinta.ShowDialog();
        }
    }
}