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
