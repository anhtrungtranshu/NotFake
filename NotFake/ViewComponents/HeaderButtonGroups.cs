using DAO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NotFake.ViewComponents
{
    public class HeaderButtonGroupsViewComponent : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly INotFakeService service;
        public string userName { get; set; }
        public string UserEmail { get; set; }
        public HeaderButtonGroupsViewComponent(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            }
        }

        public IViewComponentResult Invoke()
        {
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                UserEmail = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            }

            ViewBag.UserName = userName;
            ViewBag.UserEmail = UserEmail;
            return View();
        }

    }
}