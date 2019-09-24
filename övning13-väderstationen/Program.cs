using System;
using System.Collections.Generic;

namespace övning13_väderstationen
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<int> tempList = new List<int>();
            tempList.Add(0);
            tempList.Add(0);
            tempList.Add(0);
            tempList.Add(0);
            tempList.Add(0);

            int totalTemp = 0;
            
            while(true)
            {
            Console.WriteLine("==================================="); 
            Console.WriteLine("[L]ägg till temperatur");
            Console.WriteLine("[S]skriv ut lista för temperaturer");
            Console.WriteLine("[T]a bort temperaturer");
            Console.WriteLine("[A]vsluta programmet");
            Console.WriteLine("===================================");
            Console.Write("Ditt val: ");

            
            string val = Console.ReadLine();
            
            try
            {
            switch (val)
            {
                case "L":
                case "l":
                Console.Clear();
                Console.WriteLine("Mata in max 5 olika temperaturer: ");
                for (int i = 0; i < tempList.Count; i++)
                {
                    Console.Write("Temperatur "+i+": ");
                    int tempInput = Convert.ToInt32(Console.ReadLine());
                    tempList[i]=tempInput;
                    totalTemp+=tempInput;
                }
                break;
                
                case "S":
                case "s":
                Console.Clear();
                Console.WriteLine("============= Lista ===============");
                for (int i = 0; i < tempList.Count; i++)
                {
                    Console.WriteLine("Temperatur "+i+": "+tempList[i]);
                }
                Console.WriteLine("===================================");
                Console.WriteLine("Medeltemperaturen blir: "+totalTemp/5);
                break;

                case "T":
                case "t":
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("Listan är nu rensad...");
                for (int i = 0; i < tempList.Count; i++)
                {
                    tempList[i]=0;
                    totalTemp=0;
                }
                break;

                case "A":
                case "a":
                Console.Clear();
                Console.WriteLine("Välkommen åter! :D");
                return;
            }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Oj, något gick snett! kontrollera följande:");
                Console.WriteLine("Skrev du in för många siffror? (Max: 2147483647)...");
                Console.WriteLine("Skrev du in ett decimaltal?...");
                Console.WriteLine("Skrev du in bokstäver istället för siffror?...");
                Console.WriteLine("Du får bara skriva in siffror(heltal Max: 2147483647), försök igen...");
            }
            }
        }
        }
}
    
