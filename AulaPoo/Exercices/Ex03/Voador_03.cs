using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaPoo.Exercices.Ex02;

namespace AulaPoo.Exercices.Ex03
{
    public class Voador_03 : Inimigo_02
    {
        public int Asas { get; set; }
        public float AlturaMax { get; set; }

        public Voador_03(string _nome, int _asas = 2, float _altura = 100.0f)
        {
            Asas = _asas;
            AlturaMax = _altura;
            Nome = _nome;
        }

        public string Subir()
        {
            return $"O {Nome} está subindo!";
        }

        public string Descer()
        {
            return $"O {Nome} está descendo!";
        }

        public override string Atacar()
        {
            AlturaMax += 15f;
            return "O inimgo aéreo atacou com sucesso, agora ele pode voar mais alto!";
        }
    }
}
