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
            Console.WriteLine("Welcome to virtual pet!\nIn this game you are charged with taking care a Cairn Terrier.");
            Pet Ben = new Pet();
            string something;



            do

            {
                Ben.PrintStats();
                Ben.Tick();


                Console.WriteLine("What would you like to do?  Your choices are:");
                Console.WriteLine("1. Feed pet");
                Console.WriteLine("2. Water pet");
                Console.WriteLine("3. Put pet to bed");
                Console.WriteLine("Choose a number:");


                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Ben.Feed();
                }
                else if (choice == 2)
                {
                    Ben.Drink();

                }
                else if (choice == 3)
                {
                    Ben.Nap();
                }

                else
                {
                    Console.WriteLine(" Choose a number between 1-3");
                }


                Console.WriteLine("Do you want to go again?");
                something = Console.ReadLine();

                Console.Clear();
            }

            while (something == "yes");

            {

                Ben.PrintStats();
            }









        }

    }
}

