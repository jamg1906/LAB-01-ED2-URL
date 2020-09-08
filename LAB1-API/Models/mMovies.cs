using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB1_API.Models
{
    public class mMovies
    {

        private string director;
        private double imdbRating;
        private string genre;
        private DateTime releaseDate;
        private int rottenTomatoesRating;
        private string title;

        public string Director { get => director; set => director = value; }
        public double ImdbRating { get => imdbRating; set => imdbRating = value; }
        public string Genre { get => genre; set => genre = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public int RottenTomatoesRating { get => rottenTomatoesRating; set => rottenTomatoesRating = value; }
        public string Title { get => title; set => title = value; }
    }
}
