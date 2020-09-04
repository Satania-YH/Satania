using System.Web.Mvc;
using System.Web.Routing;

namespace CompetitionSystem.MVC.Filter
{
    /// <summary>
    /// 基础过滤器，判断用户是否登录
    /// </summary>
    public class UserAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //如果Cookies有值而Session没有值,就把Cookies的值给Session
            if (filterContext.HttpContext.Session["userId"] == null &&
                filterContext.HttpContext.Request.Cookies["userId"] != null)
            {
                filterContext.HttpContext.Session["userId"] =
                    filterContext.HttpContext.Request.Cookies["userId"].Value;
                filterContext.HttpContext.Session["userType"] =
                    filterContext.HttpContext.Request.Cookies["userType"].Value;
            }
            //如果Cookies没有值且Session也没有值，跳转到登录界面
            if (filterContext.HttpContext.Session["userId"] == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary() {
                    {"controller", "Home" },
                    {"action", "Login" }
                });
            }
        }
    }
}