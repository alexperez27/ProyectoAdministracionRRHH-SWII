using Sistema_académico.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_académico.Negocio
{
    public class NEmpleados
    {

        public NEmpleados() { }

        public static String insertar(DEmpleado e)
        {
            return DEmpleado.insertarMetodoSeguro(e);
            //return DEmpleado.insertar(e);
        }


        public static DataTable reporteNominaEmpleados(DateTime fecha)
        {
            return DEmpleado.reporteNominaEmpleados(fecha);
        }
    }
}
