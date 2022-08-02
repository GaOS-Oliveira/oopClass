using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo.Exercices.Ex01
{
    public class Patrulheiro : Inimigo
    {
        public bool Perseguindo = false;
        public float Velocidade = 15.0f;

        public string Patrulhar()
        {
            return $"O {Nome} está patrulhando!";
        }
    }
}
