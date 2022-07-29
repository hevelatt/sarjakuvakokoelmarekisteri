using Sarjakuvakokoelmarekisteri.Kasittelija;
using Sarjakuvakokoelmarekisteri.Malli;

namespace Sarjakuvakokoelmarekisteri.Nakyma
{
    public partial class Kokoelmavalinta : Form
    {
        private Rekisterihallinta rekisterihallinta;

        internal Kokoelmavalinta(Rekisterihallinta rekisterihallinta)
        {
            this.rekisterihallinta = rekisterihallinta;
            // Lisää kuuntelija kokoelman valitsemiselle.
            this.rekisterihallinta.KokoelmaValittu += rekisterihallinta_KokoelmaValittu;

            InitializeComponent();
            NaytaKokoelmat();
        }

        private void NaytaKokoelmat()
        {
            listBoxKokoelmat.Items.Clear();
            listBoxKokoelmat.Items.AddRange(rekisterihallinta.Kokoelmat.ToArray());
        }

        private void rekisterihallinta_KokoelmaValittu(object? sender, EventArgs e)
        {
            // Ota painikkeet käyttöön kun kokoelma on valittu.
            buttonPoista.Enabled = buttonAvaa.Enabled = rekisterihallinta.ValittuKokoelma != null;
        }

        private void listBoxKokoelmat_SelectedIndexChanged(object sender, EventArgs e)
        {
            rekisterihallinta.ValitseKokoelma((Kokoelma)listBoxKokoelmat.SelectedItem);
        }

        private void textBoxNimi_TextChanged(object sender, EventArgs e)
        {
            buttonLuo.Enabled = !string.IsNullOrWhiteSpace(textBoxNimi.Text);
        }

        private void buttonLuo_Click(object sender, EventArgs e)
        {
            if (rekisterihallinta.LuoKokoelma(textBoxNimi.Text))
            {
                NaytaKokoelmat();
            }
            else
            {
                MessageBox.Show("Kokoelman nimi on jo käytössä.", "Virhe");
            }
        }

        private void buttonAvaa_Click(object sender, EventArgs e)
        {
            rekisterihallinta.AvaaKokoelma();
            Close();
        }

        private void buttonPoista_Click(object sender, EventArgs e)
        {
            rekisterihallinta.PoistaKokoelma();
            NaytaKokoelmat();
        }
    }
}
