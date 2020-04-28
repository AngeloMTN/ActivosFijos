using System.Data;
using Npgsql;

namespace ActivosFijos.Clases
{
    class ClsQueryCustodios
    {
        readonly NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"cusId\" AS CusId, \"cusCedula\" AS Cedula, \"cusNombre\" AS NombreDelCustodios ";
            cadenaSql += "FROM \"Custodios\" ";
            cadenaSql += "ORDER BY \"cusNombre\" ";
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
            cadenaSql += "SELECT \"cusId\" AS CusId, \"cusCedula\" AS Cedula, \"cusNombre\" AS NombreDelCustodios ";
            cadenaSql += "FROM \"Custodios\" ";
            if (nombre != "")
            {
                cadenaSql += "WHERE \"cusNombre\" ILIKE '%{0}%' ";
            }
            cadenaSql += "ORDER BY \"cusNombre\" ";
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
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("SELECT max(\"cusId\") FROM \"Custodios\" "), conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                secId = dr[0].ToString();
            }
            dr.Close();
            conexion.Close();
            return secId;
        }

        public bool Insertar(string cusId, string cusCedula, string cusNombre)
        {
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("INSERT INTO \"Custodios\" VALUES('{0}', '{1}', '{2}')", new string[] { cusId, cusCedula, cusNombre}), conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Eliminar(string cusId)
        {
            conexion.Open();
            string cadenaSql = "DELETE FROM \"Custodios\" WHERE \"cusId\" = " + cusId;
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string cusId, string cusCedula, string cusNombre)
        {
            conexion.Open();
            string cadenaSql = "UPDATE \"Custodios\" SET \"cusCedula\" = '" + cusCedula + "', \"cusNombre\" = '" + cusNombre + "' WHERE \"cusId\" = " + cusId;
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
