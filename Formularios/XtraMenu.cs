namespace Formularios
{
    #region Libreria
    //@Javier Villalba Espinosa
    //@Junio 19 2020
    using DevExpress.LookAndFeel;
    using DevExpress.XtraBars;
    using System;
    using System.Windows.Forms;

    #endregion
    public partial class XtraMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Constructor
        public XtraMenu()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SkinName = Operaciones.GetSetting("Consultas", "Skin", "Tema", UserLookAndFeel.Default.SkinName.ToString());
        }
        #endregion


        #region Metodos
        private void BtnCruceCuentas_Click(object sender, EventArgs e)
        {
            if (!Contenedor.Controls.Contains(UserCruceCuentas.Instance))
            {
                
                Contenedor.Controls.Add(UserCruceCuentas.Instance);
                UserCruceCuentas.Instance.Dock = DockStyle.Fill;
                UserCruceCuentas.Instance.BringToFront();               
                UserCruceCuentas.Instance.BtnSalir.ItemClick += BtnSalir_ItemClick;
            }
            UserCruceCuentas.Instance.BringToFront();
            barStaticItem1.Caption = "CONSULTA CRUCES DE CUENTAS POR FECHA";
        }
        private void BtnEstadoCuenta_Click(object sender, EventArgs e)
        {
            if (!Contenedor.Controls.Contains(UserEstadoCuentaCartera.Instance))
            {
                Contenedor.Controls.Add(UserEstadoCuentaCartera.Instance);
                UserEstadoCuentaCartera.Instance.Dock = DockStyle.Fill;
                UserEstadoCuentaCartera.Instance.BringToFront();
                UserEstadoCuentaCartera.Instance.BtnSalir.ItemClick += BtnSalir_ItemClick;
            }
            UserEstadoCuentaCartera.Instance.BringToFront();
            barStaticItem1.Caption = "ESTADO DE CUENTAS";
        }
        private void BtnInformeGeneral_Click(object sender, EventArgs e)
        {
            if (!Contenedor.Controls.Contains(UserInformeGeneral.Instance))
            {
                Contenedor.Controls.Add(UserInformeGeneral.Instance);
                UserInformeGeneral.Instance.Dock = DockStyle.Fill;
                UserInformeGeneral.Instance.BringToFront();
                UserInformeGeneral.Instance.BtnSalir.ItemClick += BtnSalir_ItemClick;
            }
            UserInformeGeneral.Instance.BringToFront();
            barStaticItem1.Caption = "CONSULTA INFORME GENERAL POR FECHA";
        }
        private void BtnIngresoFecha_Click(object sender, EventArgs e)
        {
            if (!Contenedor.Controls.Contains(UseRecaudos.Instance))
            {
                Contenedor.Controls.Add(UseRecaudos.Instance);
                UseRecaudos.Instance.Dock = DockStyle.Fill;
                UseRecaudos.Instance.BringToFront();
                UseRecaudos.Instance.BtnSalir.ItemClick += BtnSalir_ItemClick;
            }
            UseRecaudos.Instance.BringToFront();
            barStaticItem1.Caption = "CONSULTA INGRESOS POR FECHA";
        }
        private void BtnLotesLibres_Click(object sender, EventArgs e)
        {
            if (!Contenedor.Controls.Contains(UserLotes.Instance))
            {
                Contenedor.Controls.Add(UserLotes.Instance);
                UserLotes.Instance.Dock = DockStyle.Fill;
                UserLotes.Instance.BringToFront();
                UserLotes.Instance.BtnSalir.ItemClick += BtnSalir_ItemClick;
            }
            UserLotes.Instance.BringToFront();
            barStaticItem1.Caption = "CONSULTA DE LOTES LIBRES";
        }
        private void BtnPagosFecha_Click(object sender, EventArgs e)
        {
            if (!Contenedor.Controls.Contains(UserPagos.Instance))
            {
                Contenedor.Controls.Add(UserPagos.Instance);
                UserPagos.Instance.Dock = DockStyle.Fill;
                UserPagos.Instance.BringToFront();
                UserPagos.Instance.BtnSalir.ItemClick += BtnSalir_ItemClick;
            }
            UserPagos.Instance.BringToFront();
            barStaticItem1.Caption = "CONSULTA PAGOS POR FECHA";
        }
        private void BtnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            barStaticItem1.Caption = "MENU GENERAL CONSULTAS";
            Contenedor.Controls.Clear();
        }
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Operaciones.SaveSetting("Consultas", "Skin", "Tema", UserLookAndFeel.Default.SkinName.ToString());

        }
        private void BtnRcdFecha_Click(object sender, EventArgs e)
        {
            if (!Contenedor.Controls.Contains(UserRecaudosFecha.Instance))
            {
                Contenedor.Controls.Add(UserRecaudosFecha.Instance);
                UserRecaudosFecha.Instance.Dock = DockStyle.Fill;
                UserRecaudosFecha.Instance.BringToFront();
                UserRecaudosFecha.Instance.BtnSalir.ItemClick += BtnSalir_ItemClick;
            }
            UserRecaudosFecha.Instance.BringToFront();
            barStaticItem1.Caption = "CONSULTA RECAUDOS POR FECHA";

        }
        #endregion Metodos

        private void BtnInformePresupuesto_Click(object sender, EventArgs e)
        {
            if (!Contenedor.Controls.Contains(UseInfoPresupuesto.Instance))
            {
                Contenedor.Controls.Add(UseInfoPresupuesto.Instance);
                UseInfoPresupuesto.Instance.Dock = DockStyle.Fill;
                UseInfoPresupuesto.Instance.BringToFront();
                UseInfoPresupuesto.Instance.BtnSalir.ItemClick += BtnSalir_ItemClick;
            }
            UseInfoPresupuesto.Instance.BringToFront();
        }

        private void BtnInformeLotes_Click(object sender, EventArgs e)
        {
            if (!Contenedor.Controls.Contains(UseCnsLotes.Instance))
            {
                Contenedor.Controls.Add(UseCnsLotes.Instance);
                UseCnsLotes.Instance.Dock = DockStyle.Fill;
                UseCnsLotes.Instance.BringToFront();
                UseCnsLotes.Instance.BtnSalir.ItemClick += BtnSalir_ItemClick;
            }
            UseCnsLotes.Instance.BringToFront();
        }

        private void BtnSaldoCartera_Click(object sender, EventArgs e)
        {
            if (!Contenedor.Controls.Contains(UserSaldoCartera.Instance))
            {
                Contenedor.Controls.Add(UserSaldoCartera.Instance);
                UserSaldoCartera.Instance.Dock = DockStyle.Fill;
                UserSaldoCartera.Instance.BringToFront();
                UserSaldoCartera.Instance.BtnSalir.ItemClick += BtnSalir_ItemClick;
            }
            UserSaldoCartera.Instance.BringToFront();
        }
    }
}