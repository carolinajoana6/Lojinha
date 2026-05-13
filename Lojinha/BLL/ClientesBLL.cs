using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lojinha.DAL;
using Lojinha.Modelos;

namespace Lojinha.BLL
{
    public class ClientesBLL
    {
        public void Incluir(ClienteInformation cliente)
        {
            //o nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            //Email é sempre em letras minúsculas
            cliente.Email = cliente.Email.ToLower();
            //Se está tudo OK, chama a rotina de inserção
            ClientesDAL obj = new ClientesDAL();
            obj.incluir(cliente);
        }
        public void Alterar(ClienteInformation cliente)
        {
            //o nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            //Email é sempre em letras minúsculas
            cliente.Email = cliente.Email.ToLower();
            //Se está tudo OK, chama a rotina de alteração
            ClientesDAL obj = new ClientesDAL();
            obj.(cliente);

        }
    }
}
