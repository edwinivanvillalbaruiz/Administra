namespace Formularios
{
    #region Librerias
    //@Javier Villalba Espinosa
    //@Junio 18 2020
    using DevExpress.LookAndFeel;
    using DevExpress.Skins;
    using DevExpress.UserSkins;
    using System;
    using System.Windows.Forms; 
    #endregion
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            BonusSkins.Register();
            SkinManager.EnableFormSkins();            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new XtraMenu());
        }
    }
}