using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework
{
    public class User
    {
        [Key, Column(Order = 0)]
        public int UserID { get; set; }
        public string UserEmailAddress { get; set; }
        public string UserPassword { get; set; }
        public bool UserActivated { get; set; }
        public string UserName { get; set; }
        public bool UserBlocked { get; set; }
        public string UserSubscription { get; set; }
        public decimal UserCostPerMonth { get; set; }
        public bool UserDiscount { get; set; }
        public DateTime UserSignUpDate { get; set; }
    }
}
