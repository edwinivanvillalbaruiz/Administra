
namespace Formularios
{
    #region Librerias
    //@Javier Villalba Espinosa
    //@Junio 18 2020
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System.Windows.Forms; 
    #endregion


    public partial class UserLotes : DevExpress.XtraEditors.XtraUserControl
    {
        #region Propiedades

        public NegConsulta Consultas = new NegConsulta(Operaciones.CadenaGeneral);        
        private static UserLotes _instance;

        #endregion Propiedades

        #region Constructor
        public UserLotes()
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
        public static UserLotes Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserLotes();
                return _instance;
            }
        }
        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(GrdGrilla, "RELACION DE LOTES LIBRES");
        }
        private void BtnExporarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdGrilla);
        }
        private void BtnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnConsultar.Enabled = false;
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            GrdGrilla.DataSource = Consultas.CnsCnsCartera("LotesLibres");
            SplashScreenManager.CloseForm();
            BtnConsultar.Enabled = true;
        }

        #endregion Metodos
    }
}
