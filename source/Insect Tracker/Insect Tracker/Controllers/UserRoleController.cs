using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Insect_Tracker.Models;

namespace Insect_Tracker.Controllers
{
    public class UserRoleController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRoleController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var userRoleViewModel = new List<UserViewModel>();

            foreach(ApplicationUser user in users)
            {
                var thisViewModel = new UserViewModel();
                thisViewModel.UserId = user.Id;
                thisViewModel.Email = user.Email;
                thisViewModel.FirstName = user.FirstName;
                thisViewModel.LastName = user.LastName;
                thisViewModel.Roles = await GetUserRoles(user);
                userRoleViewModel.Add(thisViewModel);
            }

            return View(userRoleViewModel);
        }

        public async Task<IActionResult> ViewRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        private async Task<List<string>> GetUserRoles(ApplicationUser user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(string roleName)
        {
            if (roleName != null)
                await _roleManager.CreateAsync(new IdentityRole(roleName.Trim()));

            return RedirectToAction("ViewRoles");
        }
    }
}
