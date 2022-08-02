using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo.Exercices.Ex02
{
    public class Inimigo_02
    {
        public string Nome;
        private float Vida = 100f;

        public string Atacar()
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
