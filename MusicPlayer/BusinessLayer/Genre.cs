using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Genre
    {
        private List<string> GenreList = new List<string>();

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Genre()
        {
            
        }
        public Genre( string name)
        {
         
            this.name = name;
        }

        public void FillGenres(string name)
        {
            foreach (var s in GenreList)
            {
                GenreList.Add(name);
            }
            
        }

        public string Getgenres()
        {
            
            foreach (string s in GenreList)
            {
                string returnGenre = s;
                
            }

            return GenreList.;
        }
    }
}
