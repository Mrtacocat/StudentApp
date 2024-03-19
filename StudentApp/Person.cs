using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Person
    {
        public string _fornavn;
        public string _etternavn;

        public string Fornavn 
        { 
            get { return pent(_fornavn); }
            set { _fornavn = value; }
        }

        public string Etternavn { 
            get { return pent(_etternavn); }
            set { _etternavn = value; }
        }

        
        public String pent(String navn)
        {
            if (navn == null || navn.Length == 0)
            {
                return ""; 
            }

            char i = navn.ToUpper().ToCharArray()[0];
            string n = navn.ToLower().ToString();
            return i + n.Substring(1);
        }

        public Person(string fornavn, string etternavn)
        {
            fornavn = Fornavn;
            etternavn = Etternavn;
        }

    }
}
