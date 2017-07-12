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

            ////Create a list and add 5 animals using the .Add()
            ////Print each animal in the list

            //List<string> animals = new List<string>();
            //animals.Add("Lions");
            //animals.Add("Tigers");
            //animals.Add("Bears");
            //animals.Add("T-Rex");
            //animals.Add("Werewolf");

            //foreach (string animal in animals)
            //{
            //    Console.WriteLine(animal);
            //}

            ////Create the following list:
            ////A bool list {true, false, false true false}
            ////Loop through each value 
            ////if the value is true priint "Better bring an umbrella"
            ////if the value is false print "No rain today"
            //List<bool> weather = new List<bool> { true, false, false, true, false };

            //foreach (bool day in weather)
            //{
            //    if (day == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain Today");
            //    }
            //}

            //List<string> favFoods = new List<string>() { "Steak", "Fish", "Katsudon", "Ice Cream", "Nachos" };
            //if (favFoods.Contains("fish"))
            //{
            //    Console.WriteLine("I like fish too");
            //}


            ////create a list with the follwing numbers 1 23 9 77 922 6 32 63 14 5
            //// use the contains method with the follwoing values 23 77 15
            ////Remove these elements 27 77 32 6
            ////use contains() again on these  values 23 77 15

            //List<int> numbers = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };

            //if (numbers.Contains(23))
            //{
            //    Console.WriteLine("This list contains 23");
            //}
            //if (numbers.Contains(77))
            //{
            //    Console.WriteLine("This list contains 77");
            //}
            //if (numbers.Contains(15))
            //{
            //    Console.WriteLine("This list contains 15");
            //}

            //numbers.Remove(27);
            //numbers.Remove(77);
            //numbers.Remove(32);
            //numbers.Remove(6);


            //if (numbers.Contains(23))
            //{
            //    Console.WriteLine("This list contains 23");
            //}
            //if (numbers.Contains(77))
            //{
            //    Console.WriteLine("This list contains 77");
            //}
            //if (numbers.Contains(15))
            //{
            //    Console.WriteLine("This list contains 15");
            //}


            //create a console application that is a movie ordering service. 
            /* List of movies
             * ask user for movies
             * if the movie is not on the list add the movie and tell user it will arrive in 3-5 days
             * if the user enters quit then quit
             * the user should be able to add as many movies as they want
             */

            List<string> ourMovies = new List<string> { "Anchorman", "Braveheart", "Clue", "Fear and Loathing in Las Vegas", "Super Troopers" };
            List<string> moviesOrdered = new List<string>();

            Console.WriteLine("Welcome to our movie ordering service please enter the movie you wish to order.");
            Console.WriteLine("Enter quit or done when you are finished with your order.");
            string movieCheck = Console.ReadLine();

            do
            {
                if (ourMovies.Contains(movieCheck))
                {
                    Console.WriteLine("Thanks for placing your order {0} is on the way!", movieCheck);
                    moviesOrdered.Add(movieCheck);
                }

                if (ourMovies.Contains(movieCheck) == false)
                {
                    Console.WriteLine("We currently do not have {0} but it is on the way. Please wait 3-5 days to recieve it", movieCheck);
                    moviesOrdered.Add(movieCheck);
                    ourMovies.Add(movieCheck);
                }

                Console.WriteLine("What other movie would you like to add?");
                movieCheck = Console.ReadLine();
            }
            while (movieCheck.ToLower() != "quit" || movieCheck.ToLower() != "done");
            Console.WriteLine("Your movies are on the way! Here is what you should expect.");
            
            foreach (string movie in moviesOrdered)
            {
                Console.WriteLine(movie);
            }



        }
    }
}
