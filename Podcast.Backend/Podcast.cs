using System;
using System.ServiceModel.Syndication;

namespace Podcast.Backend
{
    internal class Podcast
    {
        
    }

    public class SetPodcastProgram
    {
        
        public static string GetFeed()
        {
            string sinapseURL = "https://anchor.fm/s/814b18c/podcast/rss";
            string nerdcastURL = "https://jovemnerd.com.br/feed-nerdcast";

            return sinapseURL;
        }
        
    }
}
