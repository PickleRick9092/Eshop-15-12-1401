using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Security.BussinessServiceContract.Services;
using Security.Domain.DTO.Role;
using Security.Domain.DTO.User;

namespace EshopMashtiHasan.ViewComponents
{
    [ViewComponent(Name ="UserRegister")]
    public class UserRegisterViewComponent:ViewComponent
    {
        private readonly IUserBuss buss;
        public UserRegisterViewComponent(IUserBuss buss)
        {
            this.buss = buss;
        }

        public void InflateDrpChoiceRole()
        {
            var roles = buss.RoleDrps();
            roles.Insert(0, new RoleDrp { RoleID = -1, RoleName = "..Role.." });
            SelectList drpRole = new SelectList(roles, "RoleID", "RoleName");
            ViewBag.drpRole = drpRole;
        }

        public IViewComponentResult Invoke()
        {
            InflateDrpChoiceRole();
            return View();
        }
    }
}
