using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    /// <summary>
    /// een genre
    /// </summary>
    class Genre
    {
        private int genreID;

        public int GenreID
        {
            get { return genreID; }
            set { genreID = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
