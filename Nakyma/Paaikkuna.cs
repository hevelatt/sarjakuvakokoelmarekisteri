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
            // Lisää kuuntelijat.
            rekisterihallinta.KokoelmaAvattu += rekisterihallinta_KokoelmaValittu;
            rekisterihallinta.JulkaisuValittu += rekisterihallinta_JulkaisuValittu;

            InitializeComponent();
            kokoelmavalinta = new Kokoelmavalinta(rekisterihallinta);

            NaytaSarjat();
            // Näytä aluksi kokoelmavalinta.
            kokoelmavalinta.ShowDialog();
        }

        private void NaytaJulkaisut()
        {
            listViewJulkaisut.Items.Clear();
            foreach (var julkaisu in rekisterihallinta.Julkaisut)
            {
                // Luo uusi lista-alkio jonka tunnisteena (Tag) on julkaisuviiteolio.
                listViewJulkaisut.Items.Add(new ListViewItem(new[]{
                    julkaisu.Nimi,
                    julkaisu.Numero.ToString(),
                    julkaisu.SarjaID.HasValue ? rekisterihallinta.Sarjat[julkaisu.SarjaID.Value] : "",
                    julkaisu.Vuosi.ToString()
                }){ BackColor = Color.WhiteSmoke, Tag = julkaisu });
            }
        }

        private void NaytaSarjat()
        {
            comboBoxSarja.Items.Clear();
            comboBoxSarja.Items.AddRange(rekisterihallinta.Sarjat.Values.ToArray());
        }

        private void rekisterihallinta_KokoelmaValittu(object? sender, EventArgs e)
        {
            NaytaJulkaisut();
            // Ota painike käyttöön jos kokoelma on valittu.
            buttonLisaa.Enabled = rekisterihallinta.ValittuKokoelma != null;
        }

        private void rekisterihallinta_JulkaisuValittu(object? sender, EventArgs e)
        {
            // Ota painike käyttöön jos julkaisu on valittu.
            buttonPoista.Enabled = rekisterihallinta.ValittuJulkaisu != null;
        }

        private void avaaKokoelmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kokoelmavalinta.ShowDialog();
        }

        private void listViewJulkaisut_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valitse valitun lista-alkion tunnisteena ollut julkaisu tai null jos poistetaan valinta.
            rekisterihallinta.ValitseJulkaisu(
                listViewJulkaisut.SelectedItems.Count > 0 ?
                (Julkaisu)listViewJulkaisut.SelectedItems[0].Tag : null);
        }

        private void buttonPoista_Click(object sender, EventArgs e)
        {
            rekisterihallinta.PoistaJulkaisu();
            NaytaJulkaisut();
        }

        private void buttonLisaa_Click(object sender, EventArgs e)
        {
            rekisterihallinta.LisaaJulkaisu(
                textBoxNimi.Text, textBoxNumero.Text, comboBoxSarja.Text, textBoxVuosi.Text);
            NaytaSarjat();
            NaytaJulkaisut();
        }
    }
}