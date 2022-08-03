using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo.Exercices.Ex02
{
    public class Patrulheiro_02 : Inimigo_02
    {
        public bool Perseguindo { get; set; }
        public float Velocidade { get; set; }

        public Patrulheiro_02(string _nome, bool _perseguindo = false, float _velocidade = 15.0f)
        {
            Perseguindo = _perseguindo;
            Velocidade = _velocidade;
            Nome = _nome;
        }

        public string Patrulhar()
        {
            return $"O {Nome} está patrulhando!";
        }
    }
}
