using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class Genre
    {
        private static List<string> GenreList = new List<string>();

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
                DataLayer.Genre.InsertGenre(name);
                string ListItem = name;
                GenreList.Add(ListItem);            
        }

        public List<string> Getgenres()
        {
            string s1 = "";
            foreach (var item in DataLayer.Genre.GetGenres())
            {
                s1 += item;
                
            }

            return GenreList;
        }
    }
}
