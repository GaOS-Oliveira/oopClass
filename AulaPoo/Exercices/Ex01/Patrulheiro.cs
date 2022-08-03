using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo.Exercices.Ex01
{
    public class Patrulheiro : Inimigo
    {
        public bool Perseguindo { get; set; }
        public float Velocidade { get; set; }

        public Patrulheiro(float _velocidade = 15.0f)
        {
            Velocidade = _velocidade;
        }

        public string Patrulhar()
        {
            return $"O {Nome} está patrulhando!";
        }
    }
}
