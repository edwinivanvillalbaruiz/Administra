namespace Formularios
{
    #region Librerias
    //@Javier Villalba Espinosa
    //Junio 18 2020
    using DevExpress.XtraEditors;
    using DevExpress.XtraPivotGrid;
    using DevExpress.XtraSplashScreen;
    using System.Data;
    using System.Windows.Forms; 
    #endregion

    public partial class UserInformeGeneral : DevExpress.XtraEditors.XtraUserControl
    {
        #region Propiedades

        public NegConsulta Consultas = new NegConsulta(Operaciones.CadenaGeneral);
        private BindingSource bs = new BindingSource();
        private static UserInformeGeneral _instance;

        #endregion Propiedades

        #region Constructor
        public UserInformeGeneral()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            bs.DataSource = Consultas.datos;
            DtpFechaInicial.DataBindings.Add("EditValue", bs, "FechaInicio", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaFinal.DataBindings.Add("EditValue", bs, "FechaFinal", true, DataSourceUpdateMode.OnPropertyChanged);
            Consultas.Error_Event_Consulta += Consultas_Error_Event_Consulta;            
            MtdPivot();
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

        public static UserInformeGeneral Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserInformeGeneral();
                return _instance;
            }
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(pivotGridControl1, "RELACION DE CRUCE CUENTAS DEL " + Consultas.datos.FechaInicio.ToShortDateString() + " AL " + Consultas.datos.FechaFinal.ToShortDateString());
        }

        private void BtnExporarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(pivotGridControl1);
        }

        private void BtnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnConsultar.Enabled = false;
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            DataTable dt = Consultas.CnsInformeGeneral();
            if (dt.Rows.Count > 0)
            {
                pivotGridControl1.DataSource = Consultas.CnsInformeGeneral();

            }
            SplashScreenManager.CloseForm();
            BtnConsultar.Enabled = true;
        }

        private void MtdPivot()
        {
            pivotGridControl1.OptionsSelection.MultiSelect = true;

            PivotGridField Proyecto = new PivotGridField("Proyecto", PivotArea.ColumnArea);
            Proyecto.Caption = "Proyecto";

            PivotGridField SubSubCentro = new PivotGridField("SubSubCentro", PivotArea.RowArea);
            SubSubCentro.Caption = "SubSubCentro";

            PivotGridField Area = new PivotGridField("Area", PivotArea.RowArea);
            Area.Caption = "Area";

            PivotGridField Centro = new PivotGridField("Centro", PivotArea.RowArea);
            Proyecto.Caption = "Centro";

            PivotGridField Detalle = new PivotGridField("Detalle", PivotArea.RowArea);
            Proyecto.Caption = "Detalle";

            PivotGridField Valor = new PivotGridField("Valor", PivotArea.DataArea);
            Valor.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            Valor.CellFormat.FormatString = "c2";

            pivotGridControl1.Fields.AddRange(new PivotGridField[] { Proyecto, Centro, Area, SubSubCentro, Valor });
            Proyecto.Width = 100;
            Valor.Width = 100;

            SubSubCentro.Width = 200;
            Detalle.Width = 100;
        }
        #endregion Metodos
    }
}
