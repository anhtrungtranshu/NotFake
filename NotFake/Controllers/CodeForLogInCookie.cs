using DAO.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NotFake.Controllers
{
    public class CodeForLogInCookie
    {
        ////In LogIn HttpPostMethod
        //// Use NotFakeService to get user
        //User user = new User();

        //ClaimsIdentity visitor = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
        //visitor.AddClaim(new Claim(ClaimTypes.Name, user.FullName));
        //visitor.AddClaim(new Claim(ClaimTypes.Role, user.UserRoles));
        

        //var authProperties = new AuthenticationProperties
        //{
        //    //AllowRefresh = <bool>,
        //    // Refreshing the authentication session should be allowed.

        //    //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
        //    // The time at which the authentication ticket expires. A 
        //    // value set here overrides the ExpireTimeSpan option of 
        //    // CookieAuthenticationOptions set with AddCookie.

        //    //IsPersistent = true,
        //    // Whether the authentication session is persisted across 
        //    // multiple requests. When used with cookies, controls
        //    // whether the cookie's lifetime is absolute (matching the
        //    // lifetime of the authentication ticket) or session-based.

        //    //IssuedUtc = <DateTimeOffset>,
        //    // The time at which the authentication ticket was issued.

        //    //RedirectUri = <string>
        //    // The full path or absolute URI to be used as an http 
        //    // redirect response value.
        //};
        //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), 
        //authProperties);
    }
}
