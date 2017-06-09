using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_académico.Datos
{
    public class DEmpleado
    {

        public static int Genero_Hombre = 1;
        public static int Genero_Mujer = 2;

        private int idEmpleado;

        public int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }
        private String _Nombre;

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private String _Apellido;

        public String Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        private String _Direccion;

        public String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        private String _Cedula;

        public String Cedula
        {
            get { return _Cedula; }
            set { _Cedula = value; }
        }
        private String _Telefono;

        public String Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        private String _Estado;

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
        private int _idFichaOcupacional;

        public int IdFichaOcupacional
        {
            get { return _idFichaOcupacional; }
            set { _idFichaOcupacional = value; }
        }
        private DateTime _FechaContratacion;

        public DateTime FechaContratacion
        {
            get { return _FechaContratacion; }
            set { _FechaContratacion = value; }
        }

        public int Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        private int genero;

        public DEmpleado()
        {

        }

        public static String insertar(DEmpleado e)
        {
            string rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();            
            try
            {
                SqlCon.ConnectionString =  Conexion.MySQL;
                SqlCon.Open();
                MySqlCommand SqlCmd = new MySqlCommand("call sp_insertarEmpleado (" + 
                    "'" + e.Nombre + "','" 
                    + e.Apellido + "','" 
                    + e.Direccion + "','"
                    + e.Cedula + "','" 
                    + e.Telefono +"','"
                    + e.Estado + "','"
                    + e.IdFichaOcupacional + "','"
                    + e.FechaContratacion + "'", SqlCon);
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                SqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public static String insertarMetodoSeguro(DEmpleado e)
        {
            string rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.MySQL;
                SqlCon.Open();
                MySqlCommand SqlCmd = new MySqlCommand("call sp_insertarEmpleado("+
                    "@Nombre,"+
                    "@Apellido," +
                    "@Direccion," +
                    "@Cedula," +
                    "@Telefono," +
                    "@Estado," +
                    "@IdFichaOcupacional," +
                    "@FechaContratacion);", SqlCon);
                SqlCmd.Parameters.AddWithValue("@Nombre", e.Nombre);
                SqlCmd.Parameters.AddWithValue("@Apellido", e.Apellido);
                SqlCmd.Parameters.AddWithValue("@Direccion", e.Direccion);
                SqlCmd.Parameters.AddWithValue("@Cedula", e.Cedula);
                SqlCmd.Parameters.AddWithValue("@Telefono", e.Telefono);
                SqlCmd.Parameters.AddWithValue("@Estado", e.Estado);
                SqlCmd.Parameters.AddWithValue("@IdFichaOcupacional", e.IdFichaOcupacional);
                SqlCmd.Parameters.AddWithValue("@FechaContratacion", e.FechaContratacion.ToString("yyyy-MM-dd hh:mm"));
                SqlCmd.Prepare();
                Console.WriteLine("Resultados");
                Console.WriteLine(SqlCmd.Parameters.ToString());
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                SqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.ToString());
                rpta = ex.Message;
                //Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public static DataTable reporteNominaEmpleados(DateTime fecha)
        {
            DataTable tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.MySQL;
                SqlCon.Open();
                MySqlCommand SqlCmd = new MySqlCommand("SELECT * FROM sistemagestionrrhh.vista_reportenominaempleados;", SqlCon);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(tabla);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return tabla;
        }

    }
}
