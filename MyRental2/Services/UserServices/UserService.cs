using System;
using Microsoft.EntityFrameworkCore;

namespace MyRental2.Services.UserServices
{
    public class UserService: IUserService
    {
        private DbContext _context;

        public UserService(DbContext context)
        {
            _context = context;
        }
    }
}
