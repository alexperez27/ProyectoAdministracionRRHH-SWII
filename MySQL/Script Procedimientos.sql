use sistemagestionrrhh;

 /*----Inserción diasemana---------*/
drop procedure if exists sp_insertarDiasemana;
DELIMITER $$
create procedure sp_insertarDiasemana(
Nombre varchar(45))
begin 
 insert into diasemana(Nombre) values(Nombre); 
 end$$ 
 DELIMITER ;

 /*----Modificación  diasemana---------*/
drop procedure if exists sp_modificarDiasemana;
DELIMITER $$
create procedure sp_modificarDiasemana(
idDiaSemana int,
Nombre varchar(45))
begin 
 update diasemana 
 set Nombre=Nombre
where idDiaSemana=idDiaSemana; 
 end$$ 
 DELIMITER ;

 /*----Obtención diasemana---------*/
drop procedure if exists sp_obtenerDiasemana;
DELIMITER $$
create procedure sp_obtenerDiasemana()
BEGIN 
 select * from diasemana;
 end$$ 
 DELIMITER ;

 /*----ObtenerPorID diasemana---------*/
drop procedure if exists sp_obtenerPorIDDiasemana;
DELIMITER $$
create procedure sp_obtenerPorIDDiasemana(
idDiaSemana int)
begin 
 select * from diasemana where idDiaSemana=idDiaSemana;
 end$$ 
 DELIMITER ;

 /*----Inserción empleado---------*/
drop procedure if exists sp_insertarEmpleado;
DELIMITER $$
create procedure sp_insertarEmpleado(
Nombre varchar(45),
Apellido varchar(45),
Direccion varchar(45),
Cedula varchar(45),
Telefono varchar(45),
Estado varchar(45),
`Fichas Ocupacionales_idFichas Ocupacionales` int,
FechaContratacion varchar(45))
begin 
 insert into empleado(Nombre,Apellido,Direccion,Cedula,Telefono,Estado,`Fichas Ocupacionales_idFichas Ocupacionales`,FechaContratacion) values(Nombre,Apellido,Direccion,Cedula,Telefono,Estado,`Fichas Ocupacionales_idFichas Ocupacionales`,FechaContratacion); 
 end$$ 
 DELIMITER ;

 /*----Modificación  empleado---------*/
drop procedure if exists sp_modificarEmpleado;
DELIMITER $$
create procedure sp_modificarEmpleado(
idEmpleado int,
Nombre varchar(45),
Apellido varchar(45),
Direccion varchar(45),
Cedula varchar(45),
Telefono varchar(45),
Estado varchar(45),
`Fichas Ocupacionales_idFichas Ocupacionales` int,
FechaContratacion varchar(45))
begin 
 update empleado 
 set Nombre=Nombre,Apellido=Apellido,Direccion=Direccion,Cedula=Cedula,Telefono=Telefono,Estado=Estado,`Fichas Ocupacionales_idFichas Ocupacionales`=`Fichas Ocupacionales_idFichas Ocupacionales`,FechaContratacion=FechaContratacion
where idEmpleado=idEmpleado; 
 end$$ 
 DELIMITER ;

 /*----Obtención empleado---------*/
drop procedure if exists sp_modificarEmpleado;
DELIMITER $$
create procedure sp_obtenerEmpleado()
BEGIN 
 select * from empleado;
 end$$ 
 DELIMITER ;

 /*----ObtenerPorID empleado---------*/
drop procedure if exists sp_obtenerPorIDEmpleado;
DELIMITER $$
create procedure sp_obtenerPorIDEmpleado(
idEmpleado int)
begin 
 select * from empleado where idEmpleado=idEmpleado;
 end$$ 
 DELIMITER ;

 /*----Inserción empleado_has_horario---------*/
drop procedure if exists sp_insertarEmpleadoHasHorario;
DELIMITER $$
create procedure sp_insertarEmpleadoHasHorario(
`Empleado_Fichas Ocupacionales_idFichas Ocupacionales` int,
Horario_idHorario int,
Horario_DiaSemana_idDiaSemana int)
begin 
 insert into empleado_has_horario(`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`,Horario_idHorario,Horario_DiaSemana_idDiaSemana)
 values(`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`,Horario_idHorario,Horario_DiaSemana_idDiaSemana); 
 end$$ 
 DELIMITER ;

 /*----Modificación  empleado_has_horario---------*/
