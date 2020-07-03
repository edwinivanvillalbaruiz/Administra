namespace Formularios
{
    #region Librerias
    //@Javier Villlba Espinosa
    //Junio 18 2020
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System.Windows.Forms; 
    #endregion

    public partial class UserPagos : DevExpress.XtraEditors.XtraUserControl
    {
        #region Propiedades

        public NegConsulta Consultas = new NegConsulta(Operaciones.CadenaGeneral);
        private BindingSource bs = new BindingSource();
        private static UserPagos _instance;

        #endregion Propiedades

        #region Constructor

        public UserPagos()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            bs.DataSource = Consultas.datos;
            DtpFechaInicial.DataBindings.Add("EditValue", bs, "FechaInicio", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaFinal.DataBindings.Add("EditValue", bs, "FechaFinal", true, DataSourceUpdateMode.OnPropertyChanged);
            Consultas.Error_Event_Consulta += Consultas_Error_Event_Consulta;
           
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

        public static UserPagos Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserPagos();
                return _instance;
            }
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(GrdGrilla, "RELACION DE PAGOS DEL " + Consultas.datos.FechaInicio.ToShortDateString() + " AL " + Consultas.datos.FechaFinal.ToShortDateString());
        }

        private void BtnExporarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdGrilla);
        }

        private void BtnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnConsultar.Enabled = false;
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            GrdGrilla.DataSource = Consultas.CnsGastos();
            SplashScreenManager.CloseForm();
            BtnConsultar.Enabled = true;
        }

        #endregion Metodos
    }
}