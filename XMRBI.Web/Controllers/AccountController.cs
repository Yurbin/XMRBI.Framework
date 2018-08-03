using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XMRBI.Infrastructure;
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

        /// <summary>
        /// 提交登陆信息。
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            if (userName.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return Error("请求失败，缺少必要参数。");
            }
            var userEntity = _userService.GetByUserName(userName);
            if (userEntity == null)
            {
                return Warning("该账户不存在，请重新输入。");
            }
            if (userEntity.InUse != 1)
            {
                return Warning("该账户已被禁用，请联系管理员。");
            }
            //var userLogOnEntity = _userLogOnService.GetByAccount(userEntity.Id);
            string inputPassword = Base64.Base64Code(password);
            if (inputPassword != userEntity.PWD)
            {
                LogHelper.Write(Level.Info, "系统登录", "密码错误", userEntity.UserNo, userEntity.UserName);
                return Warning("密码错误，请重新输入。");
            }
            else
            {
                Operator operatorModel = new Operator();
                operatorModel.UserId = userEntity.UserID.ToString();
                operatorModel.Account = userEntity.UserNo;
                operatorModel.RealName = userEntity.UserName;
                //operatorModel.Avatar = userEntity.Avatar;
                //operatorModel.CompanyId = userEntity.CompanyId;
                //operatorModel.DepartmentId = userEntity.DepartmentId;
                operatorModel.LoginTime = DateTime.Now;
                operatorModel.Token = Guid.NewGuid().ToString().DESEncrypt();
                OperatorProvider.Instance.Current = operatorModel;
                //_userLogOnService.UpdateLogin(userLogOnEntity);
                LogHelper.Write(Level.Info, "系统登录", "登录成功", userEntity.UserNo, userEntity.UserName);
                return Success();
            }
        }
    }
}