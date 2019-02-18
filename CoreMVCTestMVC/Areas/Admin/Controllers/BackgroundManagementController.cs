using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreMVCTestDB;
using CoreMVCTestDB.Models.PublicModel;
using CoreMVCTestMVC.Areas.Admin.Models;
using PassWord_Help;
using Microsoft.Extensions.Options;
using CoreMVCTestMVC.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace CoreMVCTestMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BackgroundManagementController : Controller
    {
        private readonly CoreMVCTestContext _context;
      
        public BackgroundManagementController(CoreMVCTestContext context)
        {
            _context = context;
           
        }

  
        // GET: Admin/BackgroundManagement
        public async Task<IActionResult> Index()
        {
            return View();
        }
        //public IActionResult OnGet()
        //{
        //    //登录授权直接跳转index界面
        //    if (HttpContext.User.Identity.IsAuthenticated)
        //    {
        //        return RedirectToPage("Index", "BackgroundManagement");
        //    }
        //    return RedirectToAction("Login", "BackgroundManagement");
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Test([Bind(include:"UserName,AdminPassWord")] AdminLogin login)
        {
            if (ModelState.IsValid)
            {
                var password = PassWordHelp.MD5Encrypt32(login.AdminPassWord);
                var y = _context.Users.Where(x => x.UserName == login.UserName && x.PasswordHash == password).FirstOrDefault();
                if (y != null)
                {
                    
                }
                #region 登录授权
                //登录授权
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, login.UserName));
                var indentity = new ClaimsIdentity(claims, "denglu");
                var principal = new ClaimsPrincipal(indentity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                if (principal.Identity.IsAuthenticated)
                {

                }
                #endregion
                return RedirectToAction(nameof(Index));
            }
            return View(login);
        }
        #region 默认生成
        // GET: Admin/BackgroundManagement/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLogins = await _context.UserLogins
                .FirstOrDefaultAsync(m => m.ProviderKey == id);
            if (userLogins == null)
            {
                return NotFound();
            }

            return View(userLogins);
        }

        // GET: Admin/BackgroundManagement/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BackgroundManagement/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoginProvider,ProviderKey,ProviderDisplayName,UserId")] UserLogins userLogins)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userLogins);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userLogins);
        }

        // GET: Admin/BackgroundManagement/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLogins = await _context.UserLogins.FindAsync(id);
            if (userLogins == null)
            {
                return NotFound();
            }
            return View(userLogins);
        }

        // POST: Admin/BackgroundManagement/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LoginProvider,ProviderKey,ProviderDisplayName,UserId")] UserLogins userLogins)
        {
            if (id != userLogins.ProviderKey)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userLogins);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserLoginsExists(userLogins.ProviderKey))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userLogins);
        }

        // GET: Admin/BackgroundManagement/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLogins = await _context.UserLogins
                .FirstOrDefaultAsync(m => m.ProviderKey == id);
            if (userLogins == null)
            {
                return NotFound();
            }

            return View(userLogins);
        }

        // POST: Admin/BackgroundManagement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var userLogins = await _context.UserLogins.FindAsync(id);
            _context.UserLogins.Remove(userLogins);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
        private bool UserLoginsExists(string id)
        {
            return _context.UserLogins.Any(e => e.ProviderKey == id);
        }
    }
}
