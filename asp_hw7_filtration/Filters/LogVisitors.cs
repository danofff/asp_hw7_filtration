using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_hw7_filtration.Models;
using Antlr.Runtime.Tree;

namespace asp_hw7_filtration.Filters
{
    public class LogVisitors:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var request = filterContext.HttpContext.Request;

            MyVisitor visitor= new MyVisitor()
            {
                Login=(request.IsAuthenticated)?filterContext.HttpContext.User.Identity.Name:"anonymouse",
                Ip=request.ServerVariables["HTTP_X_FORWARDED_FOR"]??request.UserHostAddress,
                Url=request.RawUrl,
                Date=DateTime.Now
            };

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Visitors.Add(visitor);
                db.SaveChanges();
            }

        }
    }
}