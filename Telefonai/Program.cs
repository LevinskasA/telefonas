using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonai
{
    class naujastelefonas
    {
        public Forma forma { get; private set; }
        public Parametrai parametrai { get; private set; }
        public OperacineSistema operacinesistema { get; private set; }
        public naujastelefonas() { }
        public naujastelefonas(Forma forma, Parametrai parametrai, OperacineSistema operacinesistema)
        {
            this.forma = forma;
            this.parametrai = parametrai;
            this.operacinesistema = operacinesistema;

        }

        public override string ToString()
        {
            return String.Format("{0}\n{1}{2}", forma.ToString(), parametrai.ToString(), operacinesistema.ToString());
        }
    }
    class Forma
    {
        public string forma { get; set; }

        public Forma(string forma)
        {
            this.forma = forma;
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

        public override string ToString()
        {
            return String.Format("Forma: {0}", forma);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.GeneruotiTelefona();
            Console.WriteLine(p.GeneruotiTelefona().ToString());
        }

        naujastelefonas GeneruotiTelefona()
        {
            // forma
            Forma forma = new Forma("Apvali");
            // parametrai
            Parametrai param = GeneruotiParam();
            // os
            OperacineSistema oS = GeneruotiOS();
            //returnui
            naujastelefonas telefonas = new naujastelefonas(forma, param, oS);
            return telefonas;
        }

        Parametrai GeneruotiParam()
        {
            Random rnd = new Random();
            double procesorius = rnd.Next(Konstantos.PROC_MIN, Konstantos.PROC_MAX) / 10.0;
            double istrizaine = rnd.Next(Konstantos.ISTRIZAINE_MIN, Konstantos.ISTRIZAINE_MAX) / 10.0;
            Parametrai param = new Parametrai(procesorius, istrizaine);
            return param;
        }

        OperacineSistema GeneruotiOS()
        {
            Random rnd = new Random();
            OperacineSistema oS = new OperacineSistema(OperacineSistema.GetVarianta(rnd.Next(1, Konstantos.OS_VARIANTAI + 1)));
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

        public override string ToString()
        {
            return String.Format("Procesoriaus dažnis: {0} GHz\nĮstrižainė: {1} coliai\n", Procesorius, Istrizaine);
        }
    }

    public class Konstantos
    {
        public const int OS_VARIANTAI = 3;
        public const int frm = 3;
        public const int PROC_MIN = 10;
        public const int PROC_MAX = 45;
        public const int ISTRIZAINE_MIN = 40;
        public const int ISTRIZAINE_MAX = 60;
    }
}
