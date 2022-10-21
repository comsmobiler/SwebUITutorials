using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class demoListView : SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public demoListView()
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
            this.label1 = new Swebui.Controls.Label();
            this.listView1 = new Swebui.Controls.ListView();
            this.panel2 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.sectionListView1 = new Swebui.Controls.SectionListView();
            // 
            // panel1
            // 
            this.panel1.Border = new Swebui.Controls.Border(1F);
            this.panel1.BorderRadius = 8;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.listView1});
            this.panel1.Flex = 1;
            this.panel1.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 0);
            // 
            // label1
            // 
            this.label1.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "ListView";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // listView1
            // 
            this.listView1.Flex = 1;
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(0, 300);
            // 
            // panel2
            // 
            this.panel2.Border = new Swebui.Controls.Border(1F);
            this.panel2.BorderRadius = 8;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.sectionListView1});
            this.panel2.Flex = 1;
            this.panel2.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 0);
            // 
            // label2
            // 
            this.label2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.Text = "SectionListView";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // sectionListView1
            // 
            this.sectionListView1.Flex = 1;
            this.sectionListView1.Name = "sectionListView1";
            this.sectionListView1.SectionMember = "SectLab";
            this.sectionListView1.Size = new System.Drawing.Size(0, 300);
            // 
            // demoListView
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Padding = new Swebui.Controls.Padding(10F);
            this.Load += new System.EventHandler(this.demoTemplate_Load);
            this.Name = "demoListView";

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private ListView listView1;
        private Panel panel2;
        private Label label2;
        private SectionListView sectionListView1;
    }
}