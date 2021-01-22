using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework
{
    public class Profile
    {
        [Key, Column(Order = 0)]
        public int ProfileID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string ProfileName { get; set; }
        public string ProfilePhotoPath { get; set; }
        public int ProfileAge { get; set; }
        public string ProfileLanguage { get; set; }
    }
}
