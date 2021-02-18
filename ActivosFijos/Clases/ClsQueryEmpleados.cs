using System;
using System.Data;
using Npgsql;

namespace ActivosFijos.Clases
{
    class ClsQueryEmpleados
    {
        string cadenaSql;
        readonly NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"empId\" AS EmpId, \"empCedula\" AS Cedula, \"empNombre\" AS NombreDelEmpleado, \"empFechaEntrada\" AS FechaEntrada ";
            cadenaSql += "FROM \"Empleados\" ";
            cadenaSql += "ORDER BY \"empNombre\" ";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable Buscar(string nombre)
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"empId\" AS EmpId, \"empCedula\" AS Cedula, \"empNombre\" AS NombreDelEmpleado, \"empFechaEntrada\" AS FechaEntrada ";
            cadenaSql += "FROM \"Empleados\" ";
            if (nombre != "")
            {
                cadenaSql += "WHERE \"empNombre\" ILIKE '%{0}%' ";
            }
            cadenaSql += "ORDER BY \"empNombre\" ";
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(cadenaSql, nombre), conexion);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public string SecuenciaId()
        {
            conexion.Open();
            string secId = null;
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("SELECT max(\"empId\") FROM \"Empleados\" "), conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                secId = dr[0].ToString();
            }
            dr.Close();
            conexion.Close();
            return secId;
        }

        public bool Insertar(string empId, string empCedula, string empNombre, string empFechaEntrada)
        {
            conexion.Open();
            cadenaSql = null;
            cadenaSql += "INSERT INTO \"Empleados\" (";
            cadenaSql += "\"empId\", ";
            cadenaSql += "\"empCedula\", ";
            cadenaSql += "\"empNombre\", ";
            cadenaSql += "\"empFechaEntrada\" ";
            cadenaSql += ")";
            cadenaSql += "VALUES('";
            cadenaSql += empId + "', '";
            cadenaSql += empCedula + "', '";
            cadenaSql += empNombre + "', '";
            cadenaSql += empFechaEntrada.ToString() + "')";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Eliminar(string empId)
        {
            conexion.Open();
            string cadenaSql = "DELETE FROM \"Empleados\" WHERE \"empId\" = " + empId;
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string empId, string empCedula, string empNombre, DateTime empFechaEntrada)
        {
            conexion.Open();
            cadenaSql = null;
            cadenaSql += "UPDATE \"Empleados\" SET ";
            cadenaSql += "\"empCedula\" = '" + empCedula + "', ";
            cadenaSql += "\"empNombre\" = '" + empNombre + "', ";
            cadenaSql += "\"empFechaEntrada\" = '" + empFechaEntrada.ToString() + "' ";
            cadenaSql += "WHERE \"empId\" = '" + empId + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public int ValidarRelacionados(string empCedula)
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"preCedula\" FROM \"PrestamosEmpleados\" WHERE \"preCedula\" = '{0}' ";
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(cadenaSql, empCedula), conexion);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            int nroFilas = ds.Tables["tabla"].Rows.Count;

            cadenaSql = null;
            cadenaSql += "SELECT \"regCedula\" FROM \"RegistroVacaciones\" WHERE \"regCedula\" = '{0}' ";
            NpgsqlCommand cmdRV = new NpgsqlCommand(string.Format(cadenaSql, empCedula), conexion);
            NpgsqlDataAdapter daRV = new NpgsqlDataAdapter(cmdRV);
            ds = new DataSet();
            daRV.Fill(ds, "tabla");
            nroFilas += ds.Tables["tabla"].Rows.Count;
            conexion.Close();
            return nroFilas;
        }

    }
}
