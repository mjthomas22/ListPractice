using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> favNumbers = new List<int>();
            //favNumbers.Add(7);
            //favNumbers.Add(25);
            //favNumbers.Add(30);

            //foreach (int numbers in favNumbers)
            //{
            //    Console.WriteLine(numbers);
            //}
            //Console.WriteLine(favNumbers.Count);

            //List<string> books = new List<string> { "Cat in the hat", "Toad and frog", "Green eggs and ham" };
            //Console.WriteLine(books[0]);
            //books.Insert(0, "Horton hears a Who");
            //Console.WriteLine(books[0]);

            //Create a list and add 5 animals using the .Add()
            //Print each animal in the list

            List<string> animals = new List<string>();
            animals.Add("Lions");
            animals.Add("Tigers");
            animals.Add("Bears");
            animals.Add("T-Rex");
            animals.Add("Werewolf");

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            //Create the following list:
            //A bool list {true, false, false true false}
            //Loop through each value 
            //if the value is true priint "Better bring an umbrella"
            //if the value is false print "No rain today"
            List<bool> weather = new List<bool> { true, false, false, true, false };

            foreach (bool day in weather)
            {
                if (day == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }
                else
                {
                    Console.WriteLine("No rain Today");
                }
            }

            List<string> favFoods = new List<string>() { "Steak", "Fish", "Katsudon", "Ice Cream", "Nachos" };
            


        }
    }
}
