using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdmanOnlineShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base()
        {

        }

        public enum Gender
        {
            MALE,
            FEMALE
        };
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public Gender UserGender { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}
