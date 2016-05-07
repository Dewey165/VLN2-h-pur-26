using Mooshak26.Models;
using Mooshak26.Models.Entities;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Mooshak26.Services
{
    public class CourseService
    {
        private ApplicationDbContext _db;

        public CourseService()
        {
            _db = new ApplicationDbContext();
        }

        public List<Course> GetCourses()
        {
            return _db.courses.ToList();
        }

        public Course CourseDetails(int? id)
        {
            return _db.courses.Find(id);
        }

        public int FindCourseIDByName(string courseName)
        {
            var courseID = _db.courses
                .Where(x => x.title == courseName)
                .Select(i => i.id).Single();
            return courseID;
        }

        public bool CreateCourse(Course course)
        {
            _db.courses.Add(course);
            _db.SaveChanges();
            return true;
        }
        public bool EditCourse(Course course)
        {
            _db.Entry(course).State = EntityState.Modified;
            _db.SaveChanges();
            return true;
        }

        public bool DeleteCourse(Course course)
        {
            _db.courses.Remove(course);
            _db.SaveChanges();
            return true;
        }
        /*
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
        */
    }
}