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
        public string forma { get; set; }

        public Forma(string forma)
        {

        }


        Forma generuoklis()
        {
            Random rd = new Random();
            Forma gk = new Forma(Forma.formosgeneratorius(rd.Next(1, Konstantos.frm)));
            return gk;
        }

        public static string formosgeneratorius(int variantas)
        {

            string[] telefonoforma = { "Islenktas", "Lankstomas", "Super Plonas" };
            return telefonoforma[variantas - 1];



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GeneruotiTelefona();
        }

        naujastelefonas GeneruotiTelefona()
        {
            // forma

            // parametrai

            // os
            OperacineSistema oS = GeneruotiOS();
            //returnui
            naujastelefonas telefonas = new naujastelefonas();
            return telefonas;
        }

        OperacineSistema GeneruotiOS()
        {
            Random rnd = new Random();
            OperacineSistema oS = new OperacineSistema(OperacineSistema.GetVarianta(rnd.Next(1, Konstantos.OS_VARIANTAI)));
            return oS;
        }

        void IsvestiTelefonaKonsolen(naujastelefonas telefonas)
        {
            Console.WriteLine();
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
            string[] oSVariantai = { "Android", "Apple iOS", "Windows" };
            return oSVariantai[variantas - 1];
        }

        public override string ToString()
        {
            return String.Format("{0}", Pavadinimas);
        }
    }

    class Parametrai
    {
        public double Procesorius { get; private set; }
        public double Istrizaine { get; private set; }

        public Parametrai(double procesorius, double istrizaine)
        {
            Procesorius = procesorius;
            Istrizaine = istrizaine;
        }
    }

    public class Konstantos
    {
        public const int OS_VARIANTAI = 3;
        public const int frm = 3;

    }
}
