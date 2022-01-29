using System;
using System.ServiceModel.Syndication;
using System.Xml;

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
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            foreach (SyndicationItem item in feed.Items)
            {
                String title = item.Title.Text;
                String summary = item.Summary.Text;

                Console.WriteLine(title);
                Console.WriteLine(summary);
                Console.WriteLine("");
            }
        }

    }
}
