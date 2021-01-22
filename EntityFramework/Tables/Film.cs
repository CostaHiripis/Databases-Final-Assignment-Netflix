using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework
{
    public class Film
    {
        [Key, Column(Order = 0)]
        public int FilmID { get; set; }
        public string FilmName { get; set; }
        public string FilmDirector { get; set; }
        public int AmountOfViews { get; set; }
        public string FilmQuality { get; set; }

    }
}
