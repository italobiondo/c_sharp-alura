/*
Banda linkinPark = new Banda("Linkin Park");

Album albumDoLinkin = new Album("Hybrid Theory");

Musica musica1 = new Musica(linkinPark, "In the End")
{
    Duracao = 216,
    Disponivel = true
};

Musica musica2 = new Musica(linkinPark, "Papercut"){
    Duracao = 184,
    Disponivel = false
};

albumDoLinkin.AdicionarMusica(musica1);
albumDoLinkin.AdicionarMusica(musica2);
linkinPark.AdicionarAlbum(albumDoLinkin);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoLinkin.ExibirMusicas();
linkinPark.ExibirDiscografia();
*/

Episodio episodio1 = new("Técnicas de Facilitação", 2, 45);
episodio1.AdicionarConvidados("Bruno Germano");
episodio1.AdicionarConvidados("Italo Araújo");

Episodio episodio2 = new("Roubo de Carros", 1, 50);
episodio2.AdicionarConvidados("Gisele");
episodio2.AdicionarConvidados("José");
episodio2.AdicionarConvidados("Maria");


Podcast hipsters = new("Italo", "Hipsters Ponto Tech");
hipsters.AdicionarEpisodio(episodio1);
hipsters.AdicionarEpisodio(episodio2);
hipsters.ExibirDetalhes();