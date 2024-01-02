Album albumDoLinkin = new Album();
albumDoLinkin.Nome = "Hybrid Theory";

Musica musica1 = new Musica();
musica1.Nome = "In the End";
musica1.Duracao = 216;

Musica musica2 = new Musica();
musica2.Nome = "Papercut";
musica2.Duracao = 184;

albumDoLinkin.AdicionarMusica(musica1);
albumDoLinkin.AdicionarMusica(musica2);

albumDoLinkin.ExibirMusicas();

