using Swebui.Controls;
using System;

namespace SwebuiDemo.Demo
{
    partial class demoEditer : Swebui.Controls.SwebUserControl
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
            this.editer1 = new Swebui.Controls.Editer();
            this.panel1 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
            this.button2 = new Swebui.Controls.Button();
            this.button3 = new Swebui.Controls.Button();
            this.button4 = new Swebui.Controls.Button();
            this.button5 = new Swebui.Controls.Button();
            // 
            // editer1
            // 
            this.editer1.DefaultDelta = new object[0];
            this.editer1.Margin = new Swebui.Controls.Margin(20F);
            this.editer1.Name = "editer1";
            this.editer1.Size = new System.Drawing.Size(500, 400);
            this.editer1.Theme = Swebui.Controls.Editer.EditerTheme.Snow;
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1,
            this.button2,
            this.button3,
            this.button4,
            this.button5});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Margin = new Swebui.Controls.Margin(20F);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 41);
            // 
            // button1
            // 
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(100, 0);
            this.button1.Text = "Save";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.Size = new System.Drawing.Size(100, 0);
            this.button2.Text = "Clear";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 0;
            this.button3.Size = new System.Drawing.Size(100, 0);
            this.button3.Text = "undo";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Name = "button4";
            this.button4.NumberOfLines = 0;
            this.button4.Size = new System.Drawing.Size(100, 0);
            this.button4.Text = "redo";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Name = "button5";
            this.button5.NumberOfLines = 0;
            this.button5.Size = new System.Drawing.Size(100, 0);
            this.button5.Text = "update";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // demoEditer
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.editer1,
            this.panel1});
            this.Load += new System.EventHandler(this.demoEditer_Load);
            this.Name = "demoEditer";

        }
        #endregion

        private Editer editer1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}