using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mooshak26.Models;
using Mooshak26.Models.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Mooshak26;
using System.Threading.Tasks;
using Mooshak26.Services;

namespace Mooshak26.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationUserManager _userManager;
        private UserService _service = new UserService();
        

        /// <summary>
        /// When creating a new user to AspNetUsers we need this for that..
        /// </summary>
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // GET: AdministratorMainPage
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View(_service.GetUsers());
        }

        // GET: Usersss/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = _service.GetUserDetails(id);

            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Usersss/Create
        [Authorize(Roles ="Admin")]
        public ActionResult Create()
        {
            ViewBag.Roles = _service.GetRoles();
            return View();
        }

        // POST: Usersss/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,userName,email,role")] User user)
        {
            if (ModelState.IsValid)
            {
                if(_service.CreateUser(user))
                {
                    var newUser = new ApplicationUser
                    {
                        UserName = user.userName,
                        Email = user.email
                    };
                    //Create the user in AspNetUsers and the role...
                    var createNewUser = await UserManager.CreateAsync(newUser, "Abc123!");
                    if(createNewUser.Succeeded)
                    {
                        UserManager.AddToRole(newUser.Id, user.role);
                    }
                   
                }
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: Usersss/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = _service.GetUserDetails(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.Name = _service.GetRoles();
            return View(user);
        }

        // POST: Usersss/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,userName,email,role")] User user)
        {
            if (ModelState.IsValid)
            {
                /*
                var oldUser = _service.GetUserDetails(user.id);              
                //Edit the user in AspNetUsers and the role...

                //Get the oldUser in AspNetUsers and update him...

                var updatedUser = await UserManager.FindByNameAsync(oldUser.userName);
                //Change the user in AspNetUsers table...
                

                if(!await UserManager.IsInRoleAsync(updatedUser.Id, user.role))
                {
                    UserManager.AddToRole(updatedUser.Id, user.role);
                }
                updatedUser.UserName = user.userName;
                updatedUser.Email = user.email;
                await UserManager.UpdateAsync(updatedUser);
                */
                _service.EditUser(user);
                return RedirectToAction("Index");
           }
            
            return View(user);
        }

        // GET: Usersss/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = _service.GetUserDetails(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Usersss/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if(_service.DeleteUser(id))
            {
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
