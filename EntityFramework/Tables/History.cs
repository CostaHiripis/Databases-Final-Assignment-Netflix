using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework
{
    public class History
    {
        [Key, Column(Order = 0)]
        public int HistoryID { get; set; }
        public int FilmID { get; set; }
        public Film Film { get; set; }
        public int TvShowID { get; set; }
        public TvShow TvShow { get; set; }
        public int ProfileID { get; set; }
        public Profile Profile { get; set; }
        public string FilmPauseTime { get; set; }
        public DateTime DateWatched { get; set; }
    }
}
