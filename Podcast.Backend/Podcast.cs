using System;
using System.ServiceModel.Syndication;
using System.Xml;

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
            SyndicationFeed feed = SyndicationFeed.Load(XmlReader.Create(GetFeed(01)));

            if (feed != null)
            {
                foreach (var element in feed.Items)
                {
                    Console.WriteLine($"Title: {element.Title.Text}");
                    Console.WriteLine($"Summary: {element.Summary.Text}");
                    Console.WriteLine($"Publish: {element.PublishDate}");

                    Console.WriteLine($"Link: {element.Links[0].Uri.ToString()}");
                    Console.WriteLine($"DirectLink: {element.Links[1].Uri.ToString()}");

                    Console.WriteLine($"DirectLink: {element.Categories}");
                }
            }
        }
    }
}
