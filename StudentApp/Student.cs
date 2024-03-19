namespace StudentApp
{
    internal class Student : Person
    {
        public int StudentNr { get; set; }
        public char Kjønn { get; set; }
        public int FødtÅr { get; set; }

        public Student(string fornavn, string etternavn, int studentNr, char kjønn, int fødtÅr) 
            : base(fornavn, etternavn)
        {
            studentNr = StudentNr;
            kjønn = Kjønn;
            fødtÅr = FødtÅr;
        }

        public Student(string fornavn, string etternavn) : base(fornavn, etternavn)
        {
        }

        public String navn()
        {
            return pent(Fornavn) + " " + pent(Etternavn);
        }


        public override string ToString()
        {
            return StudentNr + " " + pent(Fornavn) + " " + pent(Etternavn) + " " + Kjønn + " " + FødtÅr;
        }
    }
}
