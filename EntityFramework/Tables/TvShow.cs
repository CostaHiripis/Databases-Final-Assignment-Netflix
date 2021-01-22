using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework
{
    public class TvShow
    {
        [Key, Column(Order = 0)]
        public int TvShowID { get; set; }
        public string TvShowName { get; set; }
        public string tvShowDirector { get; set; }
        public int AmountOfViews { get; set; }
        public string TvShowQuality { get; set; }
    }
}
