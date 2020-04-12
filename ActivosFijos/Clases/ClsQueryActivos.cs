using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace ActivosFijos.Clases
{
    class ClsQueryActivos
    {
        readonly SQLiteConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public object CmbArea { get; private set; }
        public object CmbPropietarios { get; private set; }

        public class Areas
        {
            public int AreId { get; set; }
            public string AreNombre { get; set; }
        }

        public class Propietarios
        {
            public int ProId { get; set; }
            public string ProNombre { get; set; }
        }

        public DataTable MostrarDatos()
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT Activos.actId AS ActivoId, Activos.actArchivo AS Archivo, Activos.areId AS AreaId, ";
            cadenaSql += "Areas.areNombre AS NombreDelArea, Activos.actNombre AS NombreDelActivo, Activos.actObservaciones AS Observaciones, ";
            cadenaSql += "Activos.actValorBase0 AS ValorBase0, Activos.actValorBaseIva AS ValorBaseIva, ";
            cadenaSql += "Activos.actPctjeIva AS PctjeIva, Activos.actValorIva AS ValorIva, Activos.actValorTotal AS ValorTotal, ";
            cadenaSql += "Activos.actFechaCompra AS FechaCompra, Activos.empId AS PropId, Empresas.empNombre AS Empresa, ";
            cadenaSql += "Activos.actEstado AS Estado ";
            cadenaSql += "FROM Activos ";
            cadenaSql += "INNER JOIN Areas ON Activos.areId = Areas.areId ";
            cadenaSql += "INNER JOIN Empresas ON Activos.empId = Empresas.empId ";
            cadenaSql += "ORDER BY Activos.actNombre";
            SQLiteCommand cmd = new SQLiteCommand(cadenaSql, conexion);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public static List<Areas> CargarComboBoxAreas()
        {
            List<Areas> lista = new List<Areas>();
            SQLiteConnection conexion = ClsObtenerConexion.Conexion();
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT areId, areId||' - '||areNombre AS NombreDelArea ";
            cadenaSql += "FROM Areas ";
            cadenaSql += "ORDER BY substr(areNombre, instr(areNombre, ' - '))";
            SQLiteCommand cmd = new SQLiteCommand(cadenaSql, conexion);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Areas pAreas = new Areas
                {
                    AreId = Convert.ToInt32(dr[0]),
                    AreNombre = Convert.ToString(dr[1])
                };
                lista.Add(pAreas);
            }
            dr.Close();
            conexion.Close();
            //cb.SelectedIndex = 0;
            return lista;
        }

        public static List<Propietarios> CargarComboBoxPropietarios()
        {
            List<Propietarios> lista = new List<Propietarios>();
            SQLiteConnection conexion = ClsObtenerConexion.Conexion();
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT empId, empId||' - '||empNombre AS NombreDeLaEmpresa ";
            cadenaSql += "FROM Empresas ";
            //cadenaSql += "ORDER BY substr(proNombre, instr(proNombre, ' - '))";
            SQLiteCommand cmd = new SQLiteCommand(cadenaSql, conexion);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Propietarios pPropietarios = new Propietarios
                {
                    ProId = Convert.ToInt32(dr[0]),
                    ProNombre = Convert.ToString(dr[1])
                };
                lista.Add(pPropietarios);
            }
            dr.Close();
            conexion.Close();
            //cb.SelectedIndex = 1;
            return lista;
        }

        public DataTable Buscar(string nombre, string area)
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT Activos.actId AS ActivoId, Activos.actArchivo AS Archivo, Activos.areId AS AreaId, ";
            cadenaSql += "Areas.areNombre AS NombreDelArea, Activos.actNombre AS NombreDelActivo, Activos.actObservaciones AS Observaciones, ";
            cadenaSql += "Activos.actValorBase0 AS ValorBase0, Activos.actValorBaseIva AS ValorBaseIva, ";
            cadenaSql += "Activos.actPctjeIva AS PctjeIva, Activos.actValorIva AS ValorIva, Activos.actValorTotal AS ValorTotal, ";
            cadenaSql += "Activos.actFechaCompra AS FechaCompra, Activos.empId AS PropId, Empresa.empNombre AS Empresa ";
            cadenaSql += "Activos.actEstado AS Estado ";
            cadenaSql += "FROM Activos ";
            cadenaSql += "INNER JOIN Areas ON Activos.areId = Areas.areId ";
            cadenaSql += "INNER JOIN Empresas ON Activos.empId = Empresas.empId ";
            if (nombre != "" && area != "0")
            {
                cadenaSql += "WHERE Activos.actNombre LIKE '%{0}%' AND Activos.areId LIKE '{1}' ";
            }
            else
            {
                if (nombre == "" && area != "0")
                {
                    cadenaSql += "WHERE Activos.areId LIKE '{1}' ";
                }
                else
                {
                    cadenaSql += "WHERE Activos.actNombre LIKE '%{0}%' ";
                }
            }
            cadenaSql += "ORDER BY Activos.actNombre";
            SQLiteCommand cmd = new SQLiteCommand(string.Format(cadenaSql, nombre, area), conexion);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public string SecuenciaId()
        {
            conexion.Open();
            string secId = null;
            SQLiteCommand cmd = new SQLiteCommand(string.Format("SELECT max(actId) FROM Activos"), conexion);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                secId = dr[0].ToString();
            }
            dr.Close();
            conexion.Close();
            return secId;
        }

        public bool Insertar(string actId, string actArchivo, string areId, string actNombre, string actObservaciones, double actValorBase0, double actValorBaseIva, double actPctjeIva, double actValorIva, double actValorTotal, DateTime actFechaCompra, string proId, string actEstado)
        {
            conexion.Open();
            SQLiteCommand cmd = new SQLiteCommand(string.Format("INSERT INTO Activos VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')", new string[] { actId, actArchivo, areId, actNombre, actObservaciones, actValorBase0.ToString(), actValorBaseIva.ToString(), actPctjeIva.ToString(), actValorIva.ToString(), actValorTotal.ToString(), actFechaCompra.ToString().Substring(0,10), proId.ToString(), actEstado.ToString()} ), conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Eliminar(string actId)
        {
            conexion.Open();
            SQLiteCommand cmd = new SQLiteCommand(string.Format("DELETE FROM Activos WHERE actId = '{0}'", actId), conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string actId, string archivo, string areId, string actNombre, string actObservaciones, double actValorBase0, double actValorBaseIva, double actPctjeIva, double actValorIva, double actValorTotal, DateTime actFechaCompra, string proId, string actEstado)
        {
            conexion.Open();
            string cadenaSql = "UPDATE Activos SET actArchivo = '{1}', areId = '{2}', actNombre = '{3}', actObservaciones = '{4}', actValorBase0 = '{5}', actValorBaseIva = '{6}', actPctjeIva = '{7}', actValorIva = '{8}', actValorTotal = '{9}', actFechaCompra = '{10}', proId = '{11}', actEstado = '{12}' WHERE actId = '{0}'";
            SQLiteCommand cmd = new SQLiteCommand(string.Format(cadenaSql, new string[] { actId, archivo, areId, actNombre, actObservaciones, actValorBase0.ToString(), actValorBaseIva.ToString(), actPctjeIva.ToString(), actValorIva.ToString(), actValorTotal.ToString(), actFechaCompra.ToString().Substring(0,10), proId.ToString(), actEstado.ToString()}), conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public void LimpiarCampos(Control ctr, GroupBox gb)
        {
            foreach (var txt in ctr.Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
                else if (txt is ComboBox)
                    ((ComboBox)txt).SelectedIndex = 0;
            }
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                    ((TextBox)combo).Clear();
                else if (combo is ComboBox)
                    ((ComboBox)combo).SelectedIndex = 0;
            }
        }
    }
}
