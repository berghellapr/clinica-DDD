
using APLICACION;
using APLICACION.DTO;
using INFRAESTRUCTURA;

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

ClienteRepositorioEnMemoria clienteRepo = new ClienteRepositorioEnMemoria();

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

foreach(ClienteDTO cliente in todosLosUsuarios)
{
    Console.WriteLine(cliente.presentacion());
}