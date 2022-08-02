using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo.Exercices.Ex02
{
    public class Patrulheiro_02 : Inimigo_02
    {
        public bool Perseguindo = false;
        public float Velocidade = 15.0f;

        public string Patrulhar()
        {
            return $"O {Nome} está patrulhando!";
        }
    }
}
