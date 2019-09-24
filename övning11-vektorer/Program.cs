using System;

namespace övning11_vektorer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Du ska nu mata in 5 tal...");
            Console.Write("Tal 1: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tal 2: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tal 3: ");
            int tal3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tal 4: ");
            int tal4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tal 5: ");
            int tal5 = Convert.ToInt32(Console.ReadLine());

            int[] tal = new int[5];
            tal[0] = tal1;
            tal[1] = tal2;
            tal[2] = tal3;
            tal[3] = tal4;
            tal[4] = tal5;

            int sum =0;
 
            for (int i = 0; i < tal.Length; i++)
            {
                Console.Write(tal[i]+"  ");
                sum+=tal[i];             
            }
            Console.WriteLine("| Dina tal tillsammans blir: "+sum);
            }

            catch
            {
                Console.WriteLine("Oj något gick snett, säker på att du skrev in siffror? ");
            }
        }
    }
}
