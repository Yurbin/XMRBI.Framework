using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XMRBI.Entity;
using XMRBI.Infrastructure;

namespace XMRBI.Web.Controllers
{
    public class BaseController : Controller
    {
        #region 快捷方法
        protected ActionResult Success(string message = "恭喜您，操作成功。", object data = null)
        {
            return Content(new AjaxResult(ResultType.Success, message, data).ToJson());
        }
        protected ActionResult Error(string message = "对不起，操作失败。", object data = null)
        {
            return Content(new AjaxResult(ResultType.Error, message, data).ToJson());
        }
        protected ActionResult Warning(string message, object data = null)
        {
            return Content(new AjaxResult(ResultType.Warning, message, data).ToJson());
        }
        protected ActionResult Info(string message, object data = null)
        {
            return Content(new AjaxResult(ResultType.Info, message, data).ToJson());
        }
        #endregion
    }
}