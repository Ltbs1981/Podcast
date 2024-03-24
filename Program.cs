using System;

namespace PodCast
{
    class Program
    {
        static void Main(string[] args)
        {
            Episodio ep1 = new Episodio(4, "Técnicas de Facilitação", 45);
            ep1.AdicionarConvidados("João Silva");
            ep1.AdicionarConvidados("Maria Souza");
            Console.WriteLine(ep1.Resumo);
        }
    }
}