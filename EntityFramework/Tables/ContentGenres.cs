using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework
{
    public class ContentGenre
    {
        [Key, Column(Order = 0)]
        public int ContentGenreID { get; set; }
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
        public int FilmID { get; set; }
        public Film Film { get; set; }
        public int TvShowID { get; set; }
        public TvShow TvShow { get; set; }
    }
}
