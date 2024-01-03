class Musica
{
    //construtor
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida =>
            $"A música {Nome} pertence a banda {Artista.Nome}.";//lambda

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nArtista: {Artista.Nome}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Não disponível para o seu plano.");
        }
    }
}