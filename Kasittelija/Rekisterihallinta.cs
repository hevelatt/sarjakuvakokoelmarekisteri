using Sarjakuvakokoelmarekisteri.Malli;

namespace Sarjakuvakokoelmarekisteri.Kasittelija
{
    internal class Rekisterihallinta
    {
        private readonly Tietokantahallinta tietokantahallinta = new();

        internal event EventHandler? KokoelmaValittu;
        internal event EventHandler? KokoelmaAvattu;
        internal event EventHandler? JulkaisuValittu;

        /// <summary>Kokoelma, jonka käyttäjä on valinnut.</summary>
        internal Kokoelma? ValittuKokoelma { get; private set; }

        /// <summary>Kokoelma, jonka julkaisut on haettu.</summary>
        internal Kokoelma? AvattuKokoelma { get; private set; }

        /// <summary>Julkaisu, jonka käyttäjä on valinnut.</summary>
        internal Julkaisu? ValittuJulkaisu { get; private set; }

        internal List<Kokoelma> Kokoelmat { get; private set; }
        internal List<Julkaisu> Julkaisut { get; private set; }
        internal Dictionary<int, string> Sarjat { get; private set; }

        internal Rekisterihallinta()
        {
            Kokoelmat = tietokantahallinta.HaeKokoelmat();
            Sarjat = tietokantahallinta.HaeSarjat();

            // Alustetaan julkaisut tyhjäksi listaksi.
            Julkaisut = new List<Julkaisu>();
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

        internal bool LuoKokoelma(string nimi)
        {
            if (tietokantahallinta.LuoKokoelma(nimi))
            {
                Kokoelmat = tietokantahallinta.HaeKokoelmat();
                return true;
            }
            return false;
        }

        internal void ValitseJulkaisu(Julkaisu? julkaisu)
        {
            ValittuJulkaisu = julkaisu;
            JulkaisuValittu?.Invoke(this, EventArgs.Empty);
        }

        internal void PoistaJulkaisu(Julkaisu julkaisu)
        {
            tietokantahallinta.PoistaJulkaisu(julkaisu);
            Julkaisut.Remove(julkaisu);
        }
    }
}
