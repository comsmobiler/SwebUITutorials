using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class tabUserLayout2: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public tabUserLayout2() : base()
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
            Swebui.Controls.ComboBoxItem comboBoxItem1 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem2 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem3 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem4 = new Swebui.Controls.ComboBoxItem();
            this.panel4 = new Swebui.Controls.Panel();
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.comboBox5 = new Swebui.Controls.ComboBox();
            this.textBox1 = new Swebui.Controls.TextBox();
            this.comboBox6 = new Swebui.Controls.ComboBox();
            this.panel3 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.textBox2 = new Swebui.Controls.TextBox();
            this.panel8 = new Swebui.Controls.Panel();
            this.checkBox1 = new Swebui.Controls.CheckBox();
            this.textBox3 = new Swebui.Controls.TextBox();
            this.panel6 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.textBox4 = new Swebui.Controls.TextBox();
            this.textBox5 = new Swebui.Controls.TextBox();
            this.label10 = new Swebui.Controls.Label();
            // 
            // panel4
            // 
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2,
            this.label3});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 35);
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.Flex = 1;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.label1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "开发模式";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Bold = true;
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "主页命令编号";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Bold = true;
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.label3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.Text = "主页命令类型";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.comboBox5,
            this.textBox1,
            this.comboBox6});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Name = "panel2";
            this.panel2.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel2.Size = new System.Drawing.Size(0, 35);
            // 
            // comboBox5
            // 
            this.comboBox5.Border = new Swebui.Controls.Border(1F);
            this.comboBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.comboBox5.Flex = 1;
            comboBoxItem1.Id = "1";
            comboBoxItem1.Text = "系统开发者";
            comboBoxItem2.Id = "2";
            comboBoxItem2.Text = "普通用户";
            this.comboBox5.Items.AddRange(new Swebui.Controls.ComboBoxItem[] {
            comboBoxItem1,
            comboBoxItem2});
            this.comboBox5.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.comboBox5.Placeholder = "";
            this.comboBox5.PopupHeight = 0;
            this.comboBox5.Size = new System.Drawing.Size(100, 35);
            this.comboBox5.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Border = new Swebui.Controls.Border(1F);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.textBox1.Flex = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            // 
            // comboBox6
            // 
            this.comboBox6.Border = new Swebui.Controls.Border(1F);
            this.comboBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.comboBox6.Flex = 1;
            comboBoxItem3.Id = "1";
            comboBoxItem3.Text = "正常";
            comboBoxItem4.Id = "2";
            comboBoxItem4.Text = "特殊";
            this.comboBox6.Items.AddRange(new Swebui.Controls.ComboBoxItem[] {
            comboBoxItem3,
            comboBoxItem4});
            this.comboBox6.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.comboBox6.Placeholder = "";
            this.comboBox6.PopupHeight = 0;
            this.comboBox6.Size = new System.Drawing.Size(100, 35);
            this.comboBox6.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.label5,
            this.label6});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 35);
            // 
            // label4
            // 
            this.label4.Bold = true;
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.label4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 35);
            this.label4.Text = "其他设置";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Bold = true;
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 35);
            this.label5.Text = "是否机动人员";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Bold = true;
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.label6.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 35);
            this.label6.Text = "扩张属性2";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.textBox2,
            this.panel8,
            this.textBox3});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 35);
            // 
            // textBox2
            // 
            this.textBox2.Border = new Swebui.Controls.Border(1F);
            this.textBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.textBox2.Flex = 1;
            this.textBox2.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.textBox2.Name = "textBox2";
            this.textBox2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.textBox2.Size = new System.Drawing.Size(100, 35);
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.checkBox1});
            this.panel8.Flex = 1;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 35);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.BorderColor = System.Drawing.Color.Black;
            this.checkBox1.BorderRadius = 0;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(31, 35);
            // 
            // textBox3
            // 
            this.textBox3.Border = new Swebui.Controls.Border(1F);
            this.textBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.textBox3.Flex = 1;
            this.textBox3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.textBox3.Name = "textBox3";
            this.textBox3.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.textBox3.Size = new System.Drawing.Size(100, 35);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7,
            this.label8,
            this.label9});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // label7
            // 
            this.label7.Bold = true;
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 35);
            this.label7.Text = "扩展属性3";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Bold = true;
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 35);
            this.label8.Text = "备注";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Bold = true;
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.label9.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 35);
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.textBox4,
            this.textBox5,
            this.label10});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 35);
            // 
            // textBox4
            // 
            this.textBox4.Border = new Swebui.Controls.Border(1F);
            this.textBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.textBox4.Flex = 1;
            this.textBox4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.textBox4.Name = "textBox4";
            this.textBox4.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.textBox4.Size = new System.Drawing.Size(100, 35);
            // 
            // textBox5
            // 
            this.textBox5.Border = new Swebui.Controls.Border(1F);
            this.textBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.textBox5.Flex = 1;
            this.textBox5.Name = "textBox5";
            this.textBox5.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.textBox5.Size = new System.Drawing.Size(100, 35);
            // 
            // label10
            // 
            this.label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.label10.Flex = 1;
            this.label10.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label10.Name = "label10";
            this.label10.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.label10.Size = new System.Drawing.Size(100, 35);
            // 
            // tabUserLayout2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel5,
            this.panel6,
            this.panel7});
            this.Flex = 1;
            this.Padding = new Swebui.Controls.Padding(10F);
            this.Load += new System.EventHandler(this.demoUserTemplate_Load);
            this.Name = "tabUserLayout2";

        }
        #endregion
        private Panel panel4 = new Panel();
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel5;
        private Panel panel6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel7;
        private ComboBox comboBox5;
        private TextBox textBox1;
        private ComboBox comboBox6;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label10;
        private Panel panel8;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}