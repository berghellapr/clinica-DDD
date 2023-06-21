using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO.Entidades;
using DOMINIO.Repositorio;
using INFRAESTRUCTURA.SchemasMongo;
using MongoDB.Bson;
using MongoDB.Driver;
namespace INFRAESTRUCTURA
{
    public class ClienteRepositorioMongoDb : ClienteRepositorio
    {

        private IMongoCollection<ClienteSchema> Conexion()
        {
            const String connectionUri = "mongodb://localhost:27017";
            const String dbName = "ClinicaVeterinaria";
            var client = new MongoClient(connectionUri);
            var db = client.GetDatabase(dbName);
            var collection = db.GetCollection<ClienteSchema>("Clientes");
            return collection;
        }


        public void EliminarCliente(Guid idCliente)
        {
            throw new NotImplementedException();
        }

        public void grabar(Cliente cliente)
        {
            IMongoCollection<ClienteSchema> clienteMongoDB = Conexion();
            clienteMongoDB.InsertOne(new ClienteSchema{ Id = cliente.Id(), Nombre = cliente.Nombre(), Apellido = cliente.Apellido(), Email = cliente.Email()});
        }

        public List<Cliente> obtenerTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
            IMongoCollection<ClienteSchema> clienteMongoDB = Conexion();
            var clientesEnDB = clienteMongoDB.Find(_ => true);

            foreach (var item in clientesEnDB.ToList())
            {
                Guid id = new Guid(item.Id.ToString());
                String nombre = item.Nombre;
                String apellido = item.Apellido;
                String email = item.Email;
                Cliente cliente = new Cliente(id, nombre, apellido, email);
                clientes.Add(cliente);
            }
            return clientes;
        }
    }
}
