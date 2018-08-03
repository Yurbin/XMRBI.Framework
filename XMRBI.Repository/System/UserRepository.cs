using XMRBI.Entity;
using XMRBI.IRepository.System;

namespace XMRBI.Repository.System
{
    public partial class UserRepository : BaseRepository<sys_User>, IUserRepository
    {
        public sys_User GetByAccount(string account)
        {
            return base.Db.FirstOrDefault<sys_User>("where UserNo=@0", account);
        }
    }
}