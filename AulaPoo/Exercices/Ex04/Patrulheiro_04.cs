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
        public bool Perseguindo { get; set; }
        public float Velocidade { get; set; }

        public Patrulheiro_04(float _velocity = 12f, bool _perseguindo = false)
        {
            Velocidade = _velocity;
            Perseguindo = _perseguindo;
        }

        public string Patrulhar()
        {
            return $"O {Nome} está patrulhando!";
        }
    }
}
