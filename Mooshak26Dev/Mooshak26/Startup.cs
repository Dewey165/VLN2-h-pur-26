using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Mooshak26.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mooshak26.Startup))]
namespace Mooshak26
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesAndAdmin();
        }
        private void createRolesAndAdmin()
        {
            ApplicationDbContext _db = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_db));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_db));

            // In startup we want to have 3 roles "Admin, Teacher and Student" and creating a default Admin
            // Tutorial here http://social.technet.microsoft.com/wiki/contents/articles/33229.asp-net-mvc-5-security-and-creating-user-role.aspx 

            if (!roleManager.RoleExists("Admin"))
            {
                // first we create Admin rool  
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                 
                var user = new ApplicationUser();
                user.UserName = "Admin";
                user.Email = "admin@admin.com";

                string userPassword = "Abc123!";

                var createUser = UserManager.Create(user, userPassword);
                if (createUser.Succeeded)
                {
                    var result = UserManager.AddToRole(user.Id, "Admin");

                }
            }
            // creating Creating Manager role   
            if (!roleManager.RoleExists("Teacher"))  
            {  
                var role = new IdentityRole();
                 role.Name = "Teacher";  
                roleManager.Create(role);  
    
            }  
    
            // creating Creating Employee role   
            if (!roleManager.RoleExists("Student"))  
            {  
                var role = new IdentityRole();
                role.Name = "Student";  
                roleManager.Create(role);  
            }  
        }
    }
}
