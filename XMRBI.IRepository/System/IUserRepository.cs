using XMRBI.Entity;

namespace XMRBI.IRepository.System
{
    public partial interface IUserRepository : IBaseRepository<sys_User>
    {
        /// <summary>
        /// 根据账号获取用户。
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        sys_User GetByAccount(string account);
    }
}