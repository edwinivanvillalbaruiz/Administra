namespace Formularios
{
    #region Librerias
    //@Javier Villalba Espinosa
    //Junio 18 2020
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System.Windows.Forms;   
    #endregion

    public partial class UseRecaudos : DevExpress.XtraEditors.XtraUserControl
    {
        #region Propiedades

        public NegConsulta Consultas = new NegConsulta(Operaciones.CadenaGeneral);
        private BindingSource bs = new BindingSource();
        private static UseRecaudos _instance;

        #endregion Propiedades

        #region Constructor

        public UseRecaudos()
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

        public static UseRecaudos Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UseRecaudos();
                return _instance;
            }
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(GrdGrilla, "RELACION DE RECAUDOS DEL " + Consultas.datos.FechaInicio.ToShortDateString() + " AL " + Consultas.datos.FechaFinal.ToShortDateString());
        }

        private void BtnExporarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdGrilla);
        }

        private void BtnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnConsultar.Enabled = false;
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            GrdGrilla.DataSource = Consultas.CnsIngresos();
            SplashScreenManager.CloseForm();
            BtnConsultar.Enabled = true;
        }


        #endregion Metodos

        
    }
}