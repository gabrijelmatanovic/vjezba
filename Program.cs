using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace vjezba
{
    class KlasaB
    {
        public string bezPrvogIZadnjeg(string tekst)
        {
            tekst = tekst.Substring(1, tekst.Length - 2);
            return tekst;
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaB objekt = new KlasaB();
            Console.WriteLine("Upisi neki tekst duzi od dva znaka.");
            string tekst = Console.ReadLine();
            //provjera da li je duzi od dva znaka
            if (tekst.Length > 2)
            {
                //pozivanje metode iz KlaseB preko objekta
                Console.WriteLine(objekt.bezPrvogIZadnjeg(tekst));
            }
            else
            {
                Console.WriteLine("Tekst nije duzi od 2 znaka");
            }

            //pozivanje metode iz KlaseB preko objekta

            Console.ReadKey();
        }
    }
}