drop procedure if exists sp_modificarEmpleadoHasHorario;
DELIMITER $$
create procedure sp_modificarEmpleadoHasHorario(
Empleado_idEmpleado int,
`Empleado_Fichas Ocupacionales_idFichas Ocupacionales` int,
Horario_idHorario int,
Horario_DiaSemana_idDiaSemana int)
begin 
 update empleado_has_horario 
 set `Empleado_Fichas Ocupacionales_idFichas Ocupacionales`=`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`,Horario_idHorario=Horario_idHorario,Horario_DiaSemana_idDiaSemana=Horario_DiaSemana_idDiaSemana
where Empleado_idEmpleado=Empleado_idEmpleado; 
 end$$ 
 DELIMITER ;

 /*----Obtención empleado_has_horario---------*/
drop procedure if exists sp_modificarEmpleadoHasHorario;
DELIMITER $$
create procedure sp_obtenerEmpleadoHasHorario()
BEGIN 
 select * from empleado_has_horario;
 end$$ 
 DELIMITER ;

 /*----ObtenerPorID empleado_has_horario---------*/
drop procedure if exists sp_obtenerPorIDEmpleadoHasHorario;
DELIMITER $$
create procedure sp_obtenerPorIDEmpleadoHasHorario(
Empleado_idEmpleado int)
begin 
 select * from empleado_has_horario where Empleado_idEmpleado=Empleado_idEmpleado;
 end$$ 
 DELIMITER ;

 /*----Inserción empleado_has_vacaciones---------*/
drop procedure if exists sp_insertarEmpleadoHasVacaciones;
DELIMITER $$
create procedure sp_insertarEmpleadoHasVacaciones(
`Empleado_Fichas Ocupacionales_idFichas Ocupacionales` int,
Vacaciones_idVacaciones int)
begin 
 insert into empleado_has_vacaciones(`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`,Vacaciones_idVacaciones) values(`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`,Vacaciones_idVacaciones); 
 end$$ 
 DELIMITER ;

 /*----Modificación  empleado_has_vacaciones---------*/
drop procedure if exists sp_modificarEmpleadoHasVacaciones;
DELIMITER $$
create procedure sp_modificarEmpleadoHasVacaciones(
Empleado_idEmpleado int,
`Empleado_Fichas Ocupacionales_idFichas Ocupacionales` int,
Vacaciones_idVacaciones int)
begin 
 update empleado_has_vacaciones 
 set `Empleado_Fichas Ocupacionales_idFichas Ocupacionales`=`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`,Vacaciones_idVacaciones=Vacaciones_idVacaciones
where Empleado_idEmpleado=Empleado_idEmpleado; 
 end$$ 
 DELIMITER ;

 /*----Obtención empleado_has_vacaciones---------*/
drop procedure if exists sp_modificarEmpleadoHasVacaciones;
DELIMITER $$
create procedure sp_obtenerEmpleadoHasVacaciones()
BEGIN 
 select * from empleado_has_vacaciones;
 end$$ 
 DELIMITER ;

 /*----ObtenerPorID empleado_has_vacaciones---------*/
drop procedure if exists sp_obtenerPorIDEmpleadoHasVacaciones;
DELIMITER $$
create procedure sp_obtenerPorIDEmpleadoHasVacaciones(
Empleado_idEmpleado int)
begin 
 select * from empleado_has_vacaciones where Empleado_idEmpleado=Empleado_idEmpleado;
 end$$ 
 DELIMITER ;

 /*----Inserción entradasalida---------*/
drop procedure if exists sp_insertarEntradasalida;
DELIMITER $$
create procedure sp_insertarEntradasalida(
Fecha date,
HoraEntrada time,
HoraSalida time,
Empleado_idEmpleado int,
`Empleado_Fichas Ocupacionales_idFichas Ocupacionales` int)
begin 
 insert into entradasalida(Fecha,HoraEntrada,HoraSalida,Empleado_idEmpleado,`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`) 
 values(Fecha,HoraEntrada,HoraSalida,Empleado_idEmpleado,`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`); 
 end$$ 
 DELIMITER ;

 /*----Modificación  entradasalida---------*/
