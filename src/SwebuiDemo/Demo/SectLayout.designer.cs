using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class SectLayout : SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public SectLayout()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.label1 = new Swebui.Controls.Label();
            // 
            // label1
            // 
            this.label1.DisplayMember = "SectLab";
            this.label1.Flex = 1;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 0);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // SectLayout
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Size = new System.Drawing.Size(600, 35);
            this.Load += new System.EventHandler(this.demoMap_Load);

        }
        #endregion

        private Label label1;
    }
}