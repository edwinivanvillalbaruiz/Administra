namespace Formularios
{
    #region MyRegion
    //@Javier Villalba Espinosa
    //@Junio 18 2020
    using Conexiones;
    using DevExpress.XtraGrid;
    using DevExpress.XtraPivotGrid;
    using DevExpress.XtraPrinting;
    using Microsoft.Win32;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    #endregion

   /// <summary>
   /// Clase Estatica Para Operaciones 
   /// </summary>
    public static class Operaciones
    {
        #region Propiedades

        public static CadenaConexionMysql CadenaGeneral = new CadenaConexionMysql("201.221.224.203", "007guardian", "3306", "root", "elpobladosa");
        private static Image MiLogo;
        private static string Titulo = string.Empty;
        #endregion Propiedades

        #region Metodos
        public static void ExportarExel(GridControl GrdGrilla)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Buscar Ruta";
            dlg.Filter = "Todos Los Archivos Xlsx | *.xlsx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                GrdGrilla.ExportToXlsx(dlg.FileName);
            }
        }

        public static void ExportarExel(PivotGridControl GrdGrilla)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Buscar Ruta";
            dlg.Filter = "Todos Los Archivos Xlsx | *.xlsx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                GrdGrilla.ExportToXlsx(dlg.FileName);
            }
        }

        public static void ExportarPdf(GridControl GrdGrilla)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Buscar Ruta";
            dlg.Filter = "Todos Los Archivos Pdf | *.pdf";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                GrdGrilla.ExportToPdf(dlg.FileName);
            }
        }

        public static void ExportarPdf(PivotGridControl GrdGrilla)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Buscar Ruta";
            dlg.Filter = "Todos Los Archivos Pdf | *.pdf";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                GrdGrilla.ExportToPdf(dlg.FileName);
            }
        }

        public static string GetSetting(string appName, string section, string key)
        {
            return GetSetting(appName, section, key, string.Empty);
        }

        public static string GetSetting(string appName, string section, string key, string sDefault)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software\VB and VBA Program Settings\" + appName + "\\" + section);
            string s = sDefault;
            if (rk != null)
                s = (string)rk.GetValue(key);
            //
            return s;
        }

        public static void impirmir(GridControl GrdGrilla, string MiTitulo, byte[] logo)
        {
            Titulo = MiTitulo;
            if (logo != null)
            {
                MiLogo = byteArrayToImage(logo);
            }

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = GrdGrilla;
            link.CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);
            link.CreateDocument();
            link.ShowPreview();
        }

        public static void impirmir(GridControl GrdGrilla, string MiTitulo)
        {
            Titulo = MiTitulo;
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = GrdGrilla;
            link.CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);
            link.CreateDocument();
            link.ShowPreview();
        }

        public static void impirmir(PivotGridControl GrdGrilla, string MiTitulo)
        {
            Titulo = MiTitulo;
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = GrdGrilla;
            link.CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);
            link.CreateDocument();
            link.ShowPreview();
        }

        public static void SaveSetting(string appName, string section, string key, string setting)
        {
            // Los datos se guardan en:
            // HKEY_CURRENT_USER\Software\VB and VBA Program Settings
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(@"Software\VB and VBA Program Settings\" + appName + "\\" + section);
            rk.SetValue(key, setting);
        }

        private static Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        private static void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            TextBrick brick;
            ImageBrick imagen;
            brick = e.Graph.DrawString(Titulo, Color.Navy, new RectangleF(160, 0, 455, 60), DevExpress.XtraPrinting.BorderSide.None);
            imagen = e.Graph.DrawImage(MiLogo, new RectangleF(10, 0, 150, 50), DevExpress.XtraPrinting.BorderSide.None, Color.Transparent);
            brick.Font = new Font("Calibri", 14, System.Drawing.FontStyle.Bold);
            //brick.BackColor = Color.Green*  ;
            brick.ForeColor = Color.Gray;
            brick.StringFormat = new DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center);
        }
        #endregion Metodos
    }
    
    public class Datos
    {
        public DateTime FechaFinal { get; set; }
        public DateTime FechaInicio { get; set; }
        public string BaseDatos { get; set; }
        public string IdAdjudicacion { get; set; }
        public string Mes { get; set; }
        public string Año { get; set; }
    }
}