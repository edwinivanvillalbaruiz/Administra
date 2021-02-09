namespace Formularios
{
    partial class XtraMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.LblConsultasContables = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnPagosFecha = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnIngresoFecha = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnCruceCuentas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnInformeGeneral = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.LblConsultasCaratera = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnLotesLibres = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnRcdFecha = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnEstadoCuenta = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnInformePresupuesto = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnInformeLotes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Contenedor = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.ribbonPageGroupNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnSaldoCartera = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barStaticItem1,
            this.skinDropDownButtonItem1,
            this.skinPaletteRibbonGalleryBarItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemZoomTrackBar1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.Size = new System.Drawing.Size(1317, 89);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 6;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Caption = "Galeria Skines";
            this.skinPaletteRibbonGalleryBarItem1.Id = 7;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Modulo de Consultas";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Skin";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 513);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1317, 24);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.LblConsultasContables,
            this.LblConsultasCaratera});
            this.accordionControl1.Location = new System.Drawing.Point(0, 89);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(250, 424);
            this.accordionControl1.TabIndex = 2;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // LblConsultasContables
            // 
            this.LblConsultasContables.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.BtnPagosFecha,
            this.BtnIngresoFecha,
            this.BtnCruceCuentas,
            this.BtnInformeGeneral,
            this.accordionControlSeparator1});
            this.LblConsultasContables.Expanded = true;
            this.LblConsultasContables.Name = "LblConsultasContables";
            this.LblConsultasContables.Text = "Consultas Contables";
            // 
            // BtnPagosFecha
            // 
            this.BtnPagosFecha.Name = "BtnPagosFecha";
            this.BtnPagosFecha.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnPagosFecha.Text = "Pagos Fecha";
            this.BtnPagosFecha.Click += new System.EventHandler(this.BtnPagosFecha_Click);
            // 
            // BtnIngresoFecha
            // 
            this.BtnIngresoFecha.Name = "BtnIngresoFecha";
            this.BtnIngresoFecha.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnIngresoFecha.Text = "Ingresos Fecha";
            this.BtnIngresoFecha.Click += new System.EventHandler(this.BtnIngresoFecha_Click);
            // 
            // BtnCruceCuentas
            // 
            this.BtnCruceCuentas.Name = "BtnCruceCuentas";
            this.BtnCruceCuentas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnCruceCuentas.Text = "Cruce Cuentas";
            this.BtnCruceCuentas.Click += new System.EventHandler(this.BtnCruceCuentas_Click);
            // 
            // BtnInformeGeneral
            // 
            this.BtnInformeGeneral.Name = "BtnInformeGeneral";
            this.BtnInformeGeneral.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnInformeGeneral.Text = "Informe General";
            this.BtnInformeGeneral.Click += new System.EventHandler(this.BtnInformeGeneral_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // LblConsultasCaratera
            // 
            this.LblConsultasCaratera.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.BtnLotesLibres,
            this.BtnRcdFecha,
            this.BtnEstadoCuenta,
            this.BtnInformePresupuesto,
            this.BtnInformeLotes,
            this.BtnSaldoCartera});
            this.LblConsultasCaratera.Expanded = true;
            this.LblConsultasCaratera.Name = "LblConsultasCaratera";
            this.LblConsultasCaratera.Text = "Consultas Cartera";
            // 
            // BtnLotesLibres
            // 
            this.BtnLotesLibres.Name = "BtnLotesLibres";
            this.BtnLotesLibres.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnLotesLibres.Text = "Lotes Libres";
            this.BtnLotesLibres.Click += new System.EventHandler(this.BtnLotesLibres_Click);
            // 
            // BtnRcdFecha
            // 
            this.BtnRcdFecha.Name = "BtnRcdFecha";
            this.BtnRcdFecha.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnRcdFecha.Text = "Recaudos Fecha";
            this.BtnRcdFecha.Click += new System.EventHandler(this.BtnRcdFecha_Click);
            // 
            // BtnEstadoCuenta
            // 
            this.BtnEstadoCuenta.Name = "BtnEstadoCuenta";
            this.BtnEstadoCuenta.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnEstadoCuenta.Text = "Esatado Cuenta";
            this.BtnEstadoCuenta.Click += new System.EventHandler(this.BtnEstadoCuenta_Click);
            // 
            // BtnInformePresupuesto
            // 
            this.BtnInformePresupuesto.Name = "BtnInformePresupuesto";
            this.BtnInformePresupuesto.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnInformePresupuesto.Text = "Informe Presupuesto";
            this.BtnInformePresupuesto.Click += new System.EventHandler(this.BtnInformePresupuesto_Click);
            // 
            // BtnInformeLotes
            // 
            this.BtnInformeLotes.Name = "BtnInformeLotes";
            this.BtnInformeLotes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnInformeLotes.Text = "Informe Lotes";
            this.BtnInformeLotes.Click += new System.EventHandler(this.BtnInformeLotes_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(250, 89);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1067, 424);
            this.Contenedor.TabIndex = 3;
            // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.Id = 15;
            this.barSubItemNavigation.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.Name = "barSubItemNavigation";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Navigation";
            this.barSubItem1.Id = 15;
            this.barSubItem1.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Navigation";
            this.barSubItem2.Id = 15;
            this.barSubItem2.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Navigation";
            this.barSubItem3.Id = 15;
            this.barSubItem3.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Navigation";
            this.barSubItem4.Id = 15;
            this.barSubItem4.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.barSubItem4.Name = "barSubItem4";
            // 
            // ribbonPageGroupNavigation
            // 
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barSubItemNavigation);
            this.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation";
            this.ribbonPageGroupNavigation.Text = "Module";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barSubItemNavigation);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Module";
            // 
            // BtnSaldoCartera
            // 
            this.BtnSaldoCartera.Name = "BtnSaldoCartera";
            this.BtnSaldoCartera.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnSaldoCartera.Text = "Listado Cartera";
            this.BtnSaldoCartera.Click += new System.EventHandler(this.BtnSaldoCartera_Click);
            // 
            // XtraMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 537);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraMenu.IconOptions.SvgImage")));
            this.Name = "XtraMenu";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "SISTEMA INTEGRADO CONSULTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement LblConsultasContables;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnPagosFecha;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnIngresoFecha;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnCruceCuentas;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnInformeGeneral;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement LblConsultasCaratera;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnLotesLibres;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnEstadoCuenta;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer Contenedor;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnRcdFecha;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnInformePresupuesto;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnInformeLotes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnSaldoCartera;
    }
}