using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet Ruby = new Pet();

            Console.WriteLine("Welcome to virtual pet!\nIn this game you are charged with taking care of a Cairn Terrier named Ruby.");
            Console.WriteLine("Her hunger, thirst, and sleep levels are below.\nYour task is to not let them get too low.");
  
            string something;
            
            do

            {
                Ruby.PrintStats();
                Ruby.Tick();
                Ruby.RunAway();

                Console.WriteLine("What would you like to do?  Your choices are:");
                Console.WriteLine("1. Feed Ruby");
                Console.WriteLine("2. Water Ruby");
                Console.WriteLine("3. Put Ruby to bed");
                Console.WriteLine("Choose a number:");


                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Ruby.Feed();
                }
                else if (choice == 2)
                {
                    Ruby.Drink();

                }
                else if (choice == 3)
                {
                    Ruby.Nap();
                }

                else
                {
                    Console.WriteLine(" Choose a number between 1-3");
                }


                Console.WriteLine("Do you want to continue?");
                something = Console.ReadLine().ToUpper();
                Console.Clear();

            }

            while (something == "YES");






        }

    }
}

