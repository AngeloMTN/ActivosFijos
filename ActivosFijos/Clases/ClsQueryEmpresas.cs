using System.Data;
using Npgsql;

namespace ActivosFijos.Clases
{
    class ClsQueryEmpresas
    {
        readonly NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"empId\" AS Id, \"empNombre\" AS NombreDeLaEmpresa ";
            cadenaSql += "FROM \"Empresas\" ";
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
            cadenaSql += "SELECT \"empId\" AS Id, \"empNombre\" AS NombreDeLaEmpresa ";
            cadenaSql += "FROM \"Empresas\" ";
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
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("SELECT max(empId) FROM Empresas"), conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                secId = dr[0].ToString();
            }
            dr.Close();
            conexion.Close();
            return secId;
        }

        public bool Insertar(string empId, string empNombre)
        {
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("INSERT INTO Empresas VALUES('{0}', '{1}')", new string[] { empId, empNombre}), conexion);
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
            string cadenaSql = "DELETE FROM Empresas WHERE empId = " + empId;
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string empId, string empNombre)
        {
            conexion.Open();
            string cadenaSql = "UPDATE Empresas SET empNombre = '" + empNombre + "' WHERE empId = " + empId;
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }
    }
}
