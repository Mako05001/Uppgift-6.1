using System;
namespace upgift6
{
    class program
    {
        static int Addera(int tal1,int tal2,int tal3)
        {
            int total = tal1 + tal2 + tal3;
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv första talet");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv andra talet");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("skriv tredje talet");
            int tal3 = int.Parse(Console.ReadLine());
            int total = Addera(tal1, tal2, tal3);
            Console.WriteLine("totala blir" + total);
        }
    }
}
