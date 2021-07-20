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
            this.button1 = new Swebui.Controls.Button();
            this.lable1 = new Swebui.Controls.Label();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.DisplayMember = "Button";
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 35);
            // 
            // lable1
            // 
            this.lable1.DisplayMember = "Label";
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(0, 35);
            // 
            // demoListViewTemplate
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1,
            this.lable1});
            this.Size = new System.Drawing.Size(0, 70);

        }
        #endregion

        private Button button1;
        private Label lable1;
    }
}