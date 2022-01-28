using System;

namespace Podcast.Backend
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bem vindo! Escolha qual feed quer ver:");
            Console.WriteLine("[01] Sinapse ;");
            Console.WriteLine("[02] Nerdcast ;");

            int idFeed = Int16.Parse(Console.ReadLine());
            Console.Write(idFeed);
            Console.WriteLine(SetPodcastProgram.GetFeed());
        }
    }
}
