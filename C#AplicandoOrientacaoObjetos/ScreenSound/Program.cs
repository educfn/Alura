using CsharpAplicandoOrientacaoObjetos.ScreenSound;

Banda queen = new Banda();
queen.Nome = "Queen";

Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica(queen);
musica1.Nome = "Love of my life";
musica1.Duracao = 213;

Musica musica2 = new Musica(queen);
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();