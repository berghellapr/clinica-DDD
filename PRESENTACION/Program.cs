
using APLICACION;
using APLICACION.DTO;
using Autofac;
using PRESENTACION.IoC_Container;

//IContainer container = ContainerMemory.getContainer();
IContainer container = ContainerSQL.getContainer();

ClienteDTO Alexis = new ClienteDTO(
    Guid.NewGuid(),
    "Alexis",
    "Paiva",
    "alexis@paiva.com");
ClienteDTO Luis = new ClienteDTO(
    Guid.NewGuid(),
    "Luis",
    "Blanco",
    "luis@blanco.com");
ClienteDTO Paula = new ClienteDTO(
    Guid.NewGuid(),
    "Paula",
    "Berghella",
    "paula@berghella.com"
    );

CrearCliente creadorDeClientes = container.Resolve<CrearCliente>();
creadorDeClientes.ejecutar(Alexis);
creadorDeClientes.ejecutar(Luis);
creadorDeClientes.ejecutar(Paula);
ObtenerUsuarios obtenedorDeUsuarios = container.Resolve<ObtenerUsuarios>();

/*
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

List<ClienteDTO> todosLosUsuarios = obtenedorDeUsuarios.ejecutar();

foreach (ClienteDTO cliente in todosLosUsuarios)
{
    Console.WriteLine(cliente.presentacion());
}