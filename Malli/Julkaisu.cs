namespace Sarjakuvakokoelmarekisteri.Malli
{
    internal class Julkaisu
    {
        public int Id { get; }
        public string? Nimi { get; }
        public short? Numero { get; }
        public int? SarjaID { get; }
        public short? Vuosi { get; }

        public Julkaisu(int id, string? nimi, short? numero, int? sarjaId, short? vuosi)
        {
            Id = id;
            Nimi = nimi;
            Numero = numero;
            SarjaID = sarjaId;
            Vuosi = vuosi;
        }
    }
}
