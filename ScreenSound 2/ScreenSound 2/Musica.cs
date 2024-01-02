class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida => 
            $"A música {Nome} pertence a banda {Artista}.";//lambda

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nArtista: {Artista}");
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