using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonai
{
    class naujastelefonas
    {
        public string forma { get; private set; }
        public string parametrai { get; private set; }
        public string operacinesistema { get; private set; }
        public naujastelefonas() { }
        public naujastelefonas(string forma, string parametrai, string operacinesistema)
        {
            this.forma = forma;
            this.parametrai = parametrai;
            this.operacinesistema = operacinesistema;

        }
    }
    class Forma
    {
        public string islenktas { get; set; }
        public string lankstomas { get; set; }
        public string superplonas { get; set; }
        public Forma() { }
        public Forma(string islenktas, string lankstomas, string superplonas)
        {
            this.islenktas = islenktas;
            this.lankstomas = lankstomas;
            this.superplonas = superplonas;

        }

        public string fromosgeneratorius(int variantas)
        {
            string[] telefonoforma = { "Islenktas", "Lankstomas", "Super Plonas" };

        }

        class Program
    {
        static void Main(string[] args)
        {

        }

        Telefonas generuotiTelefona()
        {
            // forma
            // parametrai
            OperacineSistema oS = generuotiOS();
        }

        OperacineSistema generuotiOS()
        {
            Random rnd = new Random();
            OperacineSistema oS = new OperacineSistema(OperacineSistema.GetVarianta(rnd.Next(1,Konstantos.OS_VARIANTAI)));
            return oS;
        }
        
    }

    class OperacineSistema
    {
        public string Pavadinimas { get; private set; }

        public OperacineSistema(string pavadinimas)
        {
            Pavadinimas = pavadinimas;

        }
        /// <summary>
        /// Grazina paprasyta OS varianta.
        /// </summary>
        /// <param name="variantas"></param>
        /// <returns></returns>
        public static string GetVarianta(int variantas)
        {
            string[] oSVariantai = { "Android","Apple iOS","Windows" };
            return oSVariantai[variantas-1];
        }
    }

    class Parametrai
    {

    }

    public class Konstantos
    {
        public const int OS_VARIANTAI = 3;
    }
}
