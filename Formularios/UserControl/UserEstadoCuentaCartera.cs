using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class UserEstadoCuentaCartera : DevExpress.XtraEditors.XtraUserControl
    {
        #region Propiedades

        public NegConsulta Consultas = new NegConsulta(Operaciones.CadenaGeneral);
        private BindingSource bs = new BindingSource();
        private static UserEstadoCuentaCartera _instance;

        #endregion Propiedades

        #region Constructor
        public UserEstadoCuentaCartera()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            Consultas.Error_Event_Consulta += Consultas_Error_Event_Consulta;
            GrvProyecto.DataSource = Consultas.CnsspCargarCombo("Proyectos", 2);
            GrvProyecto.DisplayMember = "NombreProyecto";
            GrvProyecto.ValueMember = "Base_Datos";
            bs.DataSource = Consultas.datos;
            CmbAdjudicacion.DataBindings.Add("EditValue", bs, "IdAdjudicacion", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbProyecto.DataBindings.Add("EditValue", bs, "BaseDatos", true, DataSourceUpdateMode.OnPropertyChanged);
            SplashScreenManager.CloseForm();
        }
        #endregion

        #region Disparadores

        private void Consultas_Error_Event_Consulta(string mensaje)
        {
            XtraMessageBox.Show(mensaje, " Consultas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos
        public static UserEstadoCuentaCartera Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserEstadoCuentaCartera();
                return _instance;
            }
        }
        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(GrdGrilla, "ESTADO DE CUENTAS ADJUDICACION " + Consultas.datos.IdAdjudicacion.ToUpper());
        }
        private void BtnExporarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdGrilla);
        }
        private void BtnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnConsultar.Enabled = false;
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            GrdGrilla.DataSource = Consultas.CnsEstadoCuenta();
            SplashScreenManager.CloseForm();
            BtnConsultar.Enabled = true;
        }         

        private void CmbProyecto_EditValueChanged_1(object sender, System.EventArgs e)
        {
            if (CmbProyecto.EditValue != DBNull.Value)
            {
                RpsAdjudicacion.DataSource = Consultas.CnsDuoStringCartera("CnsAdjudica", CmbProyecto.EditValue.ToString(), "Aprobado");
                RpsAdjudicacion.DisplayMember = "Cliente";
                RpsAdjudicacion.ValueMember = "IdAdjudicacion";
            }
        }
        #endregion Metodos
    }
}
