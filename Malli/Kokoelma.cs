namespace Sarjakuvakokoelmarekisteri.Malli
{
    internal class Kokoelma
    {
        public int Id { get; }
        public string Nimi { get; }

        public Kokoelma(int id, string nimi)
        {
            Id = id;
            Nimi = nimi;
        }

        public override string ToString()
        {
            return Nimi;
        }
    }
}
