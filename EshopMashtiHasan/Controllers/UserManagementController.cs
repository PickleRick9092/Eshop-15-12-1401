using Microsoft.AspNetCore.Mvc;
using Security.BussinessServiceContract.Services;
using Security.Domain.DTO.User;

namespace EshopMashtiHasan.Controllers
{
    public class UserManagementController : Controller
    {
        private readonly IUserBuss buss;
        public UserManagementController(IUserBuss buss)
        {
            this.buss = buss;
        }

        public IActionResult Index(UserSearchModel sm)
        {
            return View(sm);
        }
        public IActionResult Add()
        {
            return ViewComponent("UserRegister");
        }
        [HttpPost]
        public JsonResult Add(UserAddModel user)
        {
            var op = buss.RegisterUser(user);
            return Json(op);
        }
        public JsonResult Delete(int id)
        {
            var op = buss.RemoveUser(id);
            return Json(op);   
        }
        public IActionResult Userlist(UserSearchModel sm)
        {
            return ViewComponent("UserList", sm);
        }

        public IActionResult SearchUser(UserSearchModel sm)
        {
            return ViewComponent("UserSearchBox", sm);
        }
      
    }
}
