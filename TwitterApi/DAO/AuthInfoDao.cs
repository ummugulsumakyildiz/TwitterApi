using System.Linq;

namespace TwitterApi.DAO
{
    class AuthInfoDao:BaseDao
    {
        
        public bool Save(AuthInfo info)
        {
            baglanti.AuthInfo.Add(info);
            int result = baglanti.SaveChanges();
            if (result>0)
            {
                return true;
            }

            return false;
        }

        public AuthInfo LastRecord() 
        {
           var result= baglanti.AuthInfo
                       .OrderByDescending(a=> a.id) 
                       .FirstOrDefault();
            return result;
        }
    }
}
