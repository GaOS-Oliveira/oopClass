using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo
{
    public class Usuario
    {
        // Atributos
        public string? Nome;
        public string? Email;
        public string? Senha;

        // Métodos
        public string Logar()
        {
            return $"Usuário \"{Nome}\" logado com sucesso!";
        }
    }
}
