using System;
using CodeHollow.FeedReader;

namespace Podcast.Backend
{
    internal class Podcast
    {
        
    }

    public class SetPodcastProgram
    {
        public static string GetFeed(int id)
        {
            string sinapseURL = "https://anchor.fm/s/814b18c/podcast/rss"; //01
            string nerdcastURL = "https://jovemnerd.com.br/feed-nerdcast"; //02

            string url = "";

            if (id == 01)
            {
                url = sinapseURL;
            }
            else if (id == 02)
            {
                url = nerdcastURL;
            }
            else
            {
                Console.WriteLine("Erro! ID não cadastrado.");
            }

            return url;
        }
        
        public static void Request()
        {
            string url = GetFeed(01);

            var feedUrl = url;

            var readerTask = FeedReader.ReadAsync(feedUrl);
            readerTask.ConfigureAwait(false);

            foreach (var item in readerTask.Result.Items)
            {
                Console.WriteLine($"Tite: {item.Title}");
                Console.WriteLine($"Desc: {item.Description}");
                Console.WriteLine($"URL: {item.Link}");
            }
        }
    }
}
