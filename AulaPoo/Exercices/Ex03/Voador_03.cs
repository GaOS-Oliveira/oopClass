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
        public int Asas = 2;
        public float AlturaMax = 100.0f;

        public string Subir()
        {
            return $"O {Nome} está subindo!";
        }

        public string Descer()
        {
            return $"O {Nome} está descendo!";
        }

        public string Atacar()
        {
            AlturaMax += 15f;
            return "O inimgo aéreo atacou com sucesso, agora ele pode voar mais alto!";
        }
    }
}
