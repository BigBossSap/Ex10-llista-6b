using System;
using System.IO;

namespace Ex10_6b
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10.Volem fer un programa per mirar la rima d’una poesia. El programa em damanarà una
 rima i em dirà quans versos tenen aquesta rima consonant. No cal que controleu
 accents, però sí majúscules i minúscules. Per exemple:
 Feu amb i sense el mètode LastIndexOf()
 Entra rima? eso*/


            StreamReader sr = new StreamReader(@"poema.txt");


            string rima, poema;
            int cont=0;

            Console.WriteLine("Rima: ");
            rima = Console.ReadLine();


            poema = sr.ReadLine();
           
            while(poema!="FI")
            {
                if (poema.Substring(poema.Length - 3, 3).ToUpper().Contains(rima.ToUpper()))
                cont++;

                poema = sr.ReadLine();
            }

            Console.WriteLine(cont);
            sr.Close();

            
        }
    }
}
