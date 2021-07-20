using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class demoWeb : SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public demoWeb()
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
            this.panel1 = new Swebui.Controls.Panel();
            this.button3 = new Swebui.Controls.Button();
            this.webView1 = new Swebui.Controls.WebView();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button3});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 49);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.LineThrough = false;
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 0);
            this.button3.Text = "Ìø×ª°Ù¶È";
            this.button3.Underline = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // webView1
            // 
            this.webView1.Flex = 1;
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(0, 300);
            this.webView1.Url = "www.smobiler.com";
            // 
            // demoWeb
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.webView1});
            this.Load += new System.EventHandler(this.demoMap_Load);

        }
        #endregion

        private Panel panel1;
        private Button button3;
        private WebView webView1;
    }
}