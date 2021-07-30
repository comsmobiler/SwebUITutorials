using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class demoListViewTemplate : SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public demoListViewTemplate()
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
            this.image1 = new Swebui.Controls.Image();
            this.panel2 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
            this.label3 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.panel2,
            this.panel3});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 72);
            // 
            // image1
            // 
            this.image1.DisplayMember = "img";
            this.image1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(40, 40);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1,
            this.label3});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel2.Size = new System.Drawing.Size(300, 52);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DisplayMember = "title";
            this.button1.Flex = 1;
            this.button1.FontSize = 14F;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Left;
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 1;
            this.button1.Size = new System.Drawing.Size(0, 26);
            // 
            // label3
            // 
            this.label3.BorderColor = System.Drawing.Color.LightGray;
            this.label3.DisplayMember = "subtitle";
            this.label3.Flex = 1;
            this.label3.FontSize = 14F;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Name = "label3";
            this.label3.NumberOfLines = 1;
            this.label3.Size = new System.Drawing.Size(0, 35);
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel4,
            this.label2});
            this.panel3.Name = "panel3";
            this.panel3.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel3.Padding = new Swebui.Controls.Padding(40F, 0F, 20F, 0F);
            this.panel3.Size = new System.Drawing.Size(145, 52);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon1,
            this.label1});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Flex = 1;
            this.panel4.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel4.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.FlexEnd;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 29);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.LightGray;
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "commenting-o";
            this.fontIcon1.Size = new System.Drawing.Size(14, 14);
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.LightGray;
            this.label1.DisplayMember = "num";
            this.label1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.LightGray;
            this.label2.DisplayMember = "date";
            this.label2.Flex = 1;
            this.label2.FontSize = 14F;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // ListuserControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Size = new System.Drawing.Size(600, 75);
            this.Load += new System.EventHandler(this.demoMap_Load);

        }
        #endregion

        private Panel panel1;
        private Image image1;
        private Panel panel2;
        private Button button1;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private FontIcon fontIcon1;
        private Label label1;
    }
}