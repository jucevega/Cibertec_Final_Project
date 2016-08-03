using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebDeveloper.API.Models;

namespace WebDeveloper.API.Api
{
    public class AccountController : ApiController
    {
        public async Task<IHttpActionResult> Login(LoginViewModel login)
        {
            //if (!ModelState.IsValid)
                return new Task(BadRequest(login));
            //var result = await Microsoft.AspNet.Identity.Owin.SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout: false);
            //switch (result)
            //{
            //    case SignInStatus.Success:
            //        return RedirectToLocal(returnUrl);
            //    case SignInStatus.LockedOut:
            //        return View("Lockout");
            //    case SignInStatus.Failure:
            //    default:
            //        ModelState.AddModelError("", "Invalid login attempt.");
            //        return View(model);
            //}
        }
    }
}
