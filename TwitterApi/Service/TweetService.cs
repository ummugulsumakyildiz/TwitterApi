
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
       
        public List<ITweet> GetStreams(int count)
        {
            var stream = Stream.CreateSampleStream();
            int streamCount = 0;
            List<ITweet> streams = new List<ITweet>();
            stream.TweetReceived += (sender, args) =>
            {
                streamCount++;
                if (streamCount==count)
                {
                    stream.StopStream();
                }
                streams.Add(args.Tweet);
            };
            stream.StartStream();
            return streams;
        }
    }
}
