using Swebui.Controls;
using System;

namespace SwebuiDemo.Demo
{
    partial class popcontrol : Swebui.Controls.SwebUserControl
    {
        #region "SwebUserControl generated code "

        //SwebUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SwebUserControl
        //It can be modified using the SwebUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.button1 = new Swebui.Controls.Button();
            this.label1 = new Swebui.Controls.Label();
            this.image1 = new Swebui.Controls.Image();
            // 
            // fontIcon1
            // 
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "calendar-o";
            this.fontIcon1.Size = new System.Drawing.Size(32, 0);
            // 
            // button1
            // 
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(59, 0);
            this.button1.Text = "11d";
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 0);
            this.label1.Text = "label";
            // 
            // image1
            // 
            this.image1.Name = "image1";
            this.image1.ResourceID = "logon.png";
            this.image1.Size = new System.Drawing.Size(45, 0);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // popcontrol
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon1,
            this.button1,
            this.label1,
            this.image1});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Size = new System.Drawing.Size(200, 60);
            this.Name = "popcontrol";

        }
        #endregion

        private FontIcon fontIcon1;
        private Button button1;
        private Label label1;
        private Image image1;
    }
}