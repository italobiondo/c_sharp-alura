class Album
{
    private List<Musica> musicas = new List<Musica>();

    //construtor
    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"\nLista de músicas do álbum {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir esse álbum inteiro você precisa de {DuracaoTotal}");
    }
}