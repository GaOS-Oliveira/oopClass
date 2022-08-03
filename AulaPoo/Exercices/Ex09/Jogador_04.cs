using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo.Exercices.Ex09
{
    public class Jogador_04
    {
        public string Nome { get; set; }
        public float Vida { get; set; }

        public enum Acoes
        {
            Atacando,
            Defendendo,
            Pulando,
            Correndo,
            Inválida
        }

        public Acoes AcaoAtual { get; set; }

        public Jogador_04(string _nome)
        {
            Nome = _nome;
        }

        public Jogador_04(string _nome, float _vida)
        {
            Nome = _nome;
            Vida = _vida;
        }

        public void TrocarAcao()
        {
            Console.Write("Aperte uma tecla [WASD]: ");
            ConsoleKeyInfo tecla = Console.ReadKey();

            if (tecla.KeyChar.ToString().ToLower() == "w")
            {
                AcaoAtual = Acoes.Pulando;
            }
            else if (tecla.KeyChar.ToString().ToLower() == "a")
            {
                AcaoAtual = Acoes.Correndo;
            }
            else if (tecla.KeyChar.ToString().ToLower() == "s")
            {
                AcaoAtual = Acoes.Atacando;
            }
            else if (tecla.KeyChar.ToString().ToLower() == "d")
            {
                AcaoAtual = Acoes.Defendendo;
            }
            else
            {
                AcaoAtual = Acoes.Inválida;
                Console.WriteLine("\nAção Inválida!");
            }
        }
    }
}
