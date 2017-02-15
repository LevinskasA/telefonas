using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonai
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        Telefonas generuotiTelefona()
        {

        }
    }

    class OperacineSistema
    {
        string Pavadinimas { get; private set; }

        public OperacineSistema(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
        }

        public string GetVariantai(int variantas)
        {
            if (variantas == 1)
            {
                return "Android";
            }
            else if (true)
            {
                return "Apple iOS";
            }
            else if (true)
            {
                return "Windows";
            }
            else
            {
                return "OutOfOSBounds";
            }
        }
    }
}
