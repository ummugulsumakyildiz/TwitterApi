namespace TwitterApi.DAO
{
     class BaseDao
    {
        protected TwitterEntities baglanti;
        public BaseDao()
        {
            baglanti = new TwitterEntities();
        }
    }
}
