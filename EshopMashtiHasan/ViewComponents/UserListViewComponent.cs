using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Security.BussinessServiceContract.Services;
using Security.Domain.DTO.Role;
using Security.Domain.DTO.User;

namespace EshopMashtiHasan.ViewComponents
{
    [ViewComponent(Name = "UserList")]
    public class UserListViewComponent : ViewComponent
    {
        private readonly IUserBuss buss;
        public UserListViewComponent(IUserBuss buss)
        {
            this.buss = buss;
        }

        public IViewComponentResult Invoke(UserSearchModel sm)
        {
            int rc = 0;
            var result = buss.Search(sm,out rc);
            return View(result);
        }
    }
}
