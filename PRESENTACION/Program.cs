
using _01_APLICACION;
using _01_APLICACION.DTO;
using Autofac;
using _00_PRESENTACION.IoC_Container;

//IContainer container = ContainerMemory.getContainer(); //CONEXION A MEMORIA
//IContainer container = ContainerSQL.getContainer(); //CONEXION A SQL SERVER
IContainer container = ContainerMongoDB.getContainer(); //CONEXION A MONGODB

ClienteDTO Alexis = new ClienteDTO(
    Guid.NewGuid(),
    "Alexis",
    "Paiva",
    "alexis@paiva.com"
    );

ClienteDTO Luis = new ClienteDTO(
    Guid.NewGuid(),
    "Luis",
    "Blanco",
    "luis@blanco.com"
    );

ClienteDTO Paula = new ClienteDTO(
    Guid.NewGuid(),
    "Paula",
    "Berghella",
    "paula@berghella.com"
    );

CrearCliente creadorDeClientes = container.Resolve<CrearCliente>();
creadorDeClientes.Ejecutar(Alexis);
creadorDeClientes.Ejecutar(Luis);
creadorDeClientes.Ejecutar(Paula);
ObtenerClientes obtenedorDeUsuarios = container.Resolve<ObtenerClientes>();

/* Conexion a memoria
 * ClienteRepositorioEnMemoria clienteRepo = new ClienteRepositorioEnMemoria();
CrearCliente creadorDeClientes = new CrearCliente(
        clienteRepo
    );
creadorDeClientes.ejecutar(Alexis);
creadorDeClientes.ejecutar(Luis);
creadorDeClientes.ejecutar(Paula);
ObtenerUsuarios obtenedorDeUsuarios = new ObtenerUsuarios(
        clienteRepo
    );

List<ClienteDTO> todosLosUsuarios = obtenedorDeUsuarios.ejecutar();
*/

List<ClienteDTO> todosLosUsuarios = obtenedorDeUsuarios.Ejecutar();

foreach (ClienteDTO cliente in todosLosUsuarios)
{
    Console.WriteLine(cliente.Presentacion());
}