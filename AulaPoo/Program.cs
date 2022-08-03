using AulaPoo.Exercices.Ex01;
using AulaPoo.Exercices.Ex02;
using AulaPoo.Exercices.Ex03;
using AulaPoo.Exercices.Ex04;
using AulaPoo.Exercices.Ex05;
using AulaPoo.Exercices.Ex06;
using AulaPoo.Exercices.Ex07;
using AulaPoo.Exercices.Ex08;
using AulaPoo.Exercices.Ex09;

// Exercício 1:
Console.WriteLine(">>> Exercício 1");

Patrulheiro patrulheiro1 = new Patrulheiro();
patrulheiro1.Nome = "Inimigo Patrulheiro 1";
patrulheiro1.Vida = 100f;

Voador voador1 = new Voador();
voador1.Nome = "Inimigo Voador 1";
voador1.Vida = 100f;

Console.WriteLine(patrulheiro1.Atacar());
Console.WriteLine(patrulheiro1.Defender());
Console.WriteLine(patrulheiro1.Patrulhar());

Console.WriteLine(voador1.Atacar());
Console.WriteLine(voador1.Defender());
Console.WriteLine(voador1.Subir());
Console.WriteLine(voador1.Descer());

// Exercício 2:
Console.WriteLine("\n>>> Exercício 2");

Patrulheiro_02 patrulheiro2 = new Patrulheiro_02("Inimigo Patrulheiro 2");

Voador_02 voador2 = new Voador_02("Inimigo Voador 2");

Console.WriteLine(patrulheiro2.Defender());
Console.WriteLine(patrulheiro2.Defender());

Console.WriteLine(voador2.Defender());

// Exercício 3:
Console.WriteLine("\n>>> Exercício 3");

Voador_03 voador3= new Voador_03("Inimigo Voador 3");

Console.WriteLine(voador2.Atacar());
Console.WriteLine(voador3.Atacar());

// Exercício 4:
Console.WriteLine("\n>>> Exercício 4");

Patrulheiro_04 patrulheiro4 = new Patrulheiro_04(20f);
patrulheiro4.Nome = "Inimigo Patrulheiro 4";
Console.WriteLine(patrulheiro4.Velocidade);

// Exercício 5:
Console.WriteLine("\n>>> Exercício 5");

float[] numeros = { 23f, 15.5f, 10f, 5.5f, 17f };

Console.WriteLine(Calculadora.Somar(numeros));
Console.WriteLine(Calculadora.Subtrair(numeros));
Console.WriteLine(Calculadora.Dividir(numeros));
Console.WriteLine(Calculadora.Multiplicar(numeros));

// Exercício 6:
Console.WriteLine("\n>>> Exercício 6");

Jogador jogador1 = new Jogador("Jogador 1");

jogador1.TrocarAcao();
Console.WriteLine("\nAção atual: " + jogador1.AcaoAtual);

// Exercício 7:
Console.WriteLine("\n>>> Exercício 7");

Jogador_02 jogador2 = new Jogador_02("Jogador 2");
Console.WriteLine(jogador2.Morrer());

// Exercício 8:
Console.WriteLine("\n>>> Exercício 8");

Jogador_03 jogador3 = new Jogador_03("Jogador 3");

// Exercício 9:
Console.WriteLine("\n>>> Exercício 9");

Jogador_04 jogador4 = new Jogador_04("Jogador 4", 100f);

// Exercício 10:
Console.WriteLine("\n>>> Exercício 10");
List<Jogador_04> listaJogadores = new List<Jogador_04>();

listaJogadores.Add(new Jogador_04("Jogador da Lista 1", 100f));
listaJogadores.Add(new Jogador_04("Jogador da Lista 2", 100f));
listaJogadores.Add(new Jogador_04("Jogador da Lista 3", 100f));

foreach (Jogador_04 jogador in listaJogadores)
{
    Console.WriteLine(jogador.Nome);
}