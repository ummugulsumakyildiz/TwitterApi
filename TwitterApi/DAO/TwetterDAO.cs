using EntityFramework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

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

        public bool SearchSave(TweetPost tweets)
        {
            baglanti.TweetPost.Add(tweets);
            int result = baglanti.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool InsertAllPost(IEnumerable<ITweet>  tweetList ,string username,string type)
        {
            try
            {
                List<TweetPost> tweetPosts = new List<TweetPost>();
                foreach (var item in tweetList)
                {
                    TweetPost post = new TweetPost();
                    post.tweet = item.FullText;
                    post.created_at = item.TweetLocalCreationDate;
                    post.username = username;
                    post.type = type;
                    tweetPosts.Add(post);
                }
                EFBatchOperation.For(baglanti, baglanti.TweetPost).InsertAll(tweetPosts);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
