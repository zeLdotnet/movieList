using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_MovieList
{
    public class Movie
    {
        #region Fields
        /*private string title;
        private string category;
        private List<Movie> movies;*/
        #endregion

        #region Properties
        public string Title { get; set; }
        public string Category { get; set; }
        public List<Movie> Movies { get; set; }
        #endregion

        #region Constructors
        public Movie()
        {
            this.Category = "scifi";
        }
        public Movie(string title, string category)
        {
            this.Title = title;
            this.Category = category;
        }
        #endregion
    }
}
