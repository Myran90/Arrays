using System;

namespace övning12_vektorer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namns = new string[5];

            for (int i = 0; i < namns.Length; i++)
            {
                Console.Write("Skriv in ett namn: ");
                string namn = Console.ReadLine();
                namns[i] += namn;        
            }

            Console.Clear();
            for (int i = 0; i < namns.Length; i++)
            {
                Console.WriteLine("Namn "+"["+i+"]"+":"+namns[i]);
            }
            
            while(true)
            {
            Console.WriteLine("För att avsluta programmet tryck: Q eller q och sedan ENTER...");
            Console.WriteLine("Tryck ENTER för att byta namn...");
            string svar = Console.ReadLine();
            if (svar == "q" || svar=="Q")
            {
                Console.Clear();
                Console.WriteLine("Programmet avslutas...");
                return;
            }

            try
            {
            Console.WriteLine("Vilket namn vill du byta ut? välj mellan [0-4] ");
            int val = Convert.ToInt32(Console.ReadLine());
            namns[val] = "";
            Console.WriteLine("Skriv in ett nytt namn: ");
            namns[val]=Console.ReadLine();
            Console.Clear();
            }

            catch
            {
                Console.Clear();
                Console.WriteLine("Du måste välja en siffra mellan 0-4, prova igen...");
            }

            for (int i = 0; i < namns.Length; i++)
            {
                Console.WriteLine("Namn "+"["+i+"]"+":"+namns[i]);
            }
            }
        }
    }
}
