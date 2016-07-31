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
            this.Name = name;
            this.Hunger = 50;
            this.Thirst = 50;
            this.Sleep = 50;

        }


        //Methods 
        
            
         //Feed Method                          

    public void Feed()

        {
            Console.WriteLine("Are you sure you would you like to feed Ruby?");
            string feedAnswer = Console.ReadLine().ToUpper();

            if (feedAnswer == "YES")
            {
                Console.WriteLine("What would you like to feed Ruby, peanut butter or dog food?");
                string foodChoice = Console.ReadLine().ToUpper();
                


                switch (foodChoice)
                {
                    case "PEANUT BUTTER":
                        Console.WriteLine("Ruby turns in circles excitely and wags her tail.");
                        hunger = hunger + 15;
                        break;
                    case "DOG FOOD":
                        Console.WriteLine("Ruby looks at you sadly and puts her ears back.  She was expecting\npeanut butter.");
                        hunger = hunger + 10;
                        break;
                }
            }
            if (feedAnswer == "NO")

            {
                Console.WriteLine("Didn't your parents teach you that it's cruel to tease dogs when they're\nhungry?! :(");
                hunger = hunger - 15;

            }



        }

        //Drink Method

        public void Drink()

        {
            Console.WriteLine("Are you sure you would you like to give Ruby water?");
            string drinkAnswer = Console.ReadLine().ToUpper();

            if (drinkAnswer == "YES")
            {
                Console.WriteLine("You give Ruby water.");
                Console.WriteLine("Ruby slurps up the whole bowl...hope she doesn't pee on the carpet later.");
                thirst = thirst + 10;

            }
            else if (drinkAnswer == "NO")

            {
                Console.WriteLine("Ruby looks at you sadly and you sense that she's dehydrated. :(");
                thirst = thirst - 10;
            }

        }

        //Sleep Method

        public void Nap()

        {
            Console.WriteLine("Are you sure you want to put Ruby to bed?");
            string sleepAnswer = Console.ReadLine().ToUpper();

            if (sleepAnswer == "YES")
            {
                Console.WriteLine("You put Ruby to bed.");
                Console.WriteLine("Ruby curls up and is fast asleep :)");
                sleep = sleep + 10;


            }
            else if (sleepAnswer == "NO")

            {
                Console.WriteLine("But she's tired! What kind of person are you? :(");
                sleep = sleep - 10;
            }


        }

        //Tick Method

        public void Tick()
        {
            hunger = hunger - 5;
            thirst = thirst - 5;
            sleep = sleep - 5;

        }

        //Neglect Method

  
        public void Neglect()
        {

            if (hunger < 0 || thirst < 0 || sleep < 0)
            
                {
                    Console.WriteLine("You neglected Ruby! She ran away to someone who cares. Goodbye");

                    Environment.Exit(0);
                }
                
            
        }

        //Stats Method

        public void PrintStats()

        {
            Console.WriteLine("Ruby's levels are as follows:");
            Console.WriteLine("Hunger= " + this.hunger);
            Console.WriteLine("Thirst= " + this.thirst);
            Console.WriteLine("Sleep= " + this.sleep);

        }






    }
}
