USE `sistemagestionrrhh`;
DROP function IF EXISTS `calcularHorasExtras`;

USE `sistemagestionrrhh`;
DELIMITER $$
CREATE FUNCTION `calcularHorasExtras` (idEmpleado int,fecha date)
RETURNS INTEGER
BEGIN
	declare valor int;	
	set @valor=cast(
    (select count(e.HoraSalida-h.HoraFin) as HorasExtras
	/*emp.Nombre,*/
	from entradasalida e
	inner join empleado emp on emp.idEmpleado = Empleado_idEmpleado
	inner join empleado_has_horario emplH on emplH.Empleado_idEmpleado= emp.idEmpleado
	inner join horario h on emp.idEmpleado = emplH.Horario_idHorario
	group by dayname(e.Fecha)=h.DiaSemana
    limit 1)
    as decimal);
RETURN valor;
END	$$

use sistemagestionrrhh;
select 
e.Nombre,fichas.`Nombre Cargo`,fichas.`Salario Base`,
year(now()-e.FechaContratacion) as `Años Antiguedad `,100 as `MontoPorAñosantiguedad`, 
calcularHorasExtras(e.idEmpleado,now()) as HorasExtras, 100 as `montoPorHorasExtras` ,
(year(now()-e.FechaContratacion) * 100) + (calcularHorasExtras(e.idEmpleado,now()) * 100 ) as MontoAcumulado,
(year(now()-e.FechaContratacion) * 100) + (calcularHorasExtras(e.idEmpleado,now()) * 100 ) * 0.0625 as INSS,
(year(now()-e.FechaContratacion) * 100) + (calcularHorasExtras(e.idEmpleado,now()) * 100 ) * 0.15 as IR,
(year(now()-e.FechaContratacion) * 100) + (calcularHorasExtras(e.idEmpleado,now()) * 100 ) - 
( (year(now()-e.FechaContratacion) * 100) + (calcularHorasExtras(e.idEmpleado,now()) * 100 ) * 0.0625 ) -
( (year(now()-e.FechaContratacion) * 100) + (calcularHorasExtras(e.idEmpleado,now()) * 100 ) * 0.15 ) as SalarioNeto
from empleado e
inner join `fichas_ocupacionales` fichas on `idFichas_Ocupacionales` = `Fichas_Ocupacionales_idFichas_Ocupacionales`;

/*Empleado cargo salarioBase AñosAntiguedad MontoPorAñosantiguedad HOrasExtras
montoPorHorasExtras MontoAcumulado INSS IR SalarioNeto*/


DELIMITER ;
    
    USE `sistemagestionrrhh`;
	CREATE  OR REPLACE VIEW `vista_ReporteNominaEmpleadovista_reportenominaempleadoss` AS
	select 
	e.Nombre,fichas.`Nombre Cargo`,fichas.`Salario Base`,
	year(now()-e.FechaContratacion) as `Antiguedad`,100 as `MontoPorAñosantiguedad`, 
	calcularHorasExtras(e.idEmpleado,now()) as HorasExtras, 100 as `montoPorHorasExtras` ,
	(year(now()-e.FechaContratacion) * 100) + (calcularHorasExtras(e.idEmpleado,now()) * 100 ) as MontoAcumulado,
	(year(now()-e.FechaContratacion) * 100) + (calcularHorasExtras(e.idEmpleado,now()) * 100 ) * 0.0625 as INSS,
	(year(now()-e.FechaContratacion) * 100) + (calcularHorasExtras(e.idEmpleado,now()) * 100 ) * 0.15 as IR,
	(year(now()-e.FechaContratacion) * 100) + (calcularHorasExtras(e.idEmpleado,now()) * 100 ) - 
	( (year(now()-e.FechaContratacion) * 100) + (calcularHorasExtras(e.idEmpleado,now()) * 100 ) * 0.0625 ) -
	( (year(now()-e.FechaContratacion) * 100) + (calcularHorasExtras(e.idEmpleado,now()) * 100 ) * 0.15 ) as SalarioNeto
	from empleado e
	inner join `fichas_ocupacionales` fichas on `idFichas_Ocupacionales` = `Fichas_Ocupacionales_idFichas_Ocupacionales`;
	;
    
    USE `sistemagestionrrhh`;
	CREATE  OR REPLACE VIEW `vista_ReporteEmpleados` AS
	select e.idEmpleado,e.Nombre,e.Apellido,e.Direccion,e.Cedula,e.Telefono,fichas.`Nombre Cargo`,fichas.Area,e.FechaContratacion
    ,e.Estado
	from empleado e
	inner join fichas_ocupacionales fichas on `idFichas_Ocupacionales` = `Fichas_Ocupacionales_idFichas_Ocupacionales`
    order by e.Nombre ASC
    ;
    
    select * from fichas_ocupacionales;
	
