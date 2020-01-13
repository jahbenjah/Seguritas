# 1.4	Requerimiento
Se tiene un proyecto para el cliente “Seguritas” el cual es encargado de manejar pólizas de seguros, derivado del cambio del negocio en el cual se van a adicionar nuevos clientes al modelo del negocio, el cliente solicita:
1.	Generar una nueva interfaz con la cual sea capaz de poder dar mantenimiento a los nuevos clientes, planes y coberturas, teniendo las siguientes consideraciones. 
a.	Un cliente, plan y cobertura deben tener un número de identificación único. 
b.	El nombre del cliente, plan y cobertura no puede ir vacío.
c.	El nombre del cliente debe ser único y no se puede repetir. 
d.	Un cliente puede tener muchos planes. 
e.	Un plan puede tener muchas coberturas.
f.	Una misma cobertura puede pertenecer a múltiples planes. 
g.	Se necesita alguna manera de saber cuando se crea el registro por temas de auditoría.


2.	La interfaz deberá poder visualizarse en modo responsivo dentro de diferentes dispo-sitivos. 

# 1.5	Solución técnica
Derivada de la necesidad del cliente se presenta la siguiente solución
1.	Para la interfaz se propone realizar una pantalla la cual sea la encargada de realizar las operaciones CRUD únicamente para los clientes, bajo las siguientes limitantes tecnológicas:
a.	Solución de .Net Framework (4.6.x) mínimo. 
b.	Vistas Razor
c.	MVC
d.	API Rest para operaciones CRUD asíncronas
e.	Llamada de controladores desde la vista mediante AJAX. 
f.	Las consultas a la base de datos para obtener la información se deberán de realizar mediante ADO .Net
g.	Las demás operaciones CRUD deberán de realizarse mediante Entity Frame-work 6.x utilizando el paradigma “CodeFirst” 
h.	Bootstrap 4.x 
i.	JavaScript para validaciones del lado del cliente. 
2.	La pantalla principal mostrará un listado de Clientes y su información de la entidad Clientes. 
3.	Para persistir la información se ocupará SQL Server 2014 o superior.
4.	Para la solución de los puntos d – g se entregará solo el modelo de datos y toda la administración se llevará mediante scripts directos a la base de datos, se da como primera propuesta las siguientes entidades.
 
*Este esquema puede variar de acuerdo con la necesidad del cliente.


5.	Todos los cambios de código y base de datos (scripts) deberán de ir dentro de un re-positorio GIT para que el rastreo de cambios sea sencillo. 
