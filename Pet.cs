using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Pet
    {

        //Fields

        private string name;
        private int hunger;
        private int thirst;
        private int sleep;


        //Properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int Sleep
        {
            get { return this.sleep; }
            set { this.sleep = value; }
        }



        // Constructors

        public Pet()

        {
            this.Name = "Ruby";
            this.Hunger = 50;
            this.Thirst = 50;
            this.Sleep = 50;

        }


        //Methods 


        public void Feed()

        {
            Console.WriteLine("Would you like to feed {0}?", name);
            string feedAnswer = Console.ReadLine().ToUpper();

            if (feedAnswer == "YES")
            {
                Console.WriteLine("What would you like to feed {0} peanut butter or dog food?", name);
                string foodChoice = Console.ReadLine();
                Console.WriteLine("You feed {0}.", name);


                switch (foodChoice)
                {
                    case "peanut butter":
                        hunger = hunger + 10;
                        break;
                    case "dog food":
                        hunger = hunger + 5;
                        break;
                }
            }
            if (feedAnswer == "NO")

            {
                hunger = hunger - 30;

            }



        }

        //Drink Method

        public void Drink()

        {
            Console.WriteLine("Would you like to give {0} water?", name);
            string drinkAnswer = Console.ReadLine().ToUpper();

            if (drinkAnswer == "YES")
            {
                Console.WriteLine("Woof! Woof! :)");
                thirst = thirst + 10;

            }
            else if (drinkAnswer == "NO")

            {
                Console.WriteLine(":(");
                thirst = thirst - 30;
            }

        }

        //Sleep Method

        public void Nap()

        {
            Console.WriteLine("Would you like to put {0} to bed?", name);
            string sleepAnswer = Console.ReadLine().ToUpper();

            if (sleepAnswer == "YES")
            {
                Console.WriteLine("Woof! Good night....Woof! :)");
                sleep = sleep + 10;


            }
            else if (sleepAnswer == "NO")

            {
                Console.WriteLine(":(");
                sleep = sleep - 30;
            }


        }

        public void Tick()
        {
            hunger = hunger + 10;
            thirst = thirst + 10;
            sleep = sleep + 10;

        }

        //Runaway Method

        //i.e. if hunger 





        public void PrintStats()

        {
            Console.WriteLine("Hunger: " + this.hunger);
            Console.WriteLine("Thirst: " + this.thirst);
            Console.WriteLine("Sleep: " + this.sleep);

        }






    }
}
