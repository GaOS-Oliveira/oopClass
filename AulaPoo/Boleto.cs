using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo
{
    public class Boleto : Pagamento
    {
        private string CodigoBarras;

        public void Registrar()
        {
            Console.WriteLine("Boleto registrado.");
        }
    }
}
