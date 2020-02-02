
using System.Collections.Generic;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace TwitterApi.Service
{
    class TweetService
    {
        public void Post(string tweet)
        {
            Tweet.PublishTweet(tweet);
        }

        public IEnumerable<ITweet> GetTweetsByUsername(string username,int count) {
             var userTimelineParameters = new UserTimelineParameters();
            userTimelineParameters.MaximumNumberOfTweetsToRetrieve = count;
           return Timeline.GetUserTimeline(username, userTimelineParameters);
            
        } 
        // stream da burada mı yapmalıyım neden?çünkü kod karmaşasını önlemek temiz kod yazmak için bu sınıfı oluşturduk tweet işlemleri burada olucak aynen öyle 
        public List<ITweet> GetStreams(int count)
        {
            var stream = Stream.CreateSampleStream();
            // count kadar getirmem lazım o yüzden 
            int streamCount = 0;
            List<ITweet> streams = new List<ITweet>();
            stream.TweetReceived += (sender, args) =>
            {
                streamCount++;
                if (streamCount==count)
                {
                    stream.StopStream();// bu asenkron bir fonksyion olduğu için arka planda sğrekli çalışıyor o yüzden böyle bir yapısı var 
                    // bende diyorum ki her tweet çekişinde 1 arrtır sayı db de ki sayıya eşit olduğunda akışı durdur  
                }
                streams.Add(args.Tweet);
            };
            stream.StartStream();
            return streams;
        }
    }
}
