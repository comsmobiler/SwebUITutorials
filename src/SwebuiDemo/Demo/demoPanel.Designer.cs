using Swebui.Controls;
using System;

namespace SwebuiDemo.Demo
{
    partial class demoPanel : Swebui.Controls.SwebUserControl
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
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            // 
            // panel1
            // 
            this.panel1.Border = new Swebui.Controls.Border(1F);
            this.panel1.BorderRadius = 8;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2,
            this.panel2});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 500);
            // 
            // label1
            // 
            this.label1.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.Name = "label1";
            this.label1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "Panel";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.LineHeight = 26F;
            this.label2.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 10F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            this.label2.Text = "目前panel的鼠标事件和点击事件中均可获取标位置，可以点击下方蓝色panel测试";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new Swebui.Controls.Margin(50F);
            this.panel2.Name = "panel2";
            this.panel2.RaiseMouseEvent = true;
            this.panel2.Size = new System.Drawing.Size(300, 300);
            this.panel2.Touchable = true;
            this.panel2.Press += new Swebui.Controls.SwebMousePressEventHandler(this.panel2_Press);
            this.panel2.MouseEnter += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel2_MouseLeave);
            // 
            // demoPanel
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Name = "demoPanel";

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
    }
}