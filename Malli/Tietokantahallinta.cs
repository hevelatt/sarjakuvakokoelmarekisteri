using System.Data.SqlClient;

namespace Sarjakuvakokoelmarekisteri.Malli
{
    internal class Tietokantahallinta
    {
        private readonly string yhteysmerkkijono;

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

        internal List<Julkaisu> HaeJulkaisut(Kokoelma kokoelma)
        {
            List<Julkaisu> julkaisut = new();
            using (SqlConnection yhteys = new(yhteysmerkkijono))
            {
                try
                {
                    yhteys.Open();
                    SqlCommand julkaisuHakukomento = new(
                        "SELECT JulkaisuNimi, JulkaisuNumero, SarjaNimi, JulkaisuVuosi" +
                        "FROM Julkaisu LEFT JOIN Sarja ON Julkaisu.SarjaID = Sarja.SarjaID" +
                        "WHERE KokoelmaID = " + kokoelma.Id, yhteys);
                    SqlDataReader lukija = julkaisuHakukomento.ExecuteReader();
                    while (lukija.Read())
                    {
                        //julkaisut.Add();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return julkaisut;
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
    }
}
