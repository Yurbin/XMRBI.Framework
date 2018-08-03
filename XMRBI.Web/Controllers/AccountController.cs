using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XMRBI.IService.System;

namespace XMRBI.Web.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            this._userService = userService;
        }

        /// <summary>
        /// 登陆页面视图。
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}