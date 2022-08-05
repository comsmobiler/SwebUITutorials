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
            Swebui.Controls.AnimationItem animationItem1 = new Swebui.Controls.AnimationItem();
            Swebui.Controls.AnimationItem animationItem2 = new Swebui.Controls.AnimationItem();
            Swebui.Controls.AnimationItem animationItem3 = new Swebui.Controls.AnimationItem();
            this.panel1 = new Swebui.Controls.Panel();
            this.panel2 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.marqueeLabel1 = new Swebui.Controls.MarqueeLabel();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.mediaView1 = new Swebui.Controls.MediaView();
            this.panel10 = new Swebui.Controls.Panel();
            this.button16 = new Swebui.Controls.Button();
            this.button17 = new Swebui.Controls.Button();
            this.panel4 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.percentageCircle1 = new Swebui.Controls.PercentageCircle();
            this.percentageCircle2 = new Swebui.Controls.PercentageCircle();
            this.panel6 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.eCharts1 = new Swebui.Controls.ECharts();
            this.button12 = new Swebui.Controls.Button();
            this.button13 = new Swebui.Controls.Button();
            this.button14 = new Swebui.Controls.Button();
            this.panel7 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.animationPanel = new Swebui.Controls.Panel();
            this.label6 = new Swebui.Controls.Label();
            this.button4 = new Swebui.Controls.Button();
            this.button5 = new Swebui.Controls.Button();
            this.button6 = new Swebui.Controls.Button();
            this.label7 = new Swebui.Controls.Label();
            this.button1 = new Swebui.Controls.Button();
            this.button2 = new Swebui.Controls.Button();
            this.button3 = new Swebui.Controls.Button();
            this.button7 = new Swebui.Controls.Button();
            this.label8 = new Swebui.Controls.Label();
            this.button11 = new Swebui.Controls.Button();
            this.button8 = new Swebui.Controls.Button();
            this.button9 = new Swebui.Controls.Button();
            this.button10 = new Swebui.Controls.Button();
            this.panel8 = new Swebui.Controls.Panel();
            this.label9 = new Swebui.Controls.Label();
            this.svg1 = new Swebui.Controls.Svg();
            this.panel9 = new Swebui.Controls.Panel();
            this.label10 = new Swebui.Controls.Label();
            this.htmlView1 = new Swebui.Controls.HTMLView();
            this.button15 = new Swebui.Controls.Button();
            this.panel11 = new Swebui.Controls.Panel();
            this.label37 = new Swebui.Controls.Label();
            this.label38 = new Swebui.Controls.Label();
            this.button18 = new Swebui.Controls.Button();
            this.button19 = new Swebui.Controls.Button();
            this.button20 = new Swebui.Controls.Button();
            this.button21 = new Swebui.Controls.Button();
            this.animation1 = new Swebui.Controls.Animation();
            this.animation2 = new Swebui.Controls.Animation();
            this.animation3 = new Swebui.Controls.Animation();
            this.tts1 = new Swebui.Controls.TTS();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel6,
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel11});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 2900);
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
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "MarqueeLabel";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            this.mediaView1,
            this.panel10});
            this.panel3.Margin = new Swebui.Controls.Margin(10F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 400);
            // 
            // label2
            // 
            this.label2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.Text = "mediaview";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // mediaView1
            // 
            this.mediaView1.Flex = 1;
            this.mediaView1.Margin = new Swebui.Controls.Margin(10F);
            this.mediaView1.Name = "mediaView1";
            this.mediaView1.Size = new System.Drawing.Size(0, 30);
            this.mediaView1.Url = "https://www.smobiler.com/video/video/video_001.mp4";
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button16,
            this.button17});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 40);
            // 
            // button16
            // 
            this.button16.Margin = new Swebui.Controls.Margin(50F, 0F, 50F, 0F);
            this.button16.Name = "button16";
            this.button16.NumberOfLines = 0;
            this.button16.Size = new System.Drawing.Size(100, 0);
            this.button16.Text = "seek 60s";
            this.button16.Click += new System.EventHandler(this.button16_Click_1);
            // 
            // button17
            // 
            this.button17.Margin = new Swebui.Controls.Margin(50F, 0F, 50F, 0F);
            this.button17.Name = "button17";
            this.button17.NumberOfLines = 0;
            this.button17.Size = new System.Drawing.Size(100, 0);
            this.button17.Text = "pasue/start";
            this.button17.Click += new System.EventHandler(this.button17_Click);
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
            this.label3.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 35);
            this.label3.Text = "PercentageCircle";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            this.eCharts1,
            this.button12,
            this.button13,
            this.button14});
            this.panel6.Margin = new Swebui.Controls.Margin(10F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 400);
            // 
            // label4
            // 
            this.label4.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label4.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 35);
            this.label4.Text = "echarts";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // eCharts1
            // 
            this.eCharts1.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.eCharts1.Name = "eCharts1";
            this.eCharts1.Size = new System.Drawing.Size(0, 294);
            this.eCharts1.EChartsPress += new Swebui.Controls.EChartsPressEventHandler(this.eCharts1_EChartsPress);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(34, 350);
            this.button12.Name = "button12";
            this.button12.NumberOfLines = 0;
            this.button12.SelfLayout = Swebui.Controls.LayoutSelfPosition.Absolute;
            this.button12.Size = new System.Drawing.Size(104, 35);
            this.button12.Text = "设置深色主题";
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(185, 350);
            this.button13.Name = "button13";
            this.button13.NumberOfLines = 0;
            this.button13.SelfLayout = Swebui.Controls.LayoutSelfPosition.Absolute;
            this.button13.Size = new System.Drawing.Size(104, 35);
            this.button13.Text = "设置浅色主题";
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(341, 350);
            this.button14.Name = "button14";
            this.button14.NumberOfLines = 0;
            this.button14.SelfLayout = Swebui.Controls.LayoutSelfPosition.Absolute;
            this.button14.Size = new System.Drawing.Size(104, 35);
            this.button14.Text = "设置自定义主题";
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // panel7
            // 
            this.panel7.Border = new Swebui.Controls.Border(1F);
            this.panel7.BorderRadius = 4;
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.animationPanel,
            this.label6,
            this.button4,
            this.button5,
            this.button6,
            this.label7,
            this.button1,
            this.button2,
            this.button3,
            this.button7,
            this.label8,
            this.button11,
            this.button8,
            this.button9,
            this.button10});
            this.panel7.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.panel7.Margin = new Swebui.Controls.Margin(10F);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(500, 400);
            // 
            // label5
            // 
            this.label5.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label5.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(500, 35);
            this.label5.Text = "Animation";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // animationPanel
            // 
            this.animationPanel.BackColor = System.Drawing.Color.Black;
            this.animationPanel.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.animationPanel.Location = new System.Drawing.Point(84, 75);
            this.animationPanel.Name = "animationPanel";
            this.animationPanel.Size = new System.Drawing.Size(300, 21);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(84, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "Translate";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(349, 185);
            this.button4.Name = "button4";
            this.button4.NumberOfLines = 0;
            this.button4.Size = new System.Drawing.Size(50, 25);
            this.button4.Text = "play";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(349, 214);
            this.button5.Name = "button5";
            this.button5.NumberOfLines = 0;
            this.button5.Size = new System.Drawing.Size(50, 25);
            this.button5.Text = "pause";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(349, 243);
            this.button6.Name = "button6";
            this.button6.NumberOfLines = 0;
            this.button6.Size = new System.Drawing.Size(50, 25);
            this.button6.Text = "restart";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(84, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.Text = "Rotate";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 113);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(50, 25);
            this.button1.Text = "play";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 113);
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.Size = new System.Drawing.Size(50, 25);
            this.button2.Text = "pause";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 113);
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 0;
            this.button3.Size = new System.Drawing.Size(50, 25);
            this.button3.Text = "restart";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.Animation = "animation2";
            this.button7.Location = new System.Drawing.Point(204, 223);
            this.button7.Name = "button7";
            this.button7.NumberOfLines = 0;
            this.button7.Size = new System.Drawing.Size(67, 12);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(86, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.Text = "Scale";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // button11
            // 
            this.button11.Animation = "animation3";
            this.button11.Location = new System.Drawing.Point(204, 328);
            this.button11.Name = "button11";
            this.button11.NumberOfLines = 0;
            this.button11.Size = new System.Drawing.Size(67, 12);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(349, 296);
            this.button8.Name = "button8";
            this.button8.NumberOfLines = 0;
            this.button8.Size = new System.Drawing.Size(50, 25);
            this.button8.Text = "play";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(349, 325);
            this.button9.Name = "button9";
            this.button9.NumberOfLines = 0;
            this.button9.Size = new System.Drawing.Size(50, 25);
            this.button9.Text = "pause";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(349, 354);
            this.button10.Name = "button10";
            this.button10.NumberOfLines = 0;
            this.button10.Size = new System.Drawing.Size(50, 25);
            this.button10.Text = "restart";
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel8
            // 
            this.panel8.Border = new Swebui.Controls.Border(1F);
            this.panel8.BorderRadius = 4;
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label9,
            this.svg1});
            this.panel8.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.panel8.Margin = new Swebui.Controls.Margin(10F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(500, 400);
            // 
            // label9
            // 
            this.label9.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label9.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(500, 35);
            this.label9.Text = "Svg";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // svg1
            // 
            this.svg1.Location = new System.Drawing.Point(46, 44);
            this.svg1.Name = "svg1";
            this.svg1.Size = new System.Drawing.Size(399, 299);
            // 
            // panel9
            // 
            this.panel9.Border = new Swebui.Controls.Border(1F);
            this.panel9.BorderRadius = 4;
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label10,
            this.htmlView1,
            this.button15});
            this.panel9.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.panel9.Margin = new Swebui.Controls.Margin(10F);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(500, 700);
            // 
            // label10
            // 
            this.label10.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label10.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(500, 35);
            this.label10.Text = "HtmlView与Client.JSEval";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // htmlView1
            // 
            this.htmlView1.Location = new System.Drawing.Point(37, 60);
            this.htmlView1.Name = "htmlView1";
            this.htmlView1.Size = new System.Drawing.Size(432, 570);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(190, 318);
            this.button15.Name = "button15";
            this.button15.NumberOfLines = 0;
            this.button15.Size = new System.Drawing.Size(100, 35);
            this.button15.Text = "点击，使得方块移动";
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // panel11
            // 
            this.panel11.Border = new Swebui.Controls.Border(1F);
            this.panel11.BorderRadius = 4;
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label37,
            this.label38,
            this.button18,
            this.button19,
            this.button20,
            this.button21});
            this.panel11.Margin = new Swebui.Controls.Margin(10F);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(500, 700);
            // 
            // label37
            // 
            this.label37.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label37.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(0, 35);
            this.label37.Text = "TTS";
            this.label37.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label38
            // 
            this.label38.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label38.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(0, 35);
            this.label38.Text = "文本转语音插件";
            this.label38.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // button18
            // 
            this.button18.Margin = new Swebui.Controls.Margin(10F);
            this.button18.Name = "button18";
            this.button18.NumberOfLines = 0;
            this.button18.Size = new System.Drawing.Size(0, 35);
            this.button18.Text = "中文 1倍速";
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Margin = new Swebui.Controls.Margin(10F);
            this.button19.Name = "button19";
            this.button19.NumberOfLines = 0;
            this.button19.Size = new System.Drawing.Size(0, 35);
            this.button19.Text = "中文2倍速";
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Margin = new Swebui.Controls.Margin(10F);
            this.button20.Name = "button20";
            this.button20.NumberOfLines = 0;
            this.button20.Size = new System.Drawing.Size(0, 35);
            this.button20.Text = "英文1倍速";
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Margin = new Swebui.Controls.Margin(10F);
            this.button21.Name = "button21";
            this.button21.NumberOfLines = 0;
            this.button21.Size = new System.Drawing.Size(0, 35);
            this.button21.Text = "英文2倍速";
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // animation1
            // 
            this.animation1.Duration = 3000;
            animationItem1.Easing = Swebui.Controls.AnimationEasing.Linear;
            animationItem1.Value = "300";
            this.animation1.Items.AddRange(new Swebui.Controls.AnimationItem[] {
            animationItem1});
            this.animation1.Loop = -1;
            this.animation1.Name = "animation1";
            // 
            // animation2
            // 
            animationItem2.Type = Swebui.Controls.AnimationType.Rotate;
            animationItem2.Value = "90";
            this.animation2.Items.AddRange(new Swebui.Controls.AnimationItem[] {
            animationItem2});
            this.animation2.Loop = -1;
            this.animation2.Name = "animation2";
            // 
            // animation3
            // 
            animationItem3.Type = Swebui.Controls.AnimationType.Scale;
            animationItem3.Value = "1.8";
            this.animation3.Items.AddRange(new Swebui.Controls.AnimationItem[] {
            animationItem3});
            this.animation3.Loop = -1;
            this.animation3.Name = "animation3";
            // 
            // tts1
            // 
            this.tts1.Name = "tts1";
            // 
            // demoPlugins
            // 
            this.Components.AddRange(new Swebui.Controls.SwebComponent[] {
            this.animation1,
            this.animation2,
            this.animation3,
            this.tts1});
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 2900);
            this.Load += new System.EventHandler(this.demoPlugins_Load);
            this.Name = "demoPlugins";

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
        private Panel panel7;
        private Label label5;
        private Panel animationPanel;
        private Animation animation1;
        private Label label6;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button7;
        private Animation animation2;
        private Label label8;
        private Button button11;
        private Animation animation3;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button12;
        private Button button13;
        private Button button14;
        private Panel panel8;
        private Label label9;
        private Svg svg1;
        private Panel panel10;
        private Button button16;
        private Button button17;
        private Panel panel9;
        private Label label10;
        private HTMLView htmlView1;
        private Button button15;
        private TTS tts1;
        private Panel panel11;
        private Label label37;
        private Label label38;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
    }
}