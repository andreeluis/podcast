using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Linq;

namespace podcast.ContentContext
{
    public class Episode
    {
        public Episode(Shows show)
        {
            Show = show;
            GetEpisodes(show.FeedUrl);
        }

        public Shows Show { get; set; }
        public string Title { get; }
        public string Description { get; }
        public string Link { get; }
        public DateTime Publication { get; }
        public TimeSpan Duration { get; }
        public int EpisodeNumber { get; }
        public string ImageURL { get; }
        public string AudioUrl { get; }
        
        public void GetEpisodes(string feedUrl)
        {
            XmlReader reader = XmlReader.Create(feedUrl);

            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            string value;
            foreach (XmlNode node in doc.SelectNodes("//item/title"))
            {
                value = node.InnerText;
                Console.WriteLine(value);
            }
        }
    }
}
