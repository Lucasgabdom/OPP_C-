Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidado ("Lucas");
ep1.AdicionarConvidado("Gabrille");


Episodio ep2 = new(2, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidado("Gabriel");
ep2.AdicionarConvidado("Daniel");


Podcast podcast = new("Flow podcast", "Lucas");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();