using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo
{
    public abstract class Pagamento
    {
        private DateTime Data;
        protected float Valor;

        public string Cancelar()
        {
            return "Pedido cancelado.";
        }
    }
}
