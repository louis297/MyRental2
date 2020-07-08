using System;
using Microsoft.AspNetCore.Identity;

namespace MyRental2.Models.UserModel
{
    public class MyRentalUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public MyRentalUser()
        {
        }
    }
}