drop procedure if exists sp_modificarEntradasalida;
DELIMITER $$
create procedure sp_modificarEntradasalida(
idEntradaSalida int,
Fecha date,
HoraEntrada time,
HoraSalida time,
Empleado_idEmpleado int,
`Empleado_Fichas Ocupacionales_idFichas Ocupacionales` int)
begin 
 update entradasalida 
 set Fecha=Fecha,HoraEntrada=HoraEntrada,HoraSalida=HoraSalida,Empleado_idEmpleado=Empleado_idEmpleado,`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`=`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`
where idEntradaSalida=idEntradaSalida; 
 end$$ 
 DELIMITER ;

 /*----Obtención entradasalida---------*/
drop procedure if exists sp_modificarEntradasalida;
DELIMITER $$
create procedure sp_obtenerEntradasalida()
BEGIN 
 select * from entradasalida;
 end$$ 
 DELIMITER ;

 /*----ObtenerPorID entradasalida---------*/
drop procedure if exists sp_obtenerPorIDEntradasalida;
DELIMITER $$
create procedure sp_obtenerPorIDEntradasalida(
idEntradaSalida int)
begin 
 select * from entradasalida where idEntradaSalida=idEntradaSalida;
 end$$ 
 DELIMITER ;

 /*----Inserción fichas ocupacionales---------*/
drop procedure if exists sp_insertarFichasOcupacionales;
DELIMITER $$
create procedure sp_insertarFichasOcupacionales(
`Nombre Cargo` varchar(45),
Area varchar(45),
Definicion varchar(45),
Funciones varchar(45),
Requisitos varchar(45),
`Salario Base` varchar(45))
begin 
 insert into `fichas ocupacionales`(`Nombre Cargo`,Area,Definicion,Funciones,Requisitos,`Salario Base`) values(`Nombre Cargo`,Area,Definicion,Funciones,Requisitos,`Salario Base`); 
 end$$ 
 DELIMITER ;

 /*----Modificación  fichas ocupacionales---------*/
drop procedure if exists sp_modificarFichasOcupacionales;
DELIMITER $$
create procedure sp_modificarFichasOcupacionales(
`idFichas Ocupacionales` int,
`Nombre Cargo` varchar(45),
Area varchar(45),
Definicion varchar(45),
Funciones varchar(45),
Requisitos varchar(45),
`Salario Base` varchar(45))
begin 
 update fichas ocupacionales 
 set `Nombre Cargo`=`Nombre Cargo`,Area=Area,Definicion=Definicion,Funciones=Funciones,Requisitos=Requisitos,`Salario Base`=`Salario Base`
where `idFichas Ocupacionales`=`idFichas Ocupacionales`; 
 end$$ 
 DELIMITER ;

 /*----Obtención fichas ocupacionales---------*/
drop procedure if exists sp_modificarFichasOcupacionales;
DELIMITER $$
create procedure sp_obtenerFichasOcupacionales()
BEGIN 
 select * from fichas ocupacionales;
 end$$ 
 DELIMITER ;

 /*----ObtenerPorID fichas ocupacionales---------*/
drop procedure if exists sp_obtenerPorIDFichasOcupacionales;
DELIMITER $$
create procedure sp_obtenerPorIDFichasOcupacionales(
`idFichas Ocupacionales` int)
begin 
 select * from fichas ocupacionales where `idFichas Ocupacionales`=`idFichas Ocupacionales`;
 end$$ 
 DELIMITER ;

 /*----Inserción horario---------*/
drop procedure if exists sp_insertarHorario;
DELIMITER $$
create procedure sp_insertarHorario(
DiaSemana varchar(45),
HoraInicio varchar(45),
HoraFin varchar(45),
DiaSemana_idDiaSemana int)
begin 
 insert into horario(DiaSemana,HoraInicio,HoraFin,DiaSemana_idDiaSemana) values(DiaSemana,HoraInicio,HoraFin,DiaSemana_idDiaSemana); 
 end$$ 
 DELIMITER ;

 /*----Modificación  horario---------*/
