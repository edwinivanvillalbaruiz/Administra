namespace Formularios
{

    #region Librerias
    //@Javier Villalba Espinosa
    //@Junio 18 2020
    using Conexiones;
    using DevExpress.XtraEditors;
    using System;
    using System.Data;
    using System.Runtime.Remoting.Messaging;
    using System.Text;
    #endregion
    public class NegConsulta
    {
        #region Propiedades
        private decimal decCuentaError = 0;
        private StringBuilder stb = new StringBuilder();
        public Datos datos = new Datos();
        public DataTable DtProyecto = new DataTable();
        private MysqlContext mysql;
        public event DlgtStringExit Error_Event_Consulta;
        #endregion Propiedades

        #region Constructor
        public NegConsulta(CadenaConexionMysql cadena)
        {
            mysql = new MysqlContext(cadena);
            mysql.EventDataErrorTableMysql += Mysql_EventDataErrorTableMysql;
        }

        #endregion Constructor

        #region Disparadores
        private void Mysql_EventDataErrorTableMysql(string mensaje, DataTable dataTable)
        {
            Error_Event_Consulta(mensaje);
        }
        #endregion Disparadores

        #region Metodos

        public DataTable DtMeses()
        {
            DataTable dtMeses = new DataTable();
            dtMeses.Columns.Add("Id", typeof(string));
            dtMeses.Columns.Add("Mes", typeof(string));
            dtMeses.Rows.Add("01", "Enero");
            dtMeses.Rows.Add("02", "Febrero");
            dtMeses.Rows.Add("03", "Marzo");
            dtMeses.Rows.Add("04", "Abril");
            dtMeses.Rows.Add("05", "Mayo");
            dtMeses.Rows.Add("06", "Junio");
            dtMeses.Rows.Add("07", "Julio");
            dtMeses.Rows.Add("08", "Agosto");
            dtMeses.Rows.Add("09", "Septiembre");
            dtMeses.Rows.Add("10", "Octubre");
            dtMeses.Rows.Add("11", "Noviembre");
            dtMeses.Rows.Add("12", "Diciembre");
            return dtMeses;
        }

        public DataTable DtAño()
        {
            DataTable dtAño = new DataTable();
            dtAño.Columns.Add("Año", typeof(string));
            dtAño.Rows.Add( "2019");
            dtAño.Rows.Add("2020");
            dtAño.Rows.Add("2021");            
            dtAño.Rows.Add("2022");
            return dtAño;             
        }

        public DataTable CnsEstadoCuenta()
        {
            decCuentaError = 0;
            stb.Clear();
            DataTable dt = new DataTable();

            if (string.IsNullOrEmpty(datos.BaseDatos))
            {
                decCuentaError = decCuentaError + 1;
                stb.AppendLine("Seleccione Proyecto");
            }
            if (string.IsNullOrEmpty(datos.IdAdjudicacion))
            {
                decCuentaError = decCuentaError + 1;
                stb.AppendLine("Seleccione Adjudicacion");
            }

            if (decCuentaError > 0)
            {
                Error_Event_Consulta(stb.ToString());
                return dt;
            }
            else
            {
                return CnsDuoStringCartera("EstadoCuenta", datos.BaseDatos, datos.IdAdjudicacion);
            }

        }

        public DataTable CnsInformeGeneral()
        {
            return CnsProcedureFechas("InfoGeneral");
        }

        public DataTable CnsGastos()
        {
            return CnsProcedureFechas("InfoGastos");
        }

        public DataTable CnsLotes()
        {
            return mysql.MtdDataTableAdapterProce("CnsLotes");
        }

        public DataTable CnsIngresos()
        {
            return CnsProcedureFechas("InfoIngresos");

        }

        public DataTable CnsCrucesCuentas()
        {
            return CnsProcedureFechas("CruceCuentas");
        }

        private DataTable CnsProcedureFechas(string StrNombreProcedimiento)
        {
            DataTable dt = new DataTable();
            validar();
            if (decCuentaError > 0)
            {
                Error_Event_Consulta(stb.ToString());
            }
            else

            {
                string[] Parametros = { "VarFechaInicial", "VarFechaFinal" };
                object[] ObjParmaetros = { datos.FechaInicio, datos.FechaFinal };
                dt = mysql.MtdDataTableAdapterProce(StrNombreProcedimiento, Parametros, ObjParmaetros);
            }
            return dt;
        }

        public DataTable CnsCnsCartera(string StrNombre)
        {
            string[] Parametros = { "StrNombre" };
            object[] ObjParmaetros = { StrNombre };
            return mysql.MtdDataTableAdapterProce("CnsCartera", Parametros, ObjParmaetros);
        }

        public DataTable CnsDuoStringCartera(string StrNombre, string StrBaseDatos, string StrVar)
        {
            string[] Parametros = { "StrNombre", "StrBaseDatos", "StrVar" };
            object[] ObjParmaetros = { StrNombre, StrBaseDatos, StrVar };
            return mysql.MtdDataTableAdapterProce("CnsDuoStringCartera", Parametros, ObjParmaetros);
        }

        public DataTable CnsCarteraFecha(string StrNombre)
        {
            DataTable dt = new DataTable();
            validar();
            if (decCuentaError > 0)
            {
                Error_Event_Consulta(stb.ToString());
            }
            else

            {
                string[] Parametros = { "StrNombre", "VarFechaInicial", "VarFechaFinal" };
                object[] ObjParmaetros = { StrNombre, datos.FechaInicio, datos.FechaFinal };
                dt = mysql.MtdDataTableAdapterProce("CnsCarteraFecha", Parametros, ObjParmaetros);
            }
            return dt;
        }

        public DataTable CnsInformePrespuesto()
        {
            DataTable dt = new DataTable();
            validarPeriodo();
            if (decCuentaError > 0)
            {
                Error_Event_Consulta(stb.ToString());
            }
            else
            {
                string[] Parametros = { "VarPeriodo" };
                object[] ObjParmaetros = {  datos.Año+datos.Mes };
                dt = mysql.MtdDataTableAdapterProce("InfPresupuesto", Parametros, ObjParmaetros);
            }
            return dt;
        }

        public DataTable CnsspCargarCombo(string v_NombreTabla, int v_IdSoftware)
        {
            string[] Parametros = { "v_NombreTabla", "v_IdSoftware" };
            object[] ObjParmaetros = { v_NombreTabla, v_IdSoftware };
            return mysql.MtdDataTableAdapterProce("spCargarCombo", Parametros, ObjParmaetros);
        }

        private void validar()
        {
            decCuentaError = 0;
            stb.Clear();

            if (datos.FechaInicio == null || datos.FechaInicio == Convert.ToDateTime("1/01/0001"))
            {
                decCuentaError = decCuentaError + 1;
                stb.AppendLine("Seleccione la Fecha Inicial");
            }
            if (datos.FechaFinal == null || datos.FechaFinal == Convert.ToDateTime("1/01/0001"))
            {
                decCuentaError = decCuentaError + 1;
                stb.AppendLine("Seleccione la Fecha Final");
            }

            if (datos.FechaFinal < datos.FechaInicio)
            {
                decCuentaError = decCuentaError + 1;
                stb.AppendLine("Fecha Final No puede ser mayor fecha Inicial");
            }
        }

        private void validarPeriodo()
        {
            decCuentaError = 0;
            stb.Clear();

            if(string.IsNullOrEmpty(datos.Año))
            {
                decCuentaError = decCuentaError + 1;
                stb.AppendLine("Seleccione El Año");
            }

            if (string.IsNullOrEmpty(datos.Mes))
            {
                decCuentaError = decCuentaError + 1;
                stb.AppendLine("Seleccione El Mes");
            }
        }


        #endregion Metodos
    }
}