﻿namespace Formularios
{
    #region Librerias
    //@Javier Villalba Espinosa
    //@Junio 18 2020
    using DevExpress.XtraWaitForm;
    using System; 
    #endregion

    public partial class WaitForm1 : WaitForm
    {
        public WaitForm1()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }
    }
}