drop procedure if exists sp_modificarHorario;
DELIMITER $$
create procedure sp_modificarHorario(
idHorario int,
DiaSemana varchar(45),
HoraInicio varchar(45),
HoraFin varchar(45),
DiaSemana_idDiaSemana int)
begin 
 update horario 
 set DiaSemana=DiaSemana,HoraInicio=HoraInicio,HoraFin=HoraFin,DiaSemana_idDiaSemana=DiaSemana_idDiaSemana
where idHorario=idHorario; 
 end$$ 
 DELIMITER ;

 /*----Obtención horario---------*/
drop procedure if exists sp_modificarHorario;
DELIMITER $$
create procedure sp_obtenerHorario()
BEGIN 
 select * from horario;
 end$$ 
 DELIMITER ;

 /*----ObtenerPorID horario---------*/
drop procedure if exists sp_obtenerPorIDHorario;
DELIMITER $$
create procedure sp_obtenerPorIDHorario(
idHorario int)
begin 
 select * from horario where idHorario=idHorario;
 end$$ 
 DELIMITER ;

 /*----Inserción pagos---------*/
drop procedure if exists sp_insertarPagos;
DELIMITER $$
create procedure sp_insertarPagos(
Monto varchar(45),
FechaPago varchar(45),
Empleado_idEmpleado int,
`Empleado_Fichas Ocupacionales_idFichas Ocupacionales` int)
begin 
 insert into pagos(Monto,FechaPago,Empleado_idEmpleado,`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`) values(Monto,FechaPago,Empleado_idEmpleado,`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`); 
 end$$ 
 DELIMITER ;

 /*----Modificación  pagos---------*/
drop procedure if exists sp_modificarPagos;
DELIMITER $$
create procedure sp_modificarPagos(
idPagos int,
Monto varchar(45),
FechaPago varchar(45),
Empleado_idEmpleado int,
`Empleado_Fichas Ocupacionales_idFichas Ocupacionales` int)
begin 
 update pagos 
 set Monto=Monto,FechaPago=FechaPago,Empleado_idEmpleado=Empleado_idEmpleado,`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`=`Empleado_Fichas Ocupacionales_idFichas Ocupacionales`
where idPagos=idPagos; 
 end$$ 
 DELIMITER ;

 /*----Obtención pagos---------*/
drop procedure if exists sp_modificarPagos;
DELIMITER $$
create procedure sp_obtenerPagos()
BEGIN 
 select * from pagos;
 end$$ 
 DELIMITER ;

 /*----ObtenerPorID pagos---------*/
drop procedure if exists sp_obtenerPorIDPagos;
DELIMITER $$
create procedure sp_obtenerPorIDPagos(
idPagos int)
begin 
 select * from pagos where idPagos=idPagos;
 end$$ 
 DELIMITER ;

 /*----Inserción vacaciones---------*/
drop procedure if exists sp_insertarVacaciones;
DELIMITER $$
create procedure sp_insertarVacaciones(
FechaInicio varchar(45),
FechaFin varchar(45),
Descripcion varchar(45))
begin 
 insert into vacaciones(FechaInicio,FechaFin,Descripcion) values(FechaInicio,FechaFin,Descripcion); 
 end$$ 
 DELIMITER ;

 /*----Modificación  vacaciones---------*/
drop procedure if exists sp_modificarVacaciones;
DELIMITER $$
create procedure sp_modificarVacaciones(
idVacaciones int,
FechaInicio varchar(45),
FechaFin varchar(45),
Descripcion varchar(45))
begin 
 update vacaciones 
 set FechaInicio=FechaInicio,FechaFin=FechaFin,Descripcion=Descripcion
where idVacaciones=idVacaciones; 
 end$$ 
 DELIMITER ;

 /*----Obtención vacaciones---------*/
drop procedure if exists sp_modificarVacaciones;
DELIMITER $$
create procedure sp_obtenerVacaciones()
BEGIN 
 select * from vacaciones;
 end$$ 
 DELIMITER ;

 /*----ObtenerPorID vacaciones---------*/
drop procedure if exists sp_obtenerPorIDVacaciones;
DELIMITER $$
create procedure sp_obtenerPorIDVacaciones(
idVacaciones int)
begin 
 select * from vacaciones where idVacaciones=idVacaciones;
 end$$ 
 DELIMITER ;