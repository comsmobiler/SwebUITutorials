using System;

namespace SwebuiDemo
{
    partial class SwebForm1 : Swebui.Controls.SwebForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.palMenu = new Swebui.Controls.Panel();
            this.palUser = new Swebui.Controls.Panel();
            this.image1 = new Swebui.Controls.Image();
            this.menuView1 = new Swebui.Controls.MenuView();
            this.panel1 = new Swebui.Controls.Panel();
            this.panel2 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
            this.textbox1 = new Swebui.Controls.TextBox();
            this.label2 = new Swebui.Controls.Label();
            this.button2 = new Swebui.Controls.Button();
            this.button3 = new Swebui.Controls.Button();
            this.button4 = new Swebui.Controls.Button();
            this.button5 = new Swebui.Controls.Button();
            this.button6 = new Swebui.Controls.Button();
            this.tabPageView1 = new Swebui.Controls.TabPageView();
            // 
            // palMenu
            // 
            this.palMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.palMenu.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.palUser,
            this.menuView1});
            this.palMenu.Name = "palMenu";
            this.palMenu.Size = new System.Drawing.Size(200, 0);
            // 
            // palUser
            // 
            this.palUser.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1});
            this.palUser.Name = "palUser";
            this.palUser.Size = new System.Drawing.Size(0, 60);
            // 
            // image1
            // 
            this.image1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "logo.png";
            this.image1.Size = new System.Drawing.Size(70, 50);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // menuView1
            // 
            this.menuView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.menuView1.Color = System.Drawing.Color.White;
            this.menuView1.DefaultIcon = "tasks";
            this.menuView1.Flex = 1;
            this.menuView1.Name = "menuView1";
            this.menuView1.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.menuView1.Size = new System.Drawing.Size(0, 0);
            this.menuView1.SubColor = System.Drawing.Color.White;
            this.menuView1.SubSelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.menuView1.MenuItemClick += new Swebui.Controls.MenuViewItemClickEventHandler(this.menuView1_MenuItemClick);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.tabPageView1});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1,
            this.textbox1,
            this.label2,
            this.button2,
            this.button3,
            this.button4,
            this.button5,
            this.button6});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 60);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(179)))), ((int)(((byte)(148)))));
            this.button1.BorderRadius = 4;
            this.button1.IconName = "fa fa-bars";
            this.button1.Margin = new Swebui.Controls.Margin(15F, 0F, 0F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.button1.Size = new System.Drawing.Size(38, 30);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox1
            // 
            this.textbox1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(200, 35);
            this.textbox1.WaterMarkText = "请输入Command";
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Bold = true;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.button2.IconName = "fa fa-external-link";
            this.button2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button2.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button2.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.button2.Size = new System.Drawing.Size(0, 60);
            this.button2.Text = "Designer";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Bold = true;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.button3.IconName = "fa fa-cog";
            this.button3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 0;
            this.button3.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button3.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button3.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.button3.Size = new System.Drawing.Size(0, 60);
            this.button3.Text = "DevSettings";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Bold = true;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.button4.IconName = "fa fa-sign-out";
            this.button4.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button4.Name = "button4";
            this.button4.NumberOfLines = 0;
            this.button4.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button4.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button4.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.button4.Size = new System.Drawing.Size(0, 60);
            this.button4.Text = "退出";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Bold = true;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.button5.IconName = "fa fa-tasks";
            this.button5.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button5.Name = "button5";
            this.button5.NumberOfLines = 0;
            this.button5.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button5.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button5.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.button5.Size = new System.Drawing.Size(0, 60);
            this.button5.Text = "主题";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Bold = true;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.button6.IconName = "fa fa-user";
            this.button6.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button6.Name = "button6";
            this.button6.NumberOfLines = 0;
            this.button6.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.button6.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button6.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.button6.Size = new System.Drawing.Size(0, 60);
            this.button6.Text = "admin";
            // 
            // tabPageView1
            // 
            this.tabPageView1.Flex = 1;
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndex = 0;
            this.tabPageView1.PageIndicator = Swebui.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(0, 100);
            this.tabPageView1.PageClosed += new Swebui.Controls.TabPageViewClosedEventHandler(this.tabPageView1_PageClosed);
            this.tabPageView1.PageChanged += new Swebui.Controls.TabPageViewChangedEventHandler(this.tabPageView1_PageChanged);
            // 
            // SwebForm1
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.palMenu,
            this.panel1});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Size = new System.Drawing.Size(1000, 600);
            this.CustomCallBack += new Swebui.Controls.CustomCallBackEventHandler(this.SwebForm1_CustomCallBack);
            this.Load += new System.EventHandler(this.SwebForm1_Load);
            this.Name = "SwebForm1";

        }
        #endregion

        private Swebui.Controls.Panel palMenu;
        private Swebui.Controls.Panel panel1;
        private Swebui.Controls.Panel panel2;
        private Swebui.Controls.Button button1;
        private Swebui.Controls.TabPageView tabPageView1;
        private Swebui.Controls.Panel palUser;
        private Swebui.Controls.MenuView menuView1;
        private Swebui.Controls.Image image1;
        private Swebui.Controls.TextBox textbox1;
        private Swebui.Controls.Label label2;
        private Swebui.Controls.Button button2;
        private Swebui.Controls.Button button3;
        private Swebui.Controls.Button button4;
        private Swebui.Controls.Button button5;
        private Swebui.Controls.Button button6;
    }
}