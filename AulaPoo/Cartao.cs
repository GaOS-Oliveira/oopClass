using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;
        public string Cvv;

        public string SalvarCartao()
        {
            return $"Cartão {Numero} salvo com sucesso.";
        }
    }
}
