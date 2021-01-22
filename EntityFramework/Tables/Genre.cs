using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework
{
    public class Genre
    {
        [Key, Column(Order = 0)]
        public int GenreID { get; set; }
        public string GenreName { get; set; }
    }
}
