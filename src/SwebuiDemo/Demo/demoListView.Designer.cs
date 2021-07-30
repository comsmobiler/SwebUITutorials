using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class demoListView : SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public demoListView()
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
            this.listView1 = new Swebui.Controls.ListView();
            // 
            // listView1
            // 
            this.listView1.Flex = 1;
            this.listView1.Margin = new Swebui.Controls.Margin(10F);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(0, 300);
            // 
            // demoListView
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.listView1});
            this.Load += new System.EventHandler(this.demoTemplate_Load);

        }
        #endregion

        private ListView listView1;
    }
}