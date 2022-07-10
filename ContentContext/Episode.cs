using System.Xml;

namespace podcast.ContentContext
{
    public class Episode
    {
        public Episode(Shows show)
        {
            Show = show;
            
            var reader = XmlReader.Create(show.FeedUrl);
            var xml = new XmlDocument();
            xml.Load(reader);

            foreach (XmlNode node in xml.SelectNodes("//item"))
            {
                Title = node.SelectSingleNode("title").InnerText;
                Description = node.SelectSingleNode("description").InnerText;
                Link = node.SelectSingleNode("link").InnerText;
                Publication = Convert.ToDateTime(node.SelectSingleNode("pubDate").InnerText);
                //TODO Duration
                //TODO Image
                AudioUrl = node.SelectSingleNode("enclosure/@url").InnerText; 
            }
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
    }
}
