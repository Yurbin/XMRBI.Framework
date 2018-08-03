using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Elight.Web.Filters;

namespace XMRBI.Web.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 后台首页视图。
        /// </summary>
        /// <returns></returns>
        [HttpGet, LoginChecked]
        public ActionResult Index()
        {
            return View();
        }
    }
}