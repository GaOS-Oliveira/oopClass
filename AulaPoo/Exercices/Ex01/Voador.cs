using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo.Exercices.Ex01
{
    public class Voador : Inimigo
    {
        public int Asas { get; set; }
        public float AlturaMax { get; set; }

        public Voador(int _asas = 2, float _altura = 100.0f)
        {
            Asas = _asas;
            AlturaMax = _altura;
        }

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
