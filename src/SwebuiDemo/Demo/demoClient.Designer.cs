using Swebui.Controls;
using System;

namespace SwebuiDemo.Demo
{
    partial class demoClient : Swebui.Controls.SwebUserControl
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
            this.button1 = new Swebui.Controls.Button();
            this.button2 = new Swebui.Controls.Button();
            this.button3 = new Swebui.Controls.Button();
            this.button4 = new Swebui.Controls.Button();
            this.button5 = new Swebui.Controls.Button();
            this.button6 = new Swebui.Controls.Button();
            this.button7 = new Swebui.Controls.Button();
            this.button9 = new Swebui.Controls.Button();
            this.panel2 = new Swebui.Controls.Panel();
            this.button8 = new Swebui.Controls.Button();
            this.button10 = new Swebui.Controls.Button();
            this.button11 = new Swebui.Controls.Button();
            this.button12 = new Swebui.Controls.Button();
            this.button13 = new Swebui.Controls.Button();
            this.button14 = new Swebui.Controls.Button();
            this.button15 = new Swebui.Controls.Button();
            this.button16 = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.button17 = new Swebui.Controls.Button();
            this.button18 = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1,
            this.button2,
            this.button3,
            this.button4,
            this.button5,
            this.button6,
            this.button7,
            this.button9});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            // 
            // button1
            // 
            this.button1.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.Text = "文件上传";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.Text = "文件下载（服务端文件）";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 0;
            this.button3.Size = new System.Drawing.Size(150, 35);
            this.button3.Text = "文件下载（网络文件）";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button4.Name = "button4";
            this.button4.NumberOfLines = 0;
            this.button4.Size = new System.Drawing.Size(150, 35);
            this.button4.Text = "修改网页Title";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button5.Name = "button5";
            this.button5.NumberOfLines = 0;
            this.button5.Size = new System.Drawing.Size(150, 35);
            this.button5.Text = "Messgaebox";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button6.Name = "button6";
            this.button6.NumberOfLines = 0;
            this.button6.Size = new System.Drawing.Size(150, 35);
            this.button6.Text = "RedirectUrl（新标签打开百度）";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button7.Name = "button7";
            this.button7.NumberOfLines = 0;
            this.button7.Size = new System.Drawing.Size(150, 35);
            this.button7.Text = "RedirectUrl（当前标签打开首页）";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button9.Name = "button9";
            this.button9.NumberOfLines = 0;
            this.button9.Size = new System.Drawing.Size(150, 35);
            this.button9.Text = "Print html";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button8,
            this.button10,
            this.button11,
            this.button12,
            this.button13,
            this.button14,
            this.button15,
            this.button16});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 0);
            // 
            // button8
            // 
            this.button8.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button8.Name = "button8";
            this.button8.NumberOfLines = 0;
            this.button8.Size = new System.Drawing.Size(150, 35);
            this.button8.Text = "Print pdf";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button10.Name = "button10";
            this.button10.NumberOfLines = 0;
            this.button10.Size = new System.Drawing.Size(150, 35);
            this.button10.Text = "Print 窗体";
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button11.Name = "button11";
            this.button11.NumberOfLines = 0;
            this.button11.Size = new System.Drawing.Size(150, 35);
            this.button11.Text = "JSAppend";
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button12.Name = "button12";
            this.button12.NumberOfLines = 0;
            this.button12.Size = new System.Drawing.Size(150, 35);
            this.button12.Text = "设置粘贴板";
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button13.Name = "button13";
            this.button13.NumberOfLines = 0;
            this.button13.Size = new System.Drawing.Size(150, 35);
            this.button13.Text = "获取粘贴板";
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button14.Name = "button14";
            this.button14.NumberOfLines = 0;
            this.button14.Size = new System.Drawing.Size(150, 35);
            this.button14.Text = "压缩上传";
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button15.Name = "button15";
            this.button15.NumberOfLines = 0;
            this.button15.Size = new System.Drawing.Size(150, 35);
            this.button15.Text = "原画上传";
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button16.Name = "button16";
            this.button16.NumberOfLines = 0;
            this.button16.Size = new System.Drawing.Size(150, 35);
            this.button16.Text = "播放音频";
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button17,
            this.button18});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 0);
            // 
            // button17
            // 
            this.button17.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button17.Name = "button17";
            this.button17.NumberOfLines = 0;
            this.button17.Size = new System.Drawing.Size(150, 35);
            this.button17.Text = "停止播放音频";
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Margin = new Swebui.Controls.Margin(10F, 10F, 0F, 0F);
            this.button18.Name = "button18";
            this.button18.NumberOfLines = 0;
            this.button18.Size = new System.Drawing.Size(150, 35);
            this.button18.Visible = false;
            // 
            // demoClient
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Name = "demoClient";

        }
        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button9;
        private Panel panel2;
        private Button button8;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Panel panel3;
        private Button button17;
        private Button button18;
    }
}