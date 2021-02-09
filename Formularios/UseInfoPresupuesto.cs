
namespace Formularios
{
    #region Libreria
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System.Windows.Forms; 
    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //Noviembre 11 2020
    #endregion

    public partial class UseInfoPresupuesto : DevExpress.XtraEditors.XtraUserControl
    {

        #region Propiedades
        public NegConsulta Consultas = new NegConsulta(Operaciones.CadenaGeneral);
        private BindingSource bs = new BindingSource();
        private static UseInfoPresupuesto _instance;
        #endregion Propiedades

        #region Constructor
        public UseInfoPresupuesto()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            RpsMeses.DataSource = Consultas.DtMeses();
            RpsMeses.DisplayMember = "Mes";
            RpsMeses.ValueMember = "Id";

            RpsAño.DataSource = Consultas.DtAño();
            RpsAño.DisplayMember = "Año";
            RpsAño.ValueMember = "Año";

            Consultas.Error_Event_Consulta += Consultas_Error_Event_Consulta;
            bs.DataSource = Consultas.datos;
            CmbAño.DataBindings.Add("EditValue", bs, "Año", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbMeses.DataBindings.Add("EditValue", bs, "Mes", true, DataSourceUpdateMode.OnPropertyChanged);
            SplashScreenManager.CloseForm();
        }
        #endregion

        #region Disparadores
        private void Consultas_Error_Event_Consulta(string mensaje)
        {
            XtraMessageBox.Show(mensaje, " Consultas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Metodos
        public static UseInfoPresupuesto Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UseInfoPresupuesto();
                return _instance;
            }
        }

        private void BtnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnConsultar.Enabled = false;
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            GrdGrilla.DataSource = Consultas.CnsInformePrespuesto();
            SplashScreenManager.CloseForm();
            BtnConsultar.Enabled = true;            
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(GrdGrilla, "Informe Presupuesto  Año " + CmbAño.EditValue + " Mes" + CmbMeses.Caption);
        }

        private void BtnExporarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdGrilla);
        }
        #endregion
    }
}
