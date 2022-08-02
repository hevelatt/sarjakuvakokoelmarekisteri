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
            // Alusta julkaisut tyhjäksi listaksi.
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
            AvaaKokoelma(ValittuKokoelma);
        }

        /// <summary>Avaa kokoelma ja hae sen julkaisut.</summary>
        internal void AvaaKokoelma(Kokoelma? kokoelma)
        {
            if (AvattuKokoelma == kokoelma) return;

            // Hae avattavan kokoelman julkaisut.
            if (kokoelma == null)
            {
                Julkaisut.Clear();
            }
            else
            {
                Julkaisut = tietokantahallinta.HaeJulkaisut(kokoelma);
            }
            // Nollaa julkaisuvalinta.
            ValitseJulkaisu(null);

            AvattuKokoelma = kokoelma;

            // Ilmoita kokoelman avaamisesta kuuntelijoille.
            KokoelmaAvattu?.Invoke(this, EventArgs.Empty);
        }

        internal bool LuoKokoelma(string nimi)
        {
            // Hae kokoelmat jos kokoelman luonti onnistuu.
            if (tietokantahallinta.LuoKokoelma(nimi))
            {
                Kokoelmat = tietokantahallinta.HaeKokoelmat();
                return true;
            }
            return false;
        }

        /// <summary>Poista valittu kokoelma.</summary>
        internal void PoistaKokoelma()
        {
            if (ValittuKokoelma != null)
            {
                PoistaKokoelma(ValittuKokoelma);
                // Valitse tyhjä kokoelma kun valittu kokoelma on poistettu.
                ValitseKokoelma(null);
            }
        }

        internal void PoistaKokoelma(Kokoelma kokoelma)
        {
            // Poista tietokannasta.
            tietokantahallinta.PoistaKokoelma(kokoelma);
            // Poista haetuista kokoelmista.
            Kokoelmat.Remove(kokoelma);

            // Jos poistettiin avattu kokoelma, avaa tyhjä kokoelma.
            if (kokoelma == AvattuKokoelma)
            {
                AvaaKokoelma(null);
            }
        }

        internal void ValitseJulkaisu(Julkaisu? julkaisu)
        {
            ValittuJulkaisu = julkaisu;

            // Ilmoita julkaisun valitsemisesta kuuntelijoille.
            JulkaisuValittu?.Invoke(this, EventArgs.Empty);
        }

        internal void LisaaJulkaisu(string nimi, string numero, string sarja, string vuosi)
        {
            // Etsi sarjaa vastaava sarja-id.
            int? sarjaId;
            // Julkaisuun ei liity sarjaa.
            if (string.IsNullOrWhiteSpace(sarja))
            {
                sarjaId = null;
            }
            // Sarja on jo olemassa.
            else if (Sarjat.ContainsValue(sarja))
            {
                sarjaId = Sarjat.First(idNimi => idNimi.Value == sarja).Key;
            }
            // Luo uusi sarja.
            else
            {
                // Lisää sarja tietokantaan.
                tietokantahallinta.LisaaSarja(sarja);
                // Hae sarjat tietokannasta, jotta saadaan selville oikea id.
                Sarjat = tietokantahallinta.HaeSarjat();
                // Selvitä tietokantaan juuri lisätyn sarjan id.
                sarjaId = Sarjat.First(idNimi => idNimi.Value == sarja).Key;
            }

            // Tulkitse luku null-arvoksi jos sen parsiminen ei onnistu.
            int? LueLukuTaiNull(string merkkijono) => int.TryParse(merkkijono, out int luku) ? luku : null;

            if (tietokantahallinta.LisaaJulkaisu(
                string.IsNullOrEmpty(nimi) ? null : nimi,
                LueLukuTaiNull(numero),
                sarjaId,
                LueLukuTaiNull(vuosi), 
                AvattuKokoelma!.Id))
            {
                // Päivitä julkaisulista jos julkaisun lisääminen tietokantaan onnistui.
                Julkaisut = tietokantahallinta.HaeJulkaisut(AvattuKokoelma);
            }
        }

        /// <summary>Poista valittu julkaisu.</summary>
        internal void PoistaJulkaisu()
        {
            if (ValittuJulkaisu != null)
            {
                PoistaJulkaisu(ValittuJulkaisu);
                // Valitse tyhjä julkaisu kun valittu julkaisu on poistettu.
                ValitseJulkaisu(null);
            }
        }

        internal void PoistaJulkaisu(Julkaisu julkaisu)
        {
            // Poista tietokannasta.
            tietokantahallinta.PoistaJulkaisu(julkaisu);
            // Poista haetuista julkaisuista.
            Julkaisut.Remove(julkaisu);
        }
    }
}
