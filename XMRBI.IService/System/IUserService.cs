using XMRBI.Entity;

namespace XMRBI.IService.System
{
    public partial interface IUserService : IBaseService<sys_User>
    {
        /// <summary>
        /// 根据账号查询用户。
        /// </summary>
        /// <param name="account">账号</param>
        /// <returns></returns>
        sys_User GetByUserName(string account);
    }
}