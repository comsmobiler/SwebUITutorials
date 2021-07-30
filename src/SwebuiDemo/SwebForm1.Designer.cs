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
            this.Label1 = new Swebui.Controls.Label();
            this.menuView1 = new Swebui.Controls.MenuView();
            this.panel1 = new Swebui.Controls.Panel();
            this.panel2 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
            this.Label2 = new Swebui.Controls.Label();
            this.button2 = new Swebui.Controls.Button();
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
            this.image1,
            this.Label1});
            this.palUser.Name = "palUser";
            this.palUser.Size = new System.Drawing.Size(0, 100);
            // 
            // image1
            // 
            this.image1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "logo.png";
            this.image1.Size = new System.Drawing.Size(70, 50);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // Label1
            // 
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 50);
            this.Label1.Text = "管理员";
            this.Label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // menuView1
            // 
            this.menuView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.menuView1.DefaultIcon = "tasks";
            this.menuView1.Flex = 1;
            this.menuView1.Name = "menuView1";
            this.menuView1.Size = new System.Drawing.Size(0, 0);
            this.menuView1.Theme = Swebui.Controls.MenuViewTheme.Dark;
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
            this.Label2,
            this.button2});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 53);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(179)))), ((int)(((byte)(148)))));
            this.button1.IconName = "fa fa-bars";
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(51, 35);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label2
            // 
            this.Label2.Flex = 1;
            this.Label2.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 35);
            this.Label2.Text = "Swebui";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(179)))), ((int)(((byte)(148)))));
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Text = "退出";
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
            this.Load += new System.EventHandler(this.SwebForm1_Load);

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
        private Swebui.Controls.Label Label1;
        private Swebui.Controls.Label Label2;
        private Swebui.Controls.Button button2;
    }
}