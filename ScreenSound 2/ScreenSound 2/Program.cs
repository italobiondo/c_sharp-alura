Album albumDoLinkin = new Album();
albumDoLinkin.Nome = "Hybrid Theory";

Musica musica1 = new Musica();
musica1.Nome = "In the End";

Musica musica2 = new Musica();
musica2.Nome = "Papercut";

albumDoLinkin.AdicionarMusica(musica1);
albumDoLinkin.AdicionarMusica(musica2);

Console.WriteLine();