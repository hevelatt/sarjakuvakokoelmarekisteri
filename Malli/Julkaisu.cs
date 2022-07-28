namespace Sarjakuvakokoelmarekisteri.Malli
{
    internal class Julkaisu
    {
        public string Nimi { get; }
        public int Numero { get; }
        public Sarja Sarja { get; }
        public int Vuosi { get; }

        public Julkaisu(string nimi, int numero, Sarja sarja, int vuosi)
        {
            Nimi = nimi;
            Numero = numero;
            Sarja = sarja;
            Vuosi = vuosi;
        }
    }
}
