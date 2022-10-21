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
            this.button1 = new Swebui.Controls.Button();
            this.button2 = new Swebui.Controls.Button();
            this.button4 = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button3,
            this.button1,
            this.button2,
            this.button4});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 49);
            // 
            // button3
            // 
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 0;
            this.button3.Size = new System.Drawing.Size(150, 0);
            this.button3.Text = "ÏÔÊ¾·þÎñ¶ËjsCokie.html";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // webView1
            // 
            this.webView1.Flex = 1;
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(0, 300);
            this.webView1.Url = "https://www.smobiler.com";
            this.webView1.OnMessage += new Swebui.Controls.WebView.WebViewMessageEventHandler(this.webView1_OnMessage);
            // 
            // button1
            // 
            this.button1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(150, 0);
            this.button1.Text = "PostMessage-Set";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.Size = new System.Drawing.Size(150, 0);
            this.button2.Text = "PostMessage-Get";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.button4.Name = "button4";
            this.button4.NumberOfLines = 0;
            this.button4.Size = new System.Drawing.Size(150, 0);
            this.button4.Text = "PostMessage-Del";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // demoWeb
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.webView1});
            this.Load += new System.EventHandler(this.demoMap_Load);
            this.Name = "demoWeb";

        }
        #endregion

        private Panel panel1;
        private Button button3;
        private WebView webView1;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}