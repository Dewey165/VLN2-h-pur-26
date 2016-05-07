using Mooshak26.Models;
using Mooshak26.Models.Entities;
using Mooshak26.Models.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooshak26.Services
{
    public class LinkService
    {
        private ApplicationDbContext _db;

        public LinkService()
        {
            _db = new ApplicationDbContext();
        }
        public List<Link> GetLinks()
        {
            return _db.Links.ToList();
        }
        public Link GetLinkDetails(int? id)
        {
            return _db.Links.Find(id);
        }
              
        public SelectList GetAllCourseTitles()
        {
            //List <Link> courses = GetLinks();
            var list = new SelectList(
                _db.courses.ToList(),"id", "title");

                return list;
        }

        public SelectList GetAllUsernames()
        {
            var list = new SelectList(
                _db.MyUsers
                .Where( x => !x.role.Contains("Admin"))
                .ToList(), "id", "userName");
            return list;
        }
    }
}