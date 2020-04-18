using DAO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotFake.Models;
using Service;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NotFake.ViewComponents
{
    public class HeaderButtonGroupsViewComponent : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly INotFakeService service;
        public HeaderButtonGroupsViewComponent(IHttpContextAccessor httpContextAccessor, INotFakeService _notFakeService)
        {
            service = _notFakeService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IViewComponentResult Invoke()
        {
            HeaderViewModel data = new HeaderViewModel()
            {
                currentUser = new HubUser(),
                friendRequests = new List<HubUser>()
            };

            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                string userName = _httpContextAccessor.HttpContext.User.Identity.Name;
                string UserEmail = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                User user = service.User.GetByEmail(UserEmail);
                List<HubUser> friendRequests = service.Friendship.GetFriendships(user, true)
                                .Where(fs =>
                                    fs.Status == FriendShipStatus.Pending
                                    && fs.InvitedUser == user)
                                .ToList()
                                .ConvertAll(fs => new HubUser()
                                {
                                    UserEmail = fs.InvitingUser.Email,
                                    UserName = fs.InvitingUser.Fullname
                                });

                data.currentUser.UserName = userName;
                data.currentUser.UserEmail = UserEmail;
                data.friendRequests = friendRequests;
            }
            return View(data);
        }

    }
}