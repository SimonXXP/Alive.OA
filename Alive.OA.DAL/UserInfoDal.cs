using Alive.OA.Model;

namespace Alive.OA.DAL
{
    public class UserInfoDal
    {
        public UserInfo AddUserInfo(UserInfo userInfo)
        {
            DataModel dbcontext = new DataModel();
            dbcontext.UserInfo.Add(userInfo);
            dbcontext.SaveChanges();
            return userInfo;
        }

    }
}