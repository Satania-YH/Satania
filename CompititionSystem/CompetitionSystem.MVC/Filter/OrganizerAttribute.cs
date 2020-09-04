using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CompetitionSystem.MVC.Filter
{
    /// <summary>
    /// 竞赛组织用户过滤器，判断用户是否登录，且登录为竞赛组织
    /// </summary>
    public class OrganizerAttribute : AuthorizeAttribute
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
            //如果Cookies不符合学生用户且Session也不符合竞赛组织用户，跳转到登录界面
            if ("竞赛组织" != filterContext.HttpContext.Session["userType"].ToString() || filterContext.HttpContext.Session["userType"] == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary() {
                    {"controller", "Home" },
                    {"action", "Login" }
                });
            }
        }
    }
}