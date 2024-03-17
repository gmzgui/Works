using Class_bárbaro;

barbaro barbaro1 = new barbaro();

barbaro1.nome = "César";
barbaro1.vida = 100;
barbaro1.energia = 75;
barbaro1.maxVida = 100;
barbaro1.maxEnergia = 75;
barbaro1.nivel = 1;
barbaro1.vitalidade = 30;
barbaro1.forca = 25;
barbaro1.destreza = 20;
barbaro1.inteligencia = 35;

barbaro barbaro2 = new barbaro();

barbaro2.nome = "Maicon";
barbaro2.vida = 100;
barbaro2.energia = 75;
barbaro2.maxVida = 100;
barbaro2.maxEnergia = 75;
barbaro2.nivel = 1;
barbaro2.vitalidade = 30;
barbaro2.forca = 25;
barbaro2.destreza = 20;
barbaro2.inteligencia = 35;

barbaro2.atacar(barbaro1);
barbaro1.status();
barbaro2.status();
barbaro1.revigorar(20);
barbaro1.status();





