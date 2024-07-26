using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieIndex
{
    public class Movie
    {
        int year;
        string title, director, genre;
        double rating;

        public Movie(int year, string title, string director, string genre, double rating)
        {
            this.year = year;
            this.title = title;
            this.director = director;
            this.genre = genre;
            this.rating = rating;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.title;
                else if (index == 1)
                    return this.director;
                else if (index == 2)
                    return this.year;
                else if (index == 3)
                    return this.genre;
                else if (index == 4)
                    return this.rating;
                return null;
            }
            set
            {
                if (index == 0)
                    this.title = (string)value;
                else if (index == 1)
                    this.director = (string)value;
                else if (index == 2)
                    this.year = (int)value;
                else if (index == 3)
                    this.genre = (string)value;
                else if (index == 4)
                    this.rating = (double)value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("title"))
                    return this.title;
                else if (attrName.ToLower().Equals("director"))
                    return this.director;
                else if (attrName.ToLower().Equals("year"))
                    return this.year;
                else if (attrName.ToLower().Equals("genre"))
                    return this.genre;
                else if (attrName.ToLower().Equals("rating"))
                    return this.rating;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("title"))
                    this.title = (string)value;
                else if (attrName.ToLower().Equals("director"))
                    this.director = (string)value;
                else if (attrName.ToLower().Equals("year"))
                    this.year = (int)value;
                else if (attrName.ToLower().Equals("genre"))
                    this.genre = (string)value;
                else if (attrName.ToLower().Equals("rating"))
                    this.rating = (double)value;
            }
        }
    }
}
