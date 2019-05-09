using Alive.OA.DAL;
using Alive.OA.Model;

namespace Alive.OA.BLL
{
    public class UserInfoService
    {
        private UserInfoDal _userInfoDal = new UserInfoDal();
        public UserInfo AddUserInfo(UserInfo userInfo)
        {
            return _userInfoDal.AddUserInfo(userInfo);
        }
    }
}
