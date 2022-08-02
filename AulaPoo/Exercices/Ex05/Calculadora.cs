using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo.Exercices.Ex05
{
    static class Calculadora
    {
        public static float Somar(float[] _numeros)
        {
            float result = 0;
            foreach(float _numero in _numeros)
            {
                result += _numero;
            }
            return result;
        }

        public static float Subtrair(float[] _numeros)
        {
            float result = 0;
            foreach (float _numero in _numeros)
            {
                result -= _numero;
            }
            return result;
        }

        public static float Dividir(float[] _numeros)
        {
            float result = 0;
            int counter = 0;
            foreach (float _numero in _numeros)
            {
                if (counter < 1)
                {
                    result = _numero;
                }
                counter++;
                result /= _numero;
            }
            return result;
        }

        public static float Multiplicar(float[] _numeros)
        {
            float result = 0;
            foreach (float _numero in _numeros)
            {
                result *= _numero;
            }
            return result;
        }
    }
}
