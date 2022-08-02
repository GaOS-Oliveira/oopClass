using AulaPoo.Exercices.Ex01;
using AulaPoo.Exercices.Ex02;
using AulaPoo.Exercices.Ex03;
using AulaPoo.Exercices.Ex04;
using AulaPoo.Exercices.Ex05;

// Exercício 1:
Console.WriteLine("Exercício 1");

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
Console.WriteLine("\nExercício 2");

Patrulheiro_02 patrulheiro2 = new Patrulheiro_02();
patrulheiro2.Nome = "Inimigo Patrulheiro 2";

Voador_02 voador2 = new Voador_02();
voador2.Nome = "Inimigo Voador 2";

Console.WriteLine(patrulheiro2.Defender());
Console.WriteLine(patrulheiro2.Defender());

Console.WriteLine(voador2.Defender());

// Exercício 3:
Console.WriteLine("\nExercício 3");

Voador_03 voador3= new Voador_03();
voador3.Nome = "Inimigo Voador 3";

Console.WriteLine(voador2.Atacar());
Console.WriteLine(voador3.Atacar());

// Exercício 4:
Console.WriteLine("\nExercício 4");

Patrulheiro_04 patrulheiro4 = new Patrulheiro_04(20f);
patrulheiro4.Nome = "Inimigo Patrulheiro 4";

// Exercício 5:
Console.WriteLine("\nExercício 5");

float[] numeros = { 23f, 15.5f, 10f, 5.5f, 17f };

Console.WriteLine(Calculadora.Somar(numeros));
Console.WriteLine(Calculadora.Subtrair(numeros));
Console.WriteLine(Calculadora.Dividir(numeros));
Console.WriteLine(Calculadora.Multiplicar(numeros));