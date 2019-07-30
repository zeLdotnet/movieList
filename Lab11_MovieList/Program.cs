using System;
using System.Collections.Generic;

namespace Lab11_MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie newMovie = new Movie("The Other Guys", "comedy");
            List<Movie> movieList = new List<Movie>
            {
                new Movie("Final Destination","thiller"),
                new Movie("Get Out","thriller"),
                new Movie("Hard Candy","thriller"),
                new Movie("Toy Story","animated"),
                new Movie("Spirited Away","animated"),
                new Movie("Emperor's New Groove","animated"),
                new Movie("The Matrix","scifi"),
                new Movie("Inception","scifi"),
                new Movie("How High","comedy"),
                new Movie("Superbad","comedy"),
            };

            Console.WriteLine("Hey! Choose one of the following categories to see some films!");
            Console.WriteLine("Animated");
            Console.WriteLine("Comedy");
            Console.WriteLine("Scifi");
            Console.WriteLine("Thriller\n");



            string userChoice = Console.ReadLine().ToLower();
            bool go = true;
            Console.WriteLine('\n');

            while (go)
            {
                if (userChoice == "animated")
                {
                    Console.WriteLine($"{userChoice} films: ");
                    foreach (Movie movie in movieList)
                    {
                        if (userChoice == movie.Category)
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                    Console.WriteLine("Choose another category? Enter [y]es to continue or any key to exit.");
                    string yesNo = Console.ReadLine().ToLower();

                    if (yesNo == "yes" || yesNo == "y")
                    {
                        continue;
                    }
                    else
                    {
                        go = false;
                    }
                }
                else if (userChoice == "comedy")
                {
                    Console.WriteLine($"{userChoice} films: ");
                    foreach (Movie movie in movieList)
                    {
                        if (userChoice == movie.Category)
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                }
                else if (userChoice == "scifi")
                {
                    Console.WriteLine($"{userChoice} films: ");
                    foreach (Movie movie in movieList)
                    {
                        if (userChoice == movie.Category)
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                }
                else if (userChoice == "thriller")
                {
                    Console.WriteLine($"{userChoice} films: ");
                    foreach (Movie movie in movieList)
                    {
                        if (userChoice == movie.Category)
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Input misread. Please a movie category.");
                    userChoice = Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
