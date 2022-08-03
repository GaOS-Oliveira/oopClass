using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo.Exercices.Ex02
{
    public class Inimigo_02
    {
        public string Nome { get; set; }
        private float Vida { get; set; }

        public Inimigo_02(float _vida = 100f)
        {
            Vida = _vida;
        }

        public virtual string Atacar()
        {
            return $"O {Nome} atacou!";
        }

        public string Defender()
        {
            Vida = Vida - 5f;
            return $"O {Nome} se defendeu!\nMas sua vida foi reduzida para {Vida}!";
        }
    }
}
