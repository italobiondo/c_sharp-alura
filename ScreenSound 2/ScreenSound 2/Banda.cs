class Banda
{
    private List<Album> albuns = new List<Album>();

    //construtor
    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (var album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}