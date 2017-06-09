using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sistema_académico.Datos;
using Sistema_académico.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_académico.Negocio.Tests
{
    [TestClass()]
    public class NEmpleadosTests
    {
        [TestMethod()]
        public void inyeccionSQL()
        {
            DEmpleado empleado= new DEmpleado();
            empleado.Nombre = "','','','','','',1,''); " +
                "INSERT INTO `sistemagestionrrhh`.`fichas ocupacionales` (`Nombre Cargo`, `Area`, `Definicion`, `Funciones`, `Requisitos`, `Salario Base`) "+ 
                "VALUES('Vendedor', 'Ventas', 'Encargado de vender', 'Supervision, administración de asistencias', 'Ingenieria Industrial o carreras a fines', '20000');"+
                " #";            
            empleado.Apellido = "AAAAAAAAAAAAAAAAAAA";
            empleado.Cedula = "00";
            String respuesta=NEmpleados.insertar(empleado);
            
            Assert.Fail(respuesta);
        }
        [TestMethod()]
        public void nombreMuyLargo()
        {
            DEmpleado empleado = new DEmpleado();
            empleado.Nombre = "Alexxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";            
            empleado.Apellido = "Pérez";
            empleado.Cedula = "00";
            String respuesta = NEmpleados.insertar(empleado);

            Assert.Fail(respuesta);
        }
    }
}