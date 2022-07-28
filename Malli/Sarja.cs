namespace Sarjakuvakokoelmarekisteri.Malli
{
    internal class Sarja
    {
        public int Id { get; }
        public string Nimi { get; }

        public Sarja(int id, string nimi)
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
