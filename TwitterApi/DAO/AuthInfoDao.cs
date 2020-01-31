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
    }
}
