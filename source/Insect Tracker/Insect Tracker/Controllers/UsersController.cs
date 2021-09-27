using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Insect_Tracker.Models;
using Insect_Tracker.Data;

namespace Insect_Tracker.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
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

        public async Task<IActionResult> Manage(string userId)
        {
            ViewBag.userId = userId;
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }

            ViewBag.UserName = user.UserName;

            var model = new List<ManageRolesViewModel>();

            foreach (var role in _roleManager.Roles)
            {
                var userRolesViewModel = new ManageRolesViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.Selected = true;
                }
                else
                {
                    userRolesViewModel.Selected = false;
                }

                model.Add(userRolesViewModel);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Manage(List<ManageRolesViewModel> model, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return View();
            }

            var roles = await _userManager.GetRolesAsync(user);

            var result = await _userManager.RemoveFromRolesAsync(user, roles);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return View(model);
            }

            result = await _userManager.AddToRolesAsync(user, model.Where(x => x.Selected).Select(y => y.RoleName));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(model);
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Roles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        private async Task<List<string>> GetUserRoles(ApplicationUser user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }

        [HttpPost]
        public async Task<IActionResult> Create(string roleName)
        {
            if (roleName != null)
                await _roleManager.CreateAsync(new IdentityRole(roleName.Trim()));

            return RedirectToAction("Index");
        }

        // GET: /Users/Details/5
        public async Task<IActionResult> Details (string username)
        {
            if (username == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                                     .Where(u => u.UserName == username)
                                     .FirstOrDefaultAsync();

            if (user == null)
            {
                return NotFound();
            }

            var userView = new UserViewModel();

            userView.UserName = user.UserName;
            userView.UserId = user.Id;
            userView.FirstName = user.FirstName;
            userView.LastName = user.LastName;
            userView.Email = user.Email;
            userView.ProfilePicture = user.ProfilePicture;
            userView.Roles = await GetUserRoles(user);
            userView.PhoneNumber = user.PhoneNumber;
            userView.DateSigned = user.DateSigned;

            return View(userView);
        }
    }
}
