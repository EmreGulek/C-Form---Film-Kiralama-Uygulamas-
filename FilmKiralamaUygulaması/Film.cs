using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace FilmKiralamaUygulaması
{
    internal class Film
    {

        public string ID { get; set; }
        public string AD { get; set; }
        public string UCRET { get; set; }

        public static List<Film> FilmleriListele()
        {
            List<Film> filmler = new List<Film>
         {
             new Film { ID = "01", AD = "The Dark Knight", UCRET = "100" },
             new Film { ID = "02", AD = "Forrest Gump", UCRET = "120" },
             new Film { ID = "03", AD = "Inception", UCRET = "200" },
             new Film { ID = "04", AD = "Pulp Fiction", UCRET = "250" },
             new Film { ID = "05", AD = "The Godfather", UCRET = "160" },
             new Film { ID = "06", AD = "Fight Club", UCRET = "230" },
             new Film { ID = "07", AD = "The Matrix", UCRET = "180" },
             new Film { ID = "08", AD = "Titanic", UCRET = "70" },
             new Film { ID = "09", AD = "The Lord of the Rings: The Fellowship of the Ring", UCRET = "330" }
         };

            return filmler;
        }
    }
}

    