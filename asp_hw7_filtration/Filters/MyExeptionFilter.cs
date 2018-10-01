using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;


namespace asp_hw7_filtration.Filters
{
    public class MyExeptionFilter:FilterAttribute,IExceptionFilter
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public void OnException(ExceptionContext filterContext)
        {
            logger.Info(DateTime.Now+"|"+filterContext.Controller+"|"+filterContext.Exception.Message);
            filterContext.ExceptionHandled = true;
            filterContext.Result=new RedirectResult("/Error/Error");
        }
    }
}