using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShrp_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Convert
            string myIntString = "1234";

            int myInt = Convert.ToInt32(myIntString);

            Console.WriteLine(myInt);

            //TryParse
            string parseValue = "1234";
            int parsedInt = 0;

            if (int.TryParse(parseValue, out parsedInt))
            {
                // Success!
            }
            else
            {
                // Failure!
            }

            Console.WriteLine(parsedInt);

            //StringBuilder 
            StringBuilder mySB = new StringBuilder("First");
            mySB.Append("Second Part");
            mySB.Append("Third Part");

            string concatonatedString = mySB.ToString();

            //For Loops 
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            //Foreach
            string[] animals = { "Cat", "Dog", "Bird" };

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            QueryCollection();
        }

        public static void QueryCollection() 
        {
            Hashtable films = new Hashtable();
            films.Add("Dark Shadows", 10.5M);
            films.Add("We Were Soilders", 8.75M);
            films.Add("50 First Dates", 10.25M);
            films.Add("Shawshank Redemption", 9M);
            films.Add("The Dictator", 5.25M);
            films.Add("Captain America", 10.25M);

            var selectedFilms =
                from string film in films.Keys
                where (decimal)films[film] < 10.00M
                orderby films[film] ascending 
                select String.Format("{0, -25}${1}",
                film, films[film]);

            foreach (string selectedFilm in selectedFilms)
                Console.WriteLine(selectedFilm);

        }
    }
}
