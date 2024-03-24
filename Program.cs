using System;

namespace PodCast
{
    class Program
    {
        static void Main(string[] args)
        {
            Episodio ep1 = new Episodio(1, "Técnicas de facilitação", 45);
            ep1.AdicionarConvidado("Maria");
            ep1.AdicionarConvidado("Marcelo");

            Episodio ep2 = new Episodio(2, "Tecnicas de aprendizado", 67);
            ep2.AdicionarConvidado("Fernando");
            ep2.AdicionarConvidado("Marcos");
            ep2.AdicionarConvidado("Flavia");

            Podcast podcast = new Podcast("Podcast especial", "Daniel");
            podcast.AdicionarEpisodio(ep1);
            podcast.AdicionarEpisodio(ep2);
            podcast.ExibirDetalhes();
        }
    }
}