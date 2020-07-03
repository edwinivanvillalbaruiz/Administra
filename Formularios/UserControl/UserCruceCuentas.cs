namespace Formularios
{
    #region Librerias
   //@Javier Villalba Espinosa
   //@Junio 18 2020
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System.Windows.Forms; 
    #endregion
    public partial class UserCruceCuentas : DevExpress.XtraEditors.XtraUserControl
    {
        #region Propiedades

        public NegConsulta Consultas = new NegConsulta(Operaciones.CadenaGeneral);       
        private static UserCruceCuentas _instance;
        private BindingSource bs = new BindingSource();

        #endregion Propiedades

        #region Constructor

        public UserCruceCuentas()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();            
            Consultas.Error_Event_Consulta += Consultas_Error_Event_Consulta;
            bs.DataSource = Consultas.datos;
            DtpFechaInicial.DataBindings.Add("EditValue", bs, "FechaInicio", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaFinal.DataBindings.Add("EditValue", bs, "FechaFinal", true, DataSourceUpdateMode.OnPropertyChanged);
            SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void Consultas_Error_Event_Consulta(string mensaje)
        {
            XtraMessageBox.Show(mensaje, " Consultas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos

        public static UserCruceCuentas Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserCruceCuentas();
                return _instance;
            }
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(GrdGrilla, "RELACION LOTES LIBRES " + Consultas.datos.FechaInicio.ToShortDateString() + " AL " + Consultas.datos.FechaFinal.ToShortDateString());
        }

        private void BtnExporarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdGrilla);
        }

        private void BtnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnConsultar.Enabled = false;
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            GrdGrilla.DataSource = Consultas.CnsCrucesCuentas();
            SplashScreenManager.CloseForm();
            BtnConsultar.Enabled = true;
        }

        #endregion Metodos
    }
}