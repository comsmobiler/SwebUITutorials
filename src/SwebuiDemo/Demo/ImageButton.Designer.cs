using Swebui.Controls;
using System;

namespace SwebuiDemo.Demo
{
    partial class ImageButton : Swebui.Controls.SwebUserControl
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
            this.panel1 = new Swebui.Controls.Panel();
            this.image1 = new Swebui.Controls.Image();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Touchable = true;
            this.panel1.Press += new SwebMousePressEventHandler(this.panel1_Press);
            // 
            // image1
            // 
            this.image1.Flex = 1;
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(0, 45);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // ImageButton
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(100, 100);

        }
        #endregion

        private Panel panel1;
        private Image image1;
    }
}