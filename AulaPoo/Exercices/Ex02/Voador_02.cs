using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo.Exercices.Ex02
{
    public class Voador_02 : Inimigo_02
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
    }
}
