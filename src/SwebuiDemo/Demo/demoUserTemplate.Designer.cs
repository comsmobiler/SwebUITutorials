using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class demoUserTemplate : SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public demoUserTemplate()
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
            Swebui.Controls.ComboBoxItem comboBoxItem1 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem2 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem3 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.TreeViewNode treeViewNode1 = new Swebui.Controls.TreeViewNode();
            Swebui.Controls.TreeViewNode treeViewNode2 = new Swebui.Controls.TreeViewNode();
            Swebui.Controls.TreeViewNode treeViewNode3 = new Swebui.Controls.TreeViewNode();
            Swebui.Controls.TreeViewNode treeViewNode4 = new Swebui.Controls.TreeViewNode();
            Swebui.Controls.TreeViewNode treeViewNode5 = new Swebui.Controls.TreeViewNode();
            Swebui.Controls.TreeViewNode treeViewNode6 = new Swebui.Controls.TreeViewNode();
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.comboBox1 = new Swebui.Controls.ComboBox();
            this.textBox1 = new Swebui.Controls.TextBox();
            this.button2 = new Swebui.Controls.Button();
            this.panel4 = new Swebui.Controls.Panel();
            this.panel2 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
            this.button4 = new Swebui.Controls.Button();
            this.button3 = new Swebui.Controls.Button();
            this.button5 = new Swebui.Controls.Button();
            this.button6 = new Swebui.Controls.Button();
            this.button7 = new Swebui.Controls.Button();
            this.button8 = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.treeView1 = new Swebui.Controls.TreeView();
            this.panel6 = new Swebui.Controls.Panel();
            this.gridView1 = new Swebui.Controls.GridView();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.panel5,
            this.comboBox1,
            this.textBox1,
            this.button2});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Size = new System.Drawing.Size(0, 35);
            // 
            // label1
            // 
            this.label1.FontSize = 24F;
            this.label1.LineHeight = 0F;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.Text = "用户列表";
            // 
            // panel5
            // 
            this.panel5.Flex = 1;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 20);
            // 
            // comboBox1
            // 
            this.comboBox1.Border = new Swebui.Controls.Border(1F);
            this.comboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            comboBoxItem1.Id = "1";
            comboBoxItem1.Text = "最多显示10";
            comboBoxItem2.Id = "2";
            comboBoxItem2.Text = "最多显示20";
            comboBoxItem3.Id = "3";
            comboBoxItem3.Text = "不限制";
            this.comboBox1.Items.AddRange(new Swebui.Controls.ComboBoxItem[] {
            comboBoxItem1,
            comboBoxItem2,
            comboBoxItem3});
            this.comboBox1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.comboBox1.Placeholder = "";
            this.comboBox1.PopupHeight = 0;
            this.comboBox1.Size = new System.Drawing.Size(183, 30);
            this.comboBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.Border = new Swebui.Controls.Border(1F);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.textBox1.Size = new System.Drawing.Size(183, 30);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(179)))), ((int)(((byte)(148)))));
            this.button2.LineHeight = 0F;
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button2.Size = new System.Drawing.Size(0, 30);
            this.button2.Text = "搜索";
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
            this.button4,
            this.button3,
            this.button5,
            this.button6,
            this.button7,
            this.button8});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 15F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 26);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Border = new Swebui.Controls.Border(1F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.IconName = "fa fa-plus";
            this.button1.LineHeight = 0F;
            this.button1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button1.Size = new System.Drawing.Size(0, 26);
            this.button1.Text = "新增";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Border = new Swebui.Controls.Border(1F);
            this.button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.button4.ForeColor = System.Drawing.Color.DimGray;
            this.button4.IconName = "fa fa-pencil-square-o";
            this.button4.LineHeight = 0F;
            this.button4.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button4.Name = "button4";
            this.button4.NumberOfLines = 0;
            this.button4.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button4.Size = new System.Drawing.Size(0, 26);
            this.button4.Text = "复制";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Border = new Swebui.Controls.Border(1F);
            this.button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.IconName = "fa fa-pencil-square-o";
            this.button3.LineHeight = 0F;
            this.button3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 0;
            this.button3.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button3.Size = new System.Drawing.Size(0, 26);
            this.button3.Text = "编辑";
            this.button3.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Border = new Swebui.Controls.Border(1F);
            this.button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.button5.ForeColor = System.Drawing.Color.DimGray;
            this.button5.IconName = "fa fa-download";
            this.button5.LineHeight = 0F;
            this.button5.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button5.Name = "button5";
            this.button5.NumberOfLines = 0;
            this.button5.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button5.Size = new System.Drawing.Size(0, 26);
            this.button5.Text = "导入/导出";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Border = new Swebui.Controls.Border(1F);
            this.button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.button6.ForeColor = System.Drawing.Color.DimGray;
            this.button6.IconName = "fa fa-refresh";
            this.button6.LineHeight = 0F;
            this.button6.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button6.Name = "button6";
            this.button6.NumberOfLines = 0;
            this.button6.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button6.Size = new System.Drawing.Size(0, 26);
            this.button6.Text = "刷新";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Border = new Swebui.Controls.Border(1F);
            this.button7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.button7.ForeColor = System.Drawing.Color.DimGray;
            this.button7.IconName = "fa fa-floppy-o";
            this.button7.LineHeight = 0F;
            this.button7.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button7.Name = "button7";
            this.button7.NumberOfLines = 0;
            this.button7.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button7.Size = new System.Drawing.Size(0, 26);
            this.button7.Text = "保存布局";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Border = new Swebui.Controls.Border(1F);
            this.button8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.button8.ForeColor = System.Drawing.Color.DimGray;
            this.button8.IconName = "fa fa-trash";
            this.button8.LineHeight = 0F;
            this.button8.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button8.Name = "button8";
            this.button8.NumberOfLines = 0;
            this.button8.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button8.Size = new System.Drawing.Size(0, 26);
            this.button8.Text = "清除布局";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.treeView1,
            this.panel6});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Name = "treeView1";
            treeViewNode2.Text = "男";
            treeViewNode2.TreeID = "1-1";
            treeViewNode3.Text = "女";
            treeViewNode3.TreeID = "1-2";
            treeViewNode1.Nodes.AddRange(new Swebui.Controls.TreeViewNode[] {
            treeViewNode2,
            treeViewNode3});
            treeViewNode1.Text = "用户性别";
            treeViewNode1.TreeID = "1";
            treeViewNode5.Text = "激活";
            treeViewNode5.TreeID = "2-1";
            treeViewNode6.Text = "未激活";
            treeViewNode6.TreeID = "2-2";
            treeViewNode4.Nodes.AddRange(new Swebui.Controls.TreeViewNode[] {
            treeViewNode5,
            treeViewNode6});
            treeViewNode4.Text = "用户状态";
            treeViewNode4.TreeID = "2";
            this.treeView1.Nodes.AddRange(new Swebui.Controls.TreeViewNode[] {
            treeViewNode1,
            treeViewNode4});
            this.treeView1.Size = new System.Drawing.Size(200, 0);
            this.treeView1.Press += new Swebui.Controls.TreeView.TreeViewOnPressEventHandler(this.treeView1_Press);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.gridView1});
            this.panel6.Flex = 1;
            this.panel6.Name = "panel6";
            this.panel6.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel6.Padding = new Swebui.Controls.Padding(15F);
            this.panel6.Size = new System.Drawing.Size(300, 0);
            // 
            // gridView1
            // 
            this.gridView1.AllowPaging = true;
            this.gridView1.BackColor = System.Drawing.Color.White;
            this.gridView1.DataSource = null;
            this.gridView1.Flex = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowWidth = 0;
            this.gridView1.Size = new System.Drawing.Size(0, 30);
            // 
            // demoUserTemplate
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3});
            this.Padding = new Swebui.Controls.Padding(10F, 15F, 10F, 15F);
            this.Wrap = Swebui.Controls.LayoutWrap.Wrap;
            this.Load += new System.EventHandler(this.demoUserTemplate_Load);

        }
        #endregion

        private Panel panel1 = new Panel();
        private Panel panel2 = new Panel();
        private Panel panel4 = new Panel();

        private Panel panel3 = new Panel();
        private Label label1;
        private Button button1;
        private Button button4;
        private TreeView treeView1;
        private Panel panel6;
        private Panel panel5;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button2;
        private GridView gridView1;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}