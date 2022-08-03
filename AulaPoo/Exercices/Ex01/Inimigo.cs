using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo.Exercices.Ex01
{
    public abstract class Inimigo
    {
        public string Nome { get; set; }
        public float Vida { get; set; }

        public string Atacar()
        {
            return $"O {Nome} atacou!";
        }

        public string Defender()
        {
            return $"O {Nome} se defendeu!";
        }
    }
}
