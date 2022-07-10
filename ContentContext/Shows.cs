namespace podcast.ContentContext
{
    public class Shows
    {
        public Shows(string name, string feedUrl)
        {
            Id = Guid.NewGuid();
            Name = name;
            FeedUrl = feedUrl;
        }

        public Guid Id { get; }
        public string Name { get; set; }
        public string FeedUrl { get; set; }

        //TODO eps
    }
}
