namespace StudentApp
{
    internal class Lærer : Person
    {
        public int _ansattNr;

        public int AnsattNr {
            get { return _ansattNr; }
            set { _ansattNr = value; } 
        }

        public Lærer(string fornavn, string etternavn, int ansattNr) 
            : base(fornavn, etternavn)
        {
            AnsattNr = ansattNr;
        }
    }
}
