using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class tabUserLayout3: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public tabUserLayout3()
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
            this.panel4 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
            this.image1 = new Swebui.Controls.Image();
            // 
            // panel4
            // 
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(179)))), ((int)(((byte)(148)))));
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(66, 35);
            this.button1.Text = "ÉÏ´«";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // image1
            // 
            this.image1.Border = new Swebui.Controls.Border(1F);
            this.image1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.image1.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 10F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.ResourcePath = "upload";
            this.image1.Size = new System.Drawing.Size(150, 150);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // tabUserLayout3
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1,
            this.image1});
            this.Flex = 1;
            this.Padding = new Swebui.Controls.Padding(10F);
            this.Load += new System.EventHandler(this.demoUserTemplate_Load);
            this.Name = "tabUserLayout3";

        }
        #endregion
        private Panel panel4 = new Panel();
        private Button button1;
        private Image image1;
    }
}