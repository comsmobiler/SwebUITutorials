using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class demoPDFAndHtml : SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public demoPDFAndHtml()
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
            this.pdfView1 = new Swebui.Controls.PDFView();
            this.panel2 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.htmlView1 = new Swebui.Controls.HTMLView();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.pdfView1});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 0);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "PDFView";
            // 
            // pdfView1
            // 
            this.pdfView1.Flex = 1;
            this.pdfView1.Name = "pdfView1";
            this.pdfView1.ResourceID = "нд╪Ч_1";
            this.pdfView1.Size = new System.Drawing.Size(0, 300);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.htmlView1});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 0);
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.Text = "HTMLView";
            // 
            // htmlView1
            // 
            this.htmlView1.Flex = 1;
            this.htmlView1.Name = "htmlView1";
            this.htmlView1.Size = new System.Drawing.Size(0, 255);
            // 
            // demoPDFAndHtml
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Load += new System.EventHandler(this.demoPDFAndHtml_Load);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private HTMLView htmlView1;
        private PDFView pdfView1;
    }
}