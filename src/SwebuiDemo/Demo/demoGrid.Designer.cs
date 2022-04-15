using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class demoGrid : SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public demoGrid()
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
            Swebui.Controls.GridViewColumn gridViewColumn21 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn22 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn23 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn24 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn25 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn26 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn27 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn28 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn29 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn30 = new Swebui.Controls.GridViewColumn();
            this.gridView1 = new Swebui.Controls.GridView();
            this.panel1 = new Swebui.Controls.Panel();
            this.button2 = new Swebui.Controls.Button();
            // 
            // gridView1
            // 
            this.gridView1.AllowFiltering = true;
            this.gridView1.AllowPaging = true;
            gridViewColumn21.DisplayMember = "Label";
            gridViewColumn21.HeaderText = "Label";
            gridViewColumn22.DisplayMember = "Button";
            gridViewColumn22.HeaderText = "Button";
            gridViewColumn23.DisplayMember = "TextBox";
            gridViewColumn23.HeaderText = "TextBox";
            gridViewColumn24.DisplayMember = "Progress";
            gridViewColumn24.HeaderText = "Progress";
            gridViewColumn25.DisplayMember = "Slider";
            gridViewColumn25.HeaderText = "Slider";
            gridViewColumn26.DisplayMember = "Image";
            gridViewColumn26.HeaderText = "Image";
            gridViewColumn26.Type = Swebui.Controls.GridViewCellType.Image;
            gridViewColumn27.DisplayMember = "FontIcon";
            gridViewColumn27.HeaderText = "FontIcon";
            gridViewColumn28.DisplayMember = "CheckBox";
            gridViewColumn28.HeaderText = "CheckBox";
            gridViewColumn29.DisplayMember = "Switch";
            gridViewColumn29.HeaderText = "Switch";
            gridViewColumn30.DisplayMember = "Section";
            gridViewColumn30.HeaderText = "Section";
            this.gridView1.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn21,
            gridViewColumn22,
            gridViewColumn23,
            gridViewColumn24,
            gridViewColumn25,
            gridViewColumn26,
            gridViewColumn27,
            gridViewColumn28,
            gridViewColumn29,
            gridViewColumn30});
            this.gridView1.DataSource = null;
            this.gridView1.Flex = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.PageSetting.PageSize = 10;
            this.gridView1.RowHeight = 0;
            this.gridView1.RowWidth = 0;
            this.gridView1.Size = new System.Drawing.Size(0, 30);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button2});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 60);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.button2.Border = new Swebui.Controls.Border(1F);
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.button2.Location = new System.Drawing.Point(7, 0);
            this.button2.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.Padding = new Swebui.Controls.Padding(5F, 0F, 5F, 0F);
            this.button2.Size = new System.Drawing.Size(0, 42);
            this.button2.Text = "点击 搜索 Label 列含有1或2 并且Switch =true 的数据";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // demoGrid
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.gridView1});
            this.Padding = new Swebui.Controls.Padding(10F, 15F, 10F, 15F);
            this.Load += new System.EventHandler(this.demoGrid_Load);

        }
        #endregion

        private GridView gridView1;
        private Panel panel1;
        private Button button2;
    }
}