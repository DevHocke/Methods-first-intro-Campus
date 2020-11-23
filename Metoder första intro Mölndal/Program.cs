using System;

namespace Metoder_första_intro_Mölndal
{
    class Program
    {
        static void Main(string[] args)
        {

            bool keepGoing = true;

            while (keepGoing == true)
            {
                Console.WriteLine("Välkommen till miniräknaren");
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1. Addera två tal");
                Console.WriteLine("2. subtrahera två tal");
                Console.WriteLine("3. Avsluta programmet");

                string decision = Console.ReadLine();
                int choice = Convert.ToInt32(decision);

                if (choice == 1)
                {
                    Console.WriteLine(AddTwoNumbers());

                    
                }
                else if (choice == 2)
                {
                    Console.WriteLine(RemoveNumbers());
                }
                else if (choice == 3)
                {
                    keepGoing = EndProgram();
                }
            }
            
            Console.ReadLine();
        }

        private static bool EndProgram()
        {
            bool keepGoing;
            Console.WriteLine("Program exit");
            keepGoing = false;
            return keepGoing;
        }

        static int RemoveNumbers()
        {
            Console.WriteLine("Du valde 2 ");
            Console.WriteLine("Skriv det första talet");
            string first = Console.ReadLine();
            Console.WriteLine("Skriv det andra talet");
            string second = Console.ReadLine();

            int x = Convert.ToInt32(first);
            int y = Convert.ToInt32(second);

            Console.WriteLine("The sum is: " + (x - y));
            return x - y;
        }

        // Skapa en metod som tar in två afgument och returnerar summan
        static int AddTwoNumbers()
        {
            Console.WriteLine("Du valde 1 ");
            Console.WriteLine("Skriv det första talet");
            string first = Console.ReadLine();
            Console.WriteLine("Skriv det andra talet");
            string second = Console.ReadLine();

            int x = Convert.ToInt32(first);
            int y = Convert.ToInt32(second);

            Console.WriteLine("The sum is: " + (x + y));
            return x + y;
        }
       

    }
}
