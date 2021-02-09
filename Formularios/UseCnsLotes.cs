
namespace Formularios
{
    #region Librerias
    //@Javier Villalba Espinosa
    //@Noviembre 11 2020
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System.Windows.Forms;
    #endregion


    public partial class UseCnsLotes : DevExpress.XtraEditors.XtraUserControl
    {
        #region Propiedades

        public NegConsulta Consultas = new NegConsulta(Operaciones.CadenaGeneral);
        private static UseCnsLotes _instance;

        #endregion Propiedades

        #region Constructor
        public UseCnsLotes()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            Consultas.Error_Event_Consulta += Consultas_Error_Event_Consulta;
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
        public static UseCnsLotes Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UseCnsLotes();
                return _instance;
            }
        }
        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(GrdGrilla, "RELACION DE LOTES");
        }
        private void BtnExporarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdGrilla);
        }

        private void BtnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnConsultar.Enabled = false;
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            GrdGrilla.DataSource = Consultas.CnsLotes();
            SplashScreenManager.CloseForm();
            BtnConsultar.Enabled = true;
        }

        #endregion Metodos

        private void BtnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
    }
}
