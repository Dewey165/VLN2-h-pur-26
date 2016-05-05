using Microsoft.AspNet.Identity;
using Mooshak26;
using Mooshak26.Models;
using Mooshak26.Models.Entities;
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

        public List<User> GetUsers()
        {
            return _db.MyUsers.ToList();
        }

        public Boolean CreateUser(User user)
        {
            _db.MyUsers.Add(user);
            _db.SaveChanges();
            return true;
        }
    }
}