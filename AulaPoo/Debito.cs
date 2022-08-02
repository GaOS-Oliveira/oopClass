using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo
{
    public class Debito : Cartao
    {
        private float Saldo;

        public void Pagar(float _valor)
        {
            Saldo = Saldo - _valor;
        }
    }
}
