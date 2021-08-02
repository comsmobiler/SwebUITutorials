using Swebui.Controls;
using System;

namespace SwebuiDemo.Demo
{
    partial class demoCustm : Swebui.Controls.SwebUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(demoCustm));
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.imageButton1 = new SwebuiDemo.Demo.ImageButton();
            // 
            // panel1
            // 
            this.panel1.Border = new Swebui.Controls.Border(1F);
            this.panel1.BorderRadius = 8;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2,
            this.imageButton1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 400);
            // 
            // label1
            // 
            this.label1.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.Name = "label1";
            this.label1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "自定义控件";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.LineHeight = 2F;
            this.label2.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 10F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // imageButton1
            // 
            this.imageButton1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "logon.png";
            this.imageButton1.ResourcePath = "image";
            this.imageButton1.Size = new System.Drawing.Size(100, 100);
            this.imageButton1.ImagePress += new System.EventHandler(this.imageButton1_ImagePress);
            // 
            // demoCustm
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Padding = new Swebui.Controls.Padding(10F);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ImageButton imageButton1;
    }
}