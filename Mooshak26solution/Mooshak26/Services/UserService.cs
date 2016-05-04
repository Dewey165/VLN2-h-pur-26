using Mooshak26.Models;
using Mooshak26.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak26.Services
{
    public class UserService
    {
        private ApplicationDbContext _db;

        public UserService()
        {
            _db = new ApplicationDbContext();
        }
        public UserViewModel CreateUser(UserViewModel newUser)
        {
            return null;
        }
    }
}