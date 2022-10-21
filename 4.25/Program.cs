using System;

namespace uppgift_4._25
{ 
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Detta är ett menyprogram");

            string val = "";

            while (val != "3")
            {
                Console.WriteLine();
                Console.WriteLine("Välj ett av följande alternativ");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");
                val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        Console.WriteLine("Skriv in två tal");
                        double subTal1 = double.Parse(Console.ReadLine());
                        double subTal2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{subTal1}-{subTal2} = {subTal1 - subTal2}");
                        break;

                    case "2":
                        Console.WriteLine("Skriv in två tal");
                        double divTal1 = double.Parse(Console.ReadLine());
                        double divTal2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{divTal1}-{divTal2} = {divTal1 / divTal2}");
                        break;

                    case "3":
                        Console.WriteLine("Programmet avslutas...");
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ!");
                        break;
                }
            }
        }

    }

}