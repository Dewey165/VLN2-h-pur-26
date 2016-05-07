﻿using Mooshak26.Models;
using Mooshak26.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooshak26.Services
{
    public class AssignmentsService
    {
        private ApplicationDbContext _db;

        public AssignmentsService()
        {
            _db = new ApplicationDbContext();
        }

        public SelectList GetAllCourseTitles()
        {
            var list = new SelectList(
                _db.courses.ToList(), "id", "title");

            return list;
        }

        public List<AssignmentViewModel> GetAssignmentsInCourse(int courseID)
        {
            //TODO: 
            return null;
        }

        public AssignmentViewModel GetAssignmentByID(int assignmentID)
        {
            //TODO
            var assignment = _db.Assignments.SingleOrDefault(x => x.id == assignmentID);
            if (assignment == null)
            {
                // kasta villu eða null
            }

            var milestones = _db.Milestones
                .Where(x => x.assignmentID == assignmentID)
                .Select(x => new AssignmentViewModel
                {
                    title = x.title
                })
                .ToList();

            var viewModel = new AssignmentViewModel
            {
                title = assignment.title,
                Milestones = milestones
            };

            return viewModel;
        }

    }
}