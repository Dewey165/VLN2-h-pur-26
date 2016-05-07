using Mooshak26.Models;
using Mooshak26.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Mooshak26.Services
{
    public class UserService
    {
        private ApplicationDbContext _db;

        public UserService()
        {
            _db = new ApplicationDbContext();
        }
        //Get all users
        public List<User> GetUsers()
        {
            return _db.MyUsers.ToList();
        }

        public User GetUserDetails(int? id)
        {
            return _db.MyUsers.Find(id);
        }
        public string GetRole(int id)
        {
            var userRole = _db.MyUsers.SingleOrDefault
                (x => x.id == id).role;
            return userRole;
        }

        public int FindUserIDByUsername(string username)
        {
            var userID = _db.MyUsers.SingleOrDefault
                (x => x.userName == username).id;
            return userID;
        }

        //Get the roles to create Teacher or Student.
        public SelectList GetRoles()
        {
            var list = new SelectList(
                _db.Roles.Where(
                    x => !x.Name.Contains("Admin"))
                    .ToList(), "Name", "Name");
            return list;
        }

        public Boolean CreateUser(User user)
        {
            _db.MyUsers.Add(user);
            _db.SaveChanges();
            return true;
        }
        public Boolean EditUser(User user)
        {
            _db.Entry(user).State = EntityState.Modified;
            _db.SaveChanges();
            return true;
        }

        public Boolean DeleteUser(int? id)
        {
            User user = GetUserDetails(id);
            _db.MyUsers.Remove(user);
            _db.SaveChanges();
            return true;
        }
    }
}