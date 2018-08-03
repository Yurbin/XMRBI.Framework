using XMRBI.Entity;
using XMRBI.IRepository.System;
using XMRBI.IService.System;

namespace XMRBI.Service.System
{
    public partial class UserService : BaseService<sys_User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public sys_User GetByUserName(string account)
        {
            return _userRepository.GetByAccount(account);
        }
    }
}