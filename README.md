# Clínica veterinaria

## Introducción

Desarrollamos el caso de una hipotética clínica veterinaria. La misma, almacena datos de sus clientes (dueños de las mascotas) que, en este caso, son: nombre, apellido y correo electrónico. Estos datos son introducidos y gestionados por la persona encargada de la atención a clientes. Además, cada cliente cuenta con un identificador único.

Es posible, de esta manera, realizar un CRUD de nuestra entidad principal (cliente).


## Desarrollo

Para el desarrollo de la solución, se siguió e implementó una arquitectura de software bajo los conceptos de DDD, contando con:
- Capa de presentación
- Capa de aplicación
- Capa de *dominio*
- Capa de infraestructura de datos

Se realizaron una serie de pruebas unitarias de los *value objects* de nuestra capa de dominio.

Para la persistencia de datos, es posible intercambiar entre SQL Server y MongoDB. 

*********************************
/* Además, se almacena información de cada una de las mascotas de las que es dueño cada cliente. Obviamente, cada cliente puede tener más de una mascota, pero cada mascota solo puede pertenecer a un único cliente. Se permite, además, cambiar el dueño de una mascota por otro. Al dar de alta un nuevo animal, se comprobará en el registro del RAIAC (Red Argentina de Identificación de Animales de Compañía) si el animal está correctamente dado de alta. Este proceso únicamente se hará en animales que tengan la obligación de estar identificados. Cada vez que un veterinario realiza una consulta sobre un animal, esta queda almacenada incluyendo datos básicos como: Tiempo de consulta, Identificación de la persona que lo ha tratado, Animal tratado, Importe total, Resolución, Recetas. En caso de que el animal se quede ingresado en la clínica, el cliente debe ser capaz de acceder al estado en tiempo real del animal. Puede ver la historia clínica del mismo y hasta inclusive, ver el animal mediante cámaras de video. La veterinaria cuenta con un sistema de cámara el cual provee al usuario con las imágenes deseadas. A su vez, el cliente debe ser capaz de obtener un histórico de todas las consultas que ha recibido cualquiera de sus mascotas. */
