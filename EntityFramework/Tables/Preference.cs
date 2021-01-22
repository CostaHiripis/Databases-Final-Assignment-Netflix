using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework
{
    public class Preference
    {
        [Key, Column(Order = 0)]
        public int PreferenceID { get; set; }
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
        public int ProfileID { get; set; }
        public Profile Profile { get; set; }
        public int Age { get; set; }
        public bool Violence { get; set; }
        public bool Sex { get; set; }
        public bool Discrimination { get; set; }
        public bool DrugOrAlcholAbuse { get; set; }
        public bool CourseLanguage { get; set; }
    }
}
