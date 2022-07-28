using Sarjakuvakokoelmarekisteri.Malli;

namespace Sarjakuvakokoelmarekisteri.Kasittelija
{
    internal class Rekisterihallinta
    {
        private readonly Tietokantahallinta tietokantahallinta = new();

        internal event EventHandler? KokoelmaValittu;
        internal event EventHandler? KokoelmaAvattu;
        internal Kokoelma? ValittuKokoelma { get; private set; }
        internal Kokoelma? AvattuKokoelma { get; private set; }
        internal List<Kokoelma> Kokoelmat { get; private set; }
        internal List<Julkaisu> Julkaisut { get; private set; }
        internal List<Sarja> Sarjat { get; private set; }

        internal Rekisterihallinta()
        {
            Kokoelmat = tietokantahallinta.HaeKokoelmat();
            // Alustetaan julkaisut tyhjäksi listaksi.
            Julkaisut = new List<Julkaisu>();
            Sarjat = new List<Sarja>();
        }

        internal void ValitseKokoelma(Kokoelma? kokoelma)
        {
            ValittuKokoelma = kokoelma;

            // Ilmoita kokoelman valitsemisesta kuuntelijoille.
            KokoelmaValittu?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>Avaa valittu kokoelma.</summary>
        internal void AvaaKokoelma()
        {
            // Jos valittu kokoelma on jo avattu, ei avata.
            if (AvattuKokoelma == ValittuKokoelma) return;

            if (ValittuKokoelma == null)
            {
                Julkaisut.Clear();
            } 
            else
            {
                Julkaisut = tietokantahallinta.HaeJulkaisut(ValittuKokoelma);
            }
            
            AvattuKokoelma = ValittuKokoelma;

            // Ilmoita kokoelman avaamisesta kuuntelijoille.
            KokoelmaAvattu?.Invoke(this, EventArgs.Empty);
        }
    }
}
