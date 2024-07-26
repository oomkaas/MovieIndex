namespace MovieIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie(2002, "City of God", "Cidade de Deus", "Documentary, Thriller, Crime film, Drama", 8.6);

            Console.WriteLine(movie[0]);
            Console.WriteLine(movie[1]);
            Console.WriteLine(movie[2]);
            Console.WriteLine(movie[3]);
            Console.WriteLine(movie[4]);

            Console.WriteLine("\nMovie Title: " + movie["title"]);
            Console.WriteLine("Director:    " + movie["director"]);
            Console.WriteLine("year:        " + movie["year"]);
            Console.WriteLine("Genre:       " + movie["genre"]);
            Console.WriteLine("Rating:      " + movie["rating"] + "/10");
        }
    }
}