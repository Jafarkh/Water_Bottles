using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {

            measureOneAndFourLiter_1();

            measureOneAndFourLiter_2();

            Console.ReadLine();


        }


        public static void measureOneAndFourLiter_1()
        {
            int Threelitersbottle = 0;
            int Fivelitersbottle = 0;

            Console.WriteLine("1: Start by filling the 3L bottle with water then filling the 5L bottle with 3L bottle contents.");

            Threelitersbottle = 3;
            while (Threelitersbottle > 0)
            {
                Fivelitersbottle++;
                Threelitersbottle--;
            }

            Console.WriteLine("we have now {0} liters water in 5L bottle and {1} liter water in 3L bottle", Fivelitersbottle, Threelitersbottle);
            Console.WriteLine("Do the same until the 5L bottle is full.");
            Threelitersbottle = 3;
            while (Fivelitersbottle < 5)
            {
                Fivelitersbottle++;
                Threelitersbottle--;
            }

            Console.WriteLine("Now we have {0} liter of water left in the 3L bottle. ", Threelitersbottle);

            Console.WriteLine("To measure 4 liters of water fill the 5L bottle with the contents of the 3L bottle which is 1 liter." +
                "\n Fill the 3L Bottle with water again and pour into the 5L Bottle");
            Fivelitersbottle = Threelitersbottle;
            Threelitersbottle = 3;
            while (Threelitersbottle > 0)
            {
                Fivelitersbottle++;
                Threelitersbottle--;
            }

            Console.WriteLine("we have now {0} liters water in 5L bottle", Fivelitersbottle);
        }



        public static void measureOneAndFourLiter_2()
        {
            int Threelitersbottle = 3;
            int Fivelitersbottle = 5;
            int OneLiter = 0;
            int fourliter = 0;

            Console.WriteLine("2: Start by filling the 3L bottle with water then filling the 5L bottle with 3L bottle contents. " +
                "\n Do the same until the 5L bottle is full. Now we have 1 liter of water left in the 3L bottle. " +
                "\n To measure 4 liters of water fill the 5L bottle with the contents of the 3L bottle which is 1 liter." +
                "\n Fill the 3L Bottle with water again and pour into the 5L Bottle." +
                "\n Now we have 4 liters in the 5L bottle");

            OneLiter = (Threelitersbottle - Fivelitersbottle) + Threelitersbottle;
            fourliter = OneLiter + Threelitersbottle;
            Console.WriteLine("Oneliter {0}. fourliter {1}", OneLiter, fourliter);

        }



    }
}
