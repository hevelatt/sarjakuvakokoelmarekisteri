using Sarjakuvakokoelmarekisteri.Kasittelija;
using Sarjakuvakokoelmarekisteri.Malli;

namespace Sarjakuvakokoelmarekisteri.Nakyma
{
    public partial class Paaikkuna : Form
    {
        private Kokoelmavalinta kokoelmavalinta;
        private Rekisterihallinta rekisterihallinta = new();

        public Paaikkuna()
        {
            rekisterihallinta.KokoelmaAvattu += rekisterihallinta_KokoelmaAvattu;
            rekisterihallinta.JulkaisuValittu += rekisterihallinta_JulkaisuValittu;

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
                }){ BackColor = Color.WhiteSmoke, Tag = julkaisu });
            }
        }

        private void rekisterihallinta_KokoelmaAvattu(object? sender, EventArgs e)
        {
            NaytaJulkaisut();
            rekisterihallinta.ValitseJulkaisu(null);
        }

        private void rekisterihallinta_JulkaisuValittu(object? sender, EventArgs e)
        {
            buttonPoista.Enabled = rekisterihallinta.ValittuJulkaisu != null;
        }

        private void avaaKokoelmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kokoelmavalinta.ShowDialog();
        }

        private void listViewJulkaisut_SelectedIndexChanged(object sender, EventArgs e)
        {
            rekisterihallinta.ValitseJulkaisu(
                listViewJulkaisut.SelectedItems.Count > 0 ?
                (Julkaisu)listViewJulkaisut.SelectedItems[0].Tag : null);
        }

        private void buttonPoista_Click(object sender, EventArgs e)
        {
            if (listViewJulkaisut.SelectedItems.Count > 0)
            {
                rekisterihallinta.PoistaJulkaisu((Julkaisu)listViewJulkaisut.SelectedItems[0].Tag);
                NaytaJulkaisut();
                rekisterihallinta.ValitseJulkaisu(null);
            }
        }
    }
}