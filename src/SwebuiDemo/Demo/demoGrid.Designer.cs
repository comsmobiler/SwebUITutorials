using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class demoGrid : SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public demoGrid()
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
            this.gridView12 = new Swebui.Controls.GridView();
            // 
            // gridView12
            // 
            this.gridView12.DataSource = null;
            this.gridView12.Flex = 1;
            this.gridView12.Name = "gridView12";
            this.gridView12.Size = new System.Drawing.Size(0, 30);
            // 
            // demoGrid
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.gridView12});
            this.Load += new System.EventHandler(this.demoGrid_Load);

        }
        #endregion

        private GridView gridView12;
    }
}