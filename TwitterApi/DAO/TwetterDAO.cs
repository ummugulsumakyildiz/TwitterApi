using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterApi.DAO
{
    class TwetterDAO: BaseDao
    {
       public bool Save(TweetPost tweet)
        {
            baglanti.TweetPost.Add(tweet);
            int result = baglanti.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
