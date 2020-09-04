using CompetitionSystem.BLL.UsersManager;
using CompetitionSystem.IBLL.IUsersManager;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CompetitionSystem.MVC.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 主页
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> Index()
        {
            //如果Cookies有值但Session为空，则把Cookies的值传给Session
            if (HttpContext.Session["userId"] == null && HttpContext.Request.Cookies["userId"] != null)
            {              
                Session["userId"] =
                    HttpContext.Request.Cookies["userId"].Value;
                Session["userType"] = 
                    HttpContext.Request.Cookies["userType"].Value;
            }
            //如果Session有值，则把用户数据存入ViewBag里
            if (HttpContext.Session["userId"] != null)
            {
                var userId = Guid.Parse(Session["userId"].ToString());
                IUserManager manager = new UserManager();
                var user = await manager.GetUserInf(userId);    
                ViewData["ImagePath"] = user.ImagePath;
                ViewData["NickName"] = user.NickName;
            }
            return View();
        }
    }
}