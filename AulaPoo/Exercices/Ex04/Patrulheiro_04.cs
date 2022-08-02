using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaPoo.Exercices.Ex02;

namespace AulaPoo.Exercices.Ex04
{
    public class Patrulheiro_04 : Inimigo_02
    {
        public bool Perseguindo = false;
        public float Velocidade;

        public Patrulheiro_04(float _velocity)
        {
            Velocidade = _velocity;
        }

        public string Patrulhar()
        {
            return $"O {Nome} está patrulhando!";
        }
    }
}
