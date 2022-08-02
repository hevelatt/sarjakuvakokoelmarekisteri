using System.Data.SqlClient;

namespace Sarjakuvakokoelmarekisteri.Malli
{
    internal class Tietokantahallinta
    {
        private readonly string yhteysmerkkijono;

        /// <summary>
        /// Lue tietokannan kentän arvo ja palauta arvo tyyppiä T tai null jos kentän arvo on NULL.
        /// </summary>
        private static T? LueNullArvo<T>(Object dbArvo) where T : struct 
        {
            return DBNull.Value.Equals(dbArvo) ? null : (T)dbArvo; 
        }

        /// <summary>
        /// Lue tietokannan kentän arvo ja palauta viitearvo tyyppiä T tai null jos kentän arvo on NULL.
        /// </summary>
        private static T? LueNullViite<T>(Object dbArvo) where T : class
        {
            return DBNull.Value.Equals(dbArvo) ? null : (T)dbArvo;
        }

        internal Tietokantahallinta()
        {
            yhteysmerkkijono =
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=Sarjakuvakokoelmarekisteri;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;" +
                "Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False";
        }

        internal List<Kokoelma> HaeKokoelmat()
        {
            List<Kokoelma> kokoelmat = new();
            using (SqlConnection yhteys = new(yhteysmerkkijono))
            {
                try
                {
                    yhteys.Open();
                    SqlCommand kokoelmaHakukomento = new(
                        "SELECT KokoelmaID, KokoelmaNimi FROM Kokoelma", yhteys);
                    SqlDataReader lukija = kokoelmaHakukomento.ExecuteReader();
                    while (lukija.Read())
                    {
                        kokoelmat.Add(new Kokoelma((int)lukija.GetValue(0), lukija.GetString(1)));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return kokoelmat;
        }

        internal bool LuoKokoelma(string nimi)
        {
            using (SqlConnection yhteys = new(yhteysmerkkijono))
            {
                try
                {
                    yhteys.Open();
                    SqlCommand kokoelmaLisayskomento = new(
                        "INSERT INTO Kokoelma (KokoelmaNimi) VALUES ('" + nimi + "')", yhteys);
                    kokoelmaLisayskomento.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            return true;
        }

        internal bool PoistaKokoelma(Kokoelma kokoelma)
        {
            using (SqlConnection yhteys = new(yhteysmerkkijono))
            {
                try
                {
                    yhteys.Open();
                    SqlCommand kokoelmaPoistokomento = new(
                        "DELETE FROM Kokoelma WHERE KokoelmaID = " + kokoelma.Id +
                        ";DELETE FROM Julkaisu WHERE KokoelmaID = " + kokoelma.Id, yhteys);
                    kokoelmaPoistokomento.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            return true;
        }

        internal Dictionary<int, string> HaeSarjat()
        {
            Dictionary<int, string> sarjat = new();
            using (SqlConnection yhteys = new(yhteysmerkkijono))
            {
                try
                {
                    yhteys.Open();
                    SqlCommand sarjaHakukomento = new(
                        "SELECT SarjaID, SarjaNimi FROM Sarja", yhteys);
                    SqlDataReader lukija = sarjaHakukomento.ExecuteReader();
                    while (lukija.Read())
                    {
                        sarjat[(int)lukija.GetValue(0)] = lukija.GetString(1);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return sarjat;
        }

        internal bool LisaaSarja(string nimi)
        {
            using (SqlConnection yhteys = new(yhteysmerkkijono))
            {
                try
                {
                    yhteys.Open();
                    SqlCommand sarjanLisayskomento = new(
                        "INSERT INTO Sarja (SarjaNimi) VALUES ('" + nimi + "')", yhteys);
                    sarjanLisayskomento.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            return true;
        }

        internal List<Julkaisu> HaeJulkaisut(Kokoelma kokoelma)
        {
            List<Julkaisu> julkaisut = new();
            using (SqlConnection yhteys = new(yhteysmerkkijono))
            {
                try
                {
                    yhteys.Open();
                    SqlCommand julkaisuHakukomento = new(
                        "SELECT JulkaisuID, JulkaisuNimi, JulkaisuNumero, SarjaID, JulkaisuVuosi " +
                        "FROM Julkaisu WHERE KokoelmaID = " + kokoelma.Id, yhteys);
                    SqlDataReader lukija = julkaisuHakukomento.ExecuteReader();
                    while (lukija.Read())
                    {
                        julkaisut.Add(new Julkaisu(
                            (int)lukija.GetValue(0),
                            LueNullViite<string>(lukija.GetValue(1)),
                            LueNullArvo<short>(lukija.GetValue(2)),
                            LueNullArvo<int>(lukija.GetValue(3)),
                            LueNullArvo<short>(lukija.GetValue(4))));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return julkaisut;
        }

        internal bool LisaaJulkaisu(string? nimi, int? numero, int? sarjaId, int? vuosi, int kokoelmaId)
        {
            using (SqlConnection yhteys = new(yhteysmerkkijono))
            {
                try
                {
                    yhteys.Open();
                    SqlCommand julkaisuLisayskomento = new(
                        "INSERT INTO Julkaisu (JulkaisuNimi, JulkaisuNumero, SarjaID, JulkaisuVuosi, KokoelmaID) VALUES (" +
                        (nimi == null ? "NULL" : "'" + nimi + "'") + ", " +
                        (numero == null ? "NULL" : numero) + ", " +
                        (sarjaId == null ? "NULL" : sarjaId) + ", " +
                        (vuosi == null ? "NULL" : vuosi) + ", " + 
                        kokoelmaId + ")", yhteys);
                    julkaisuLisayskomento.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            return true;
        }

        internal bool PoistaJulkaisu(Julkaisu julkaisu)
        {
            using (SqlConnection yhteys = new(yhteysmerkkijono))
            {
                try
                {
                    yhteys.Open();
                    SqlCommand julkaisuPoistokomento = new(
                        "DELETE FROM Julkaisu WHERE JulkaisuID = " + julkaisu.Id, yhteys);
                    julkaisuPoistokomento.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            return true;
        }
    }
}
