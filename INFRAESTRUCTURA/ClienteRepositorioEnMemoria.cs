using _02_DOMINIO.Entidad;
using _02_DOMINIO.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_INFRAESTRUCTURA
{
    public class ClienteRepositorioEnMemoria : ClienteRepositorio
    {
        public void EliminarCliente(Guid idCliente)
        {
            throw new NotImplementedException();
        }

        private List<Cliente> clientes = new List<Cliente>();
        public void Grabar(Cliente cliente)
        {
            this.clientes.Add(cliente);
        }

        public List<Cliente> ObtenerTodos()
        {
            return this.clientes;
        }
    }
}
