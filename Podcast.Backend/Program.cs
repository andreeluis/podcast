using System;

namespace Podcast.Backend
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bem vindo! Escolha o ID do feed que deseja ver:");
            Console.WriteLine("[01] Sinapse");
            Console.WriteLine("[02] Nerdcast");

            int idFeed = Int16.Parse(Console.ReadLine());
            Console.WriteLine(SetPodcastProgram.GetFeed(idFeed));
            SetPodcastProgram.Request();
        }
    }
}
