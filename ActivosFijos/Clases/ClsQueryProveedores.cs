using System.Data;
using Npgsql;

namespace ActivosFijos.Clases
{
    class ClsQueryProveedores
    {
        readonly NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"proId\" AS ProId, \"proRuc\" AS Ruc,\"proNombre\" AS NombreDelProveedor ";
            cadenaSql += "FROM \"Proveedores\" ";
            cadenaSql += "ORDER BY \"proNombre\" ";
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
            cadenaSql += "SELECT \"proId\" AS ProId, \"proRuc\" AS Ruc,\"proNombre\" AS NombreDelProveedor ";
            cadenaSql += "FROM \"Proveedores\" ";
            if (nombre != "")
            {
                cadenaSql += "WHERE \"proNombre\" ILIKE '%{0}%' ";
            }
            cadenaSql += "ORDER BY \"proNombre\" ";
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
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("SELECT max(\"proId\") FROM \"Proveedores\" "), conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                secId = dr[0].ToString();
            }
            dr.Close();
            conexion.Close();
            return secId;
        }

        public bool Insertar(string proId, string proRuc, string proNombre)
        {
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("INSERT INTO \"Proveedores\" VALUES('{0}', '{1}', '{2}')", new string[] { proId, proRuc, proNombre}), conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Eliminar(string proId)
        {
            conexion.Open();
            string cadenaSql = "DELETE FROM \"Proveedores\" WHERE \"proId\" = " + proId;
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string proId, string proRuc, string proNombre)
        {
            conexion.Open();
            string cadenaSql = "UPDATE \"Proveedores\" SET \"proRuc\" = '" + proRuc + "', \"proNombre\" = '" + proNombre + "' WHERE \"proId\" = " + proId;
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
