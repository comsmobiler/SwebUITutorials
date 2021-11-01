using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class demoMap : SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public demoMap()
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
            this.panel2 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.button1 = new Swebui.Controls.Button();
            this.button2 = new Swebui.Controls.Button();
            this.mapView1 = new Swebui.Controls.MapView();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.mapTrimView1 = new Swebui.Controls.MapTrimView();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Wrap = Swebui.Controls.LayoutWrap.Wrap;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.button1,
            this.button2,
            this.mapView1});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "mapview";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Margin = new Swebui.Controls.Margin(10F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(0, 35);
            this.button1.Text = "Ìí¼ÓTag";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Margin = new Swebui.Controls.Margin(10F);
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.Size = new System.Drawing.Size(0, 35);
            this.button2.Text = "µã»÷Ìí¼Óroute";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mapView1
            // 
            this.mapView1.Flex = 1;
            this.mapView1.Name = "mapView1";
            this.mapView1.Size = new System.Drawing.Size(0, 0);
            this.mapView1.TagClick += new Swebui.Controls.MapViewTagClickEventHandler(this.mapView1_TagClick);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.mapTrimView1});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.Text = "maptrimview";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // mapTrimView1
            // 
            this.mapTrimView1.Flex = 1;
            this.mapTrimView1.Name = "mapTrimView1";
            this.mapTrimView1.Size = new System.Drawing.Size(0, 300);
            this.mapTrimView1.LocationChanged += new Swebui.Controls.MapTrimViewLocationChanged(this.mapTrimView1_LocationChanged);
            // 
            // demoMap
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Load += new System.EventHandler(this.demoMap_Load);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private MapView mapView1;
        private Panel panel3;
        private Label label2;
        private MapTrimView mapTrimView1;
        private Button button2;
    }
}