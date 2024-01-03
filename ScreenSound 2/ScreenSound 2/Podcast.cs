class Podcast
{
    private List<Episodio> episodios = new();
    // Construtor
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este podcast possui {TotalEpisodios} episódios.\n");
    }

}