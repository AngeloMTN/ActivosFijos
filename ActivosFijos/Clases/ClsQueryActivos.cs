using System.Data;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using Npgsql;
using System.IO;
using System.Linq;

namespace ActivosFijos.Clases
{
    class ClsQueryActivos
    {
        string cadenaSql;
        readonly NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public object CmbArea { get; private set; }
        public object CmbPropietarios { get; private set; }

        public class Areas
        {
            public int AreId { get; set; }
            public string AreNombre { get; set; }
        }

        public class PlanCuentas
        {
            public int PctId { get; set; }
            public string PctNombre { get; set; }
        }

        public class Proveedores
        {
            public int ProId { get; set; }
            public string ProNombre { get; set; }
        }

        public class Custodios
        {
            public int CusId { get; set; }
            public string CusNombre { get; set; }
        }

        public class Empresas
        {
            public int EmpId { get; set; }
            public string EmpNombre { get; set; }
        }

        public DataTable MostrarDatos()
        {
            conexion.Open();
            cadenaSql = null;
            cadenaSql += "SELECT ";
            cadenaSql += "\"Activos\".\"actId\" AS Activo, ";
            cadenaSql += "trim(\"Activos\".\"actCodBarra\") AS CodBarra, ";
            cadenaSql += "\"Activos\".\"actArchivo\" AS Archivo, ";
            cadenaSql += "trim(\"Activos\".\"actNombre\") AS NombreDelActivo, ";
            cadenaSql += "trim(\"Activos\".\"actObservaciones\") AS Observaciones, ";
            cadenaSql += "\"Activos\".\"areId\" AS Id, ";
            cadenaSql += "trim(\"Areas\".\"areNombre\") AS NombreDelArea, ";
            cadenaSql += "trim(\"Activos\".\"pctCuenta\") AS CtaNro, ";
            cadenaSql += "trim(\"PlanCuentas\".\"pctNombre\") AS CuentaNombre, ";
            cadenaSql += "\"Activos\".\"cusCedula\" AS Cedula, ";
            cadenaSql += "trim(\"Custodios\".\"cusNombre\") AS NombreCustodio, ";
            cadenaSql += "\"Activos\".\"actFactura\" AS NumFactura, ";
            cadenaSql += "\"Activos\".\"actFechaCompra\" AS FechaCompra, ";
            cadenaSql += "trim(\"Activos\".\"proRuc\") AS Ruc, ";
            cadenaSql += "trim(\"Proveedores\".\"proNombre\") AS NombreProveedor, ";
            cadenaSql += "\"Activos\".\"actValorBase0\" AS ValorBase0, ";
            cadenaSql += "\"Activos\".\"actValorBaseIva\" AS ValorBaseIva, ";
            cadenaSql += "\"Activos\".\"actPctjeIva\" AS PctjeIva, ";
            cadenaSql += "\"Activos\".\"actValorIva\" AS ValorIva, ";
            cadenaSql += "\"Activos\".\"actValorTotal\" AS ValorTotal, ";
            cadenaSql += "\"Activos\".\"actDepreDiaria\" AS DepreDiaria, ";
            cadenaSql += "\"Activos\".\"actDepreAcumulada\" AS DepreAcumulada, ";
            cadenaSql += "\"Activos\".\"actValorActual\" AS ValorActual, ";
            cadenaSql += "\"Activos\".\"actFinVidaUtil\" AS FinVidaUtil, ";
            cadenaSql += "\"Activos\".\"actFechaCorteDepre\" AS FechaCorteDepre, ";
            cadenaSql += "\"Activos\".\"actDepreciable\" AS Depreciable, ";
            cadenaSql += "\"Activos\".\"actEstado\" AS Estado, ";
            cadenaSql += "\"Activos\".\"empId\" AS PropId, ";
            cadenaSql += "trim(\"Empresas\".\"empNombre\") AS Empresa ";
            cadenaSql += "FROM \"Activos\" ";
            cadenaSql += "INNER JOIN \"Areas\" ON \"Activos\".\"areId\" = \"Areas\".\"areId\" ";
            cadenaSql += "INNER JOIN \"Empresas\" ON \"Activos\".\"empId\" = \"Empresas\".\"empId\" ";
            cadenaSql += "INNER JOIN \"Proveedores\" ON \"Activos\".\"proRuc\" = \"Proveedores\".\"proRuc\" ";
            cadenaSql += "INNER JOIN \"Custodios\" ON \"Activos\".\"cusCedula\" = \"Custodios\".\"cusCedula\" ";
            cadenaSql += "INNER JOIN \"PlanCuentas\" ON \"Activos\".\"pctCuenta\" = \"PlanCuentas\".\"pctCuenta\" ";
            //cadenaSql += "ORDER BY \"Activos\".\"actNombre\" ";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public static List<Areas> CargarComboBoxAreas()
        {
            List<Areas> lista = new List<Areas>();
            NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"areId\", \"areId\"||' - '||\"areNombre\" AS NombreDelArea ";
            cadenaSql += "FROM \"Areas\" ";
            cadenaSql += "ORDER BY substr(\"areNombre\", POSITION(' - ' IN \"areNombre\"))";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
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

        public static List<PlanCuentas> CargarComboBoxPlanCuentas()
        {
            List<PlanCuentas> lista = new List<PlanCuentas>();
            NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"pctId\",\"pctCuenta\"||' - '||\"pctNombre\"||' - ['||\"pctVidaUtilAnios\"||'] ' AS NombreDelArea ";
            cadenaSql += "FROM \"PlanCuentas\" ";
            cadenaSql += "ORDER BY substr(\"pctNombre\", POSITION(' - ' IN \"pctNombre\"))";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PlanCuentas pPlanCuentas = new PlanCuentas
                {
                    PctId = Convert.ToInt32(dr[0]),
                    PctNombre = Convert.ToString(dr[1])
                };
                lista.Add(pPlanCuentas);
            }
            dr.Close();
            conexion.Close();
            //cb.SelectedIndex = 0;
            return lista;
        }

        public static List<Custodios> CargarComboBoxCustodios()
        {
            List<Custodios> lista = new List<Custodios>();
            NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"cusId\", \"cusCedula\"||' - '||\"cusNombre\" AS NombreDelArea ";
            cadenaSql += "FROM \"Custodios\" ";
            cadenaSql += "ORDER BY substr(\"cusNombre\", POSITION(' - ' IN \"cusNombre\"))";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Custodios pCustodios = new Custodios
                {
                    CusId = Convert.ToInt32(dr[0]),
                    CusNombre = Convert.ToString(dr[1])
                };
                lista.Add(pCustodios);
            }
            dr.Close();
            conexion.Close();
            //cb.SelectedIndex = 0;
            return lista;
        }

        public static List<Proveedores> CargarComboBoxProveedores()
        {
            List<Proveedores> lista = new List<Proveedores>();
            NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"proId\", \"proRuc\"||' - '||\"proNombre\" AS NombreDelArea ";
            cadenaSql += "FROM \"Proveedores\" ";
            cadenaSql += "ORDER BY substr(\"proNombre\", POSITION(' - ' IN \"proNombre\"))";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Proveedores pProveedores = new Proveedores
                {
                    ProId = Convert.ToInt32(dr[0]),
                    ProNombre = Convert.ToString(dr[1])
                };
                lista.Add(pProveedores);
            }
            dr.Close();
            conexion.Close();
            //cb.SelectedIndex = 0;
            return lista;
        }

        public static List<Empresas> CargarComboBoxEmpresas()
        {
            List<Empresas> lista = new List<Empresas>();
            NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"empId\", \"empId\"||' - '||\"empNombre\" AS NombreDeLaEmpresa ";
            cadenaSql += "FROM \"Empresas\" ";
            //cadenaSql += "ORDER BY substr(\"empNombre\", POSITION(' - ' IN \"empNombre\"))";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Empresas pEmpresas = new Empresas
                {
                    EmpId = Convert.ToInt32(dr[0]),
                    EmpNombre = Convert.ToString(dr[1])
                };
                lista.Add(pEmpresas);
            }
            dr.Close();
            conexion.Close();
            //cb.SelectedIndex = 1;
            return lista;
        }

        public DataTable Buscar(string nombre, string area)
        {
            conexion.Open();
            cadenaSql = null;
            cadenaSql += "SELECT ";
            cadenaSql += "\"Activos\".\"actId\" AS Activo, ";
            cadenaSql += "trim(\"Activos\".\"actCodBarra\") AS CodBarra, ";
            cadenaSql += "\"Activos\".\"actArchivo\" AS Archivo, ";
            cadenaSql += "trim(\"Activos\".\"actNombre\") AS NombreDelActivo, ";
            cadenaSql += "trim(\"Activos\".\"actObservaciones\") AS Observaciones, ";
            cadenaSql += "\"Activos\".\"areId\" AS Id, ";
            cadenaSql += "trim(\"Areas\".\"areNombre\") AS NombreDelArea, ";
            cadenaSql += "trim(\"Activos\".\"pctCuenta\") AS CtaNro, ";
            cadenaSql += "trim(\"PlanCuentas\".\"pctNombre\") AS CuentaNombre, ";
            cadenaSql += "\"Activos\".\"cusCedula\" AS Cedula, ";
            cadenaSql += "trim(\"Custodios\".\"cusNombre\") AS NombreCustodio, ";
            cadenaSql += "\"Activos\".\"actFactura\" AS NumFactura, ";
            cadenaSql += "\"Activos\".\"actFechaCompra\" AS FechaCompra, ";
            cadenaSql += "trim(\"Activos\".\"proRuc\") AS Ruc, ";
            cadenaSql += "trim(\"Proveedores\".\"proNombre\") AS NombreProveedor, ";
            cadenaSql += "\"Activos\".\"actValorBase0\" AS ValorBase0, ";
            cadenaSql += "\"Activos\".\"actValorBaseIva\" AS ValorBaseIva, ";
            cadenaSql += "\"Activos\".\"actPctjeIva\" AS PctjeIva, ";
            cadenaSql += "\"Activos\".\"actValorIva\" AS ValorIva, ";
            cadenaSql += "\"Activos\".\"actValorTotal\" AS ValorTotal, ";
            cadenaSql += "\"Activos\".\"actDepreDiaria\" AS DepreDiaria, ";
            cadenaSql += "\"Activos\".\"actDepreAcumulada\" AS DepreAcumulada, ";
            cadenaSql += "\"Activos\".\"actValorActual\" AS ValorActual, ";
            cadenaSql += "\"Activos\".\"actFinVidaUtil\" AS FinVidaUtil, ";
            cadenaSql += "\"Activos\".\"actFechaCorteDepre\" AS FechaCorteDepre, ";
            cadenaSql += "\"Activos\".\"actDepreciable\" AS Depreciable, ";
            cadenaSql += "\"Activos\".\"actEstado\" AS Estado, ";
            cadenaSql += "\"Activos\".\"empId\" AS PropId, ";
            cadenaSql += "trim(\"Empresas\".\"empNombre\") AS Empresa ";
            cadenaSql += "FROM \"Activos\" ";
            cadenaSql += "INNER JOIN \"Areas\" ON \"Activos\".\"areId\" = \"Areas\".\"areId\" ";
            cadenaSql += "INNER JOIN \"Empresas\" ON \"Activos\".\"empId\" = \"Empresas\".\"empId\" ";
            cadenaSql += "INNER JOIN \"Proveedores\" ON \"Activos\".\"proRuc\" = \"Proveedores\".\"proRuc\" ";
            cadenaSql += "INNER JOIN \"Custodios\" ON \"Activos\".\"cusCedula\" = \"Custodios\".\"cusCedula\" ";
            cadenaSql += "INNER JOIN \"PlanCuentas\" ON \"Activos\".\"pctCuenta\" = \"PlanCuentas\".\"pctCuenta\" ";
            if (nombre != "" && area != "0")
            {
                cadenaSql += "WHERE \"Activos\".\"actNombre\" ILIKE '%{0}%' AND \"Activos\".\"areId\" ILIKE '{1}' ";
            }
            else
            {
                if (nombre == "" && area != "0")
                {
                    cadenaSql += "WHERE \"Activos\".\"areId\" ILIKE '{1}' ";
                }
                else
                {
                    cadenaSql += "WHERE \"Activos\".\"actNombre\" ILIKE '%{0}%' ";
                }
            }
            cadenaSql += "ORDER BY \"Activos\".\"actNombre\" ";
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(cadenaSql, nombre, area), conexion);
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
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("SELECT max(\"actId\") FROM \"Activos\""), conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                secId = dr[0].ToString();
            }
            dr.Close();
            conexion.Close();
            return secId;
        }

        public string SecuenciaArchivo(string rutaArchivo)
        {
            string nombreArchivo = null;
            Int32 secNewArch = 0;

            List<String> lista = new List<String>();
            DirectoryInfo di = new DirectoryInfo(rutaArchivo);
            foreach (var fi in di.GetFiles())
            {
                lista.Add(fi.Name.Substring(1,4));
            }
            lista.Sort();
            if (lista.Count() <= 0)
                secNewArch += 1;
            else
                secNewArch = Convert.ToInt32(lista[lista.Count - 1]) + 1;

            nombreArchivo = "A" + String.Format("{0:0000}", secNewArch);
            return nombreArchivo;
        }

        public bool Insertar(string actId,
                             string actCodBarra,
                             string actArchivo,
                             string actNombre,
                             string actObservaciones,
                             string areId,
                             string pctCuenta,
                             string cusCedula,
                             string actFactura,
                             DateTime actFechaCompra,
                             string proRuc,
                             double actValorBase0,
                             double actValorBaseIva,
                             double actPctjeIva,
                             double actValorIva,
                             double actValorTotal,
                             double actDepreDiaria,
                             double actDepreAcumulada,
                             double actValorActual,
                             DateTime actFinVidaUtil,
                             DateTime actFechaCorteDepre,
                             string actDepreciable,
                             string actEstado,
                             string empId,
                             string actVidaUtilAnios)
        {
            conexion.Open();
            cadenaSql = null;
            cadenaSql += "INSERT INTO \"Activos\" (";
            cadenaSql += "\"actId\", ";
            cadenaSql += "\"actCodBarra\", ";
            cadenaSql += "\"actArchivo\", ";
            cadenaSql += "\"actNombre\", ";
            cadenaSql += "\"actObservaciones\", ";
            cadenaSql += "\"areId\", ";
            cadenaSql += "\"pctCuenta\", ";
            cadenaSql += "\"cusCedula\", ";
            cadenaSql += "\"actFactura\", ";
            cadenaSql += "\"actFechaCompra\", ";
            cadenaSql += "\"proRuc\", ";
            cadenaSql += "\"actValorBase0\", ";
            cadenaSql += "\"actValorBaseIva\", ";
            cadenaSql += "\"actPctjeIva\", ";
            cadenaSql += "\"actValorIva\", ";
            cadenaSql += "\"actValorTotal\", ";
            cadenaSql += "\"actDepreDiaria\", ";
            cadenaSql += "\"actDepreAcumulada\", ";
            cadenaSql += "\"actValorActual\", ";
            cadenaSql += "\"actFinVidaUtil\", ";
            cadenaSql += "\"actFechaCorteDepre\", ";
            cadenaSql += "\"actDepreciable\", ";
            cadenaSql += "\"actEstado\", ";
            cadenaSql += "\"empId\" ";
            cadenaSql += ")";
            cadenaSql += "VALUES('";
            cadenaSql += actId + "', '";
            cadenaSql += actCodBarra + "', '";
            cadenaSql += actArchivo + "', '";
            cadenaSql += actNombre + "', '";
            cadenaSql += actObservaciones + "', '";
            cadenaSql += areId + "', '";
            cadenaSql += pctCuenta + "', '";
            cadenaSql += cusCedula + "', '";
            cadenaSql += actFactura + "', '";
            cadenaSql += actFechaCompra.ToString() + "', '";
            cadenaSql += proRuc + "', '";
            cadenaSql += actValorBase0.ToString() + "', '";
            cadenaSql += actValorBaseIva.ToString() + "', '";
            cadenaSql += actPctjeIva.ToString() + "', '";
            cadenaSql += actValorIva.ToString() + "', '";
            cadenaSql += actValorTotal.ToString() + "', '";
            cadenaSql += actDepreDiaria.ToString() + "', '";
            cadenaSql += actDepreAcumulada.ToString() + "', '";
            cadenaSql += actValorActual.ToString() + "', '";
            cadenaSql += actFinVidaUtil.ToString() + "', '";
            cadenaSql += actFechaCorteDepre.ToString() + "', '";
            cadenaSql += actDepreciable + "', '";
            cadenaSql += actEstado + "', '";
            cadenaSql += empId + "')";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
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
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("DELETE FROM \"Activos\" WHERE \"actId\" = '{0}'", actId), conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string actId,
                               string actArchivo,
                               string actNombre,
                               string actObservaciones,
                               string areId,
                               string pctCuenta,
                               string cusCedula,
                               string actFactura,
                               DateTime actFechaCompra,
                               string proRuc,
                               double actValorBase0,
                               double actValorBaseIva,
                               double actPctjeIva,
                               double actValorIva,
                               double actValorTotal,
                               double actDepreDiaria,
                               double actDepreAcumulada,
                               double actValorActual,
                               string actDepreciable,
                               string actEstado,
                               string empId)
        {
            conexion.Open();
            cadenaSql = null;
            cadenaSql += "UPDATE \"Activos\" SET ";
            cadenaSql += "\"actArchivo\" = '" + actArchivo + "', ";
            cadenaSql += "\"actNombre\" = '" + actNombre + "', ";
            cadenaSql += "\"actObservaciones\" = '" + actObservaciones + "', ";
            cadenaSql += "\"areId\" = '" + areId + "', ";
            cadenaSql += "\"pctCuenta\" = '" + pctCuenta + "', ";
            cadenaSql += "\"cusCedula\" = '" + cusCedula + "', ";
            cadenaSql += "\"actFactura\" = '" + actFactura + "', ";
            cadenaSql += "\"actFechaCompra\" = '" + actFechaCompra.ToString() + "', ";
            cadenaSql += "\"proRuc\" = '" + proRuc + "', ";
            cadenaSql += "\"actValorBase0\" = '" + actValorBase0.ToString() + "', ";
            cadenaSql += "\"actValorBaseIva\" = '" + actValorBaseIva.ToString() + "', ";
            cadenaSql += "\"actPctjeIva\" = '" + actPctjeIva.ToString() + "', ";
            cadenaSql += "\"actValorIva\" = '" + actValorIva.ToString() + "', ";
            cadenaSql += "\"actValorTotal\" = '" + actValorTotal.ToString() + "', ";
            cadenaSql += "\"actDepreDiaria\" = '" + actDepreDiaria.ToString() + "', ";
            cadenaSql += "\"actDepreAcumulada\" = '" + actDepreAcumulada.ToString() + "', ";
            cadenaSql += "\"actValorActual\" = '" + actValorActual.ToString() + "', ";
            cadenaSql += "\"actDepreciable\" = '" + actDepreciable + "', ";
            cadenaSql += "\"actEstado\" = '" + actEstado + "', ";
            cadenaSql += "\"empId\" = '" + empId + "' ";
            cadenaSql += "WHERE \"actId\" = '" + actId +"'";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
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

        public void Recalcular(DateTime fechaCorte)
        {
            string cadenaSql = null;

            conexion.Open();
            cadenaSql += "UPDATE \"Activos\" SET \"actFechaCorteDepre\" = '" + fechaCorte + "'; ";
            cadenaSql += "UPDATE \"Activos\" SET \"actVidaUtilMeses\" = 12 * \"pctVidaUtilAnios\"; ";
            cadenaSql += "UPDATE \"Activos\" SET \"actVidaUtilDias\" = \"actFinVidaUtil\" - \"actFechaCompra\"; ";
            cadenaSql += "UPDATE \"Activos\" SET \"actFinVidaUtil\" = (365 * \"pctVidaUtilAnios\") + \"actFechaCompra\"; ";
            cadenaSql += "UPDATE \"Activos\" SET \"actTiempoDepreDias\" = \"actFechaCorteDepre\" - \"actFechaCompra\"; ";
            cadenaSql += "UPDATE \"Activos\" SET \"actPorDepreDias\" = \"actVidaUtilDias\" - \"actTiempoDepreDias\"; ";
            cadenaSql += "UPDATE \"Activos\" SET \"actDepreDiaria\" = \"actValorTotal\" / \"actVidaUtilDias\"; ";
            cadenaSql += "UPDATE \"Activos\" SET \"actDepreAcumulada\" = \"actDepreDiaria\" * \"actTiempoDepreDias\"; ";
            cadenaSql += "UPDATE \"Activos\" SET \"actValorActual\" = \"actValorTotal\" - \"actDepreAcumulada\"; ";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion); 
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public string Calcular()
        {
            string cadenaSql = null;

            conexion.Open();
            string totales = "";
            cadenaSql += "SELECT ";
            cadenaSql += "ROUND(SUM(\"actValorTotal\"), 2) AS v1, ";
            cadenaSql += "ROUND(SUM(\"actDepreDiaria\"), 2) AS v2, ";
            cadenaSql += "ROUND(SUM(\"actDepreAcumulada\"), 2) AS v3, ";
            cadenaSql += "ROUND(SUM(\"actValorActual\"), 2) AS v3 ";
            cadenaSql += "FROM \"Activos\" ";
            cadenaSql += "WHERE \"actEstado\" = 'ACTIVO'";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                totales += dr[0].ToString() + "|";
                totales += dr[1].ToString() + "|";
                totales += dr[2].ToString() + "|";
                totales += dr[3].ToString() + "|";
            }
            dr.Close();
            conexion.Close();
            return totales;
        }

        public string BuscarArchivo(string arch)
        {
            conexion.Open();
            string rpt = "";
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("SELECT \"actArchivo\" FROM \"Activos\" WHERE \"actArchivo\" = '" + arch + "'"), conexion);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            da.Dispose();
            cmd.Dispose();
            conexion.Close();

            int filasRecuperadas = ds.Tables[0].Rows.Count;
            return filasRecuperadas == 0 ? "NoExiste" : rpt; ;
        }
    }
}
