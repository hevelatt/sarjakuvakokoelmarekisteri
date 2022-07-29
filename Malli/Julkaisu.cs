namespace Sarjakuvakokoelmarekisteri.Malli
{
    internal class Julkaisu
    {
        public string? Nimi { get; }
        public short? Numero { get; }
        public int? SarjaID { get; }
        public short? Vuosi { get; }

        public Julkaisu(string? nimi, short? numero, int? sarjaId, short? vuosi)
        {
            Nimi = nimi;
            Numero = numero;
            SarjaID = sarjaId;
            Vuosi = vuosi;
        }
    }
}
