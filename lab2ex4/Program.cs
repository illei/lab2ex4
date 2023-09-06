using System;

namespace lab2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*: Scrieti un program care va determina daca un numar este sau nu
        palindrom.*/
            string inversul="";
            int conversie;

            int x = int.Parse(Console.ReadLine());
            int y = x;/*palceholder*/
            while (x != 0)
            {
                 inversul = inversul + x % 10;

                x = x / 10;


            }

            
            Console.WriteLine("inversul este : " + inversul);
            conversie = Int16.Parse(inversul);
            if (y == conversie)
            {
                Console.WriteLine("este plaindrom");
            }

        }
    }
}
