using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class demoPlugins: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public demoPlugins()
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
            this.marqueeLabel1 = new Swebui.Controls.MarqueeLabel();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.mediaView1 = new Swebui.Controls .MediaView();
            this.panel4 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.percentageCircle1 = new Swebui.Controls .PercentageCircle();
            this.percentageCircle2 = new Swebui.Controls .PercentageCircle();
            this.panel6 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.eCharts1 = new Swebui.Controls .ECharts();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel6});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Wrap = Swebui.Controls.LayoutWrap.Wrap;
            // 
            // panel2
            // 
            this.panel2.Border = new Swebui.Controls.Border(1F);
            this.panel2.BorderRadius = 4;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.marqueeLabel1});
            this.panel2.Margin = new Swebui.Controls.Margin(10F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 400);
            // 
            // label1
            // 
            this.label1.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "MarqueeLabel";
            // 
            // marqueeLabel1
            // 
            this.marqueeLabel1.Margin = new Swebui.Controls.Margin(10F);
            this.marqueeLabel1.Name = "marqueeLabel1";
            this.marqueeLabel1.Size = new System.Drawing.Size(0, 35);
            this.marqueeLabel1.Text = "Smobiler是什么呢？——是一个易用全面的Visual Studio组件库，在Visual Studio中通过可视化设计，同时实现基于React Native" +
    "前端技术的Android，IOS App和基于React前端技术的H5和各种小程序应用。";
            // 
            // panel3
            // 
            this.panel3.Border = new Swebui.Controls.Border(1F);
            this.panel3.BorderRadius = 4;
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.mediaView1});
            this.panel3.Margin = new Swebui.Controls.Margin(10F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 400);
            // 
            // label2
            // 
            this.label2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.Text = "mediaview";
            // 
            // mediaView1
            // 
            this.mediaView1.Flex = 1;
            this.mediaView1.Margin = new Swebui.Controls.Margin(10F);
            this.mediaView1.Name = "mediaView1";
            this.mediaView1.Size = new System.Drawing.Size(0, 30);
            this.mediaView1.SizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            this.mediaView1.Url = "https://www.smobiler.com/video/video/video_001.mp4";
            // 
            // panel4
            // 
            this.panel4.Border = new Swebui.Controls.Border(1F);
            this.panel4.BorderRadius = 4;
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.panel5});
            this.panel4.Margin = new Swebui.Controls.Margin(10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 400);
            // 
            // label3
            // 
            this.label3.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 35);
            this.label3.Text = "PercentageCircle";
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.percentageCircle1,
            this.percentageCircle2});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Margin = new Swebui.Controls.Margin(30F);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 120);
            // 
            // percentageCircle1
            // 
            this.percentageCircle1.Flex = 1;
            this.percentageCircle1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.percentageCircle1.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.percentageCircle1.Name = "percentageCircle1";
            this.percentageCircle1.Size = new System.Drawing.Size(170, 0);
            this.percentageCircle1.Value = 50;
            // 
            // percentageCircle2
            // 
            this.percentageCircle2.CircleColor = System.Drawing.Color.Navy;
            this.percentageCircle2.Flex = 1;
            this.percentageCircle2.InnerColor = System.Drawing.Color.Orange;
            this.percentageCircle2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.percentageCircle2.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.percentageCircle2.Name = "percentageCircle2";
            this.percentageCircle2.Size = new System.Drawing.Size(179, 0);
            this.percentageCircle2.Value = 94;
            this.percentageCircle2.ValueColor = System.Drawing.Color.DodgerBlue;
            // 
            // panel6
            // 
            this.panel6.Border = new Swebui.Controls.Border(1F);
            this.panel6.BorderRadius = 4;
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.eCharts1});
            this.panel6.Margin = new Swebui.Controls.Margin(10F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 400);
            // 
            // label4
            // 
            this.label4.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 35);
            this.label4.Text = "echarts";
            // 
            // eCharts1
            // 
            this.eCharts1.Flex = 1;
            this.eCharts1.Name = "eCharts1";
            this.eCharts1.Size = new System.Drawing.Size(0, 30);
            // 
            // demoPlugins
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 1500);
            this.Load += new System.EventHandler(this.demoPlugins_Load);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private MarqueeLabel marqueeLabel1;
        private Panel panel3;
        private Label label2;
        private MediaView mediaView1;
        private Panel panel4;
        private Label label3;
        private Panel panel5;
        private PercentageCircle percentageCircle1;
        private PercentageCircle percentageCircle2;
        private Panel panel6;
        private Label label4;
        private ECharts eCharts1;
    }
}