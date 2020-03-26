using DAO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace NotFake.ViewComponents
{
    public class HeaderButtonGroupsViewComponent : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public string userName { get; set; }
        public HeaderButtonGroupsViewComponent(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            if(_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            }
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.UserName = userName;
            return View();
        }

    }
}