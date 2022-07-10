using podcast.ContentContext;

namespace Podcast
{
    class Program
    {
        static void Main()
        {
            var entreChavesPod = new Shows("Entre Chaves", "https://feed.podbean.com/entrechavespodcast/feed.xml");
            var teste = new Episode(entreChavesPod);

            Console.WriteLine(teste.Show.Name);
        }
    }
}