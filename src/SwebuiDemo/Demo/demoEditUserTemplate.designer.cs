using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class demoEditUserTemplate : SwebUserControl
    {
        #region "SmobilerUserControl generated code "

 
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
            this.label1 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.panel2 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
            this.button2 = new Swebui.Controls.Button();
            this.button3 = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.tabPageView1 = new Swebui.Controls.TabPageView();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 35);
            // 
            // label1
            // 
            this.label1.FontSize = 24F;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.Text = "编辑用户";
            // 
            // panel4
            // 
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1,
            this.button2,
            this.button3});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 35);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Border = new Swebui.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.IconName = "fa fa-chevron-left";
            this.button1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Padding = new Swebui.Controls.Padding(5F, 0F, 5F, 0F);
            this.button1.Size = new System.Drawing.Size(0, 26);
            this.button1.Text = "返回";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Border = new Swebui.Controls.Border(1F);
            this.button2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.IconName = "fa fa-floppy-o";
            this.button2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.Padding = new Swebui.Controls.Padding(5F, 0F, 5F, 0F);
            this.button2.Size = new System.Drawing.Size(0, 26);
            this.button2.Text = "保存";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Border = new Swebui.Controls.Border(1F);
            this.button3.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.IconName = "fa fa-trash";
            this.button3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 0;
            this.button3.Padding = new Swebui.Controls.Padding(5F, 0F, 5F, 0F);
            this.button3.Size = new System.Drawing.Size(0, 26);
            this.button3.Text = "删除";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.tabPageView1});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // tabPageView1
            // 
            this.tabPageView1.Flex = 1;
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndex = 0;
            this.tabPageView1.PageIndicator = Swebui.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(0, 30);
            this.tabPageView1.Titles = new string[] {
        "BaseInfo",
        "Function",
        "UserPhoto"};
            // 
            // demoEditUserTemplate
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3});
            this.Flex = 1;
            this.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.Load += new System.EventHandler(this.demoUserTemplate_Load);

        }
        #endregion

        private Panel panel1=new Panel();
        private Panel panel2=new Panel();
        private Panel panel4=new Panel();
        private Label label1;
        private Button button2;
        private Button button3;
        private Panel panel3;
        private TabPageView tabPageView1;
        private Button button1;
    }
}