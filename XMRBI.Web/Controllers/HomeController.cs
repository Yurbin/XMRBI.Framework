using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XMRBI.Entity;
using XMRBI.Infrastructure;
using XMRBI.Web.Filters;

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

        /// <summary>
        /// 后台首页视图。
        /// </summary>
        /// <returns></returns>
        [HttpGet, LoginChecked]
        public ActionResult About()
        {
            return View();
        }

        /// <summary>
        /// 获取左侧菜单。
        /// </summary>
        /// <returns></returns>
        [HttpGet, LoginChecked]
        public ActionResult GetTopMenu()
        {

            return null;
        }

        /// <summary>
        /// 获取左侧菜单。
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetLeftMenu()
        {
            return null;
            //string userId = OperatorProvider.Instance.Current.UserId;

            //List<LayNavbar> listNavbar = new List<LayNavbar>();
            //var listModules = _permissionService.GetList(userId);
            //foreach (var item in listModules.Where(c => c.Type == ModuleType.Menu && c.Layer == 0).ToList())
            //{
            //    LayNavbar navbarEntity = new LayNavbar();
            //    var listChildNav = listModules.Where(c => c.Type == ModuleType.Menu && c.Layer == 1 && c.ParentId == item.Id)
            //        .Select(c => new LayChildNavbar() { href = c.Url, icon = c.Icon, title = c.Name }).ToList();
            //    navbarEntity.icon = item.Icon;
            //    navbarEntity.spread = false;
            //    navbarEntity.title = item.Name;
            //    navbarEntity.children = listChildNav;
            //    listNavbar.Add(navbarEntity);
            //}
            //return Content(listNavbar.ToJson());
        }
    }
}