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
            // Kuuntele kokoelman valitsemista.
            this.rekisterihallinta.KokoelmaValittu += rekisterihallinta_KokoelmaValittu;

            InitializeComponent();
            NaytaKokoelmat();
        }

        private void NaytaKokoelmat()
        {
            listBoxKokoelmat.Items.Clear();
            foreach (var kokoelma in rekisterihallinta.Kokoelmat)
            {
                listBoxKokoelmat.Items.Add(kokoelma);
            }
        }

        private void rekisterihallinta_KokoelmaValittu(object? sender, EventArgs e)
        {
            // Jos valittu kokoelma on eri kuin null, salli painikkeen käyttö.
            buttonAvaa.Enabled = rekisterihallinta.ValittuKokoelma != null;
        }

        private void listBoxKokoelmat_SelectedIndexChanged(object sender, EventArgs e)
        {
            rekisterihallinta.ValitseKokoelma((Kokoelma)listBoxKokoelmat.SelectedItem);
        }

        private void buttonAvaa_Click(object sender, EventArgs e)
        {
            rekisterihallinta.AvaaKokoelma();
            Close();
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
    }
}
