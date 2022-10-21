using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Swebui.Controls;
using SwebuiDemo.Demo;

namespace SwebuiDemo
{
    partial class SwebForm1 : Swebui.Controls.SwebForm
    {
        public SwebForm1() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void SwebForm1_Load(object sender, EventArgs e)
        {
            var systemItem = new MenuItem("system", "系统设置", "gear");
            systemItem.Items.Add(new MenuItem("user", "用户设置", "user") { Tag = typeof(demoUserTemplate) });
            this.menuView1.Items.Add(systemItem);
            var demoItem = new MenuItem("demo", "示例", "bookmark");
            demoItem.Items.Add(new MenuItem("BaseControls", "BaseControls") { Tag = typeof(demoTemplate) });
            demoItem.Items.Add(new MenuItem("GridView", "GridView") { Tag = typeof(demoGrid) });
            demoItem.Items.Add(new MenuItem("ListView", "ListView") { Tag = typeof(demoListView) });
            demoItem.Items.Add(new MenuItem("WebView", "WebView") { Tag = typeof(demoWeb) });
            demoItem.Items.Add(new MenuItem("MapView", "MapView") { Tag = typeof(demoMap) });
            demoItem.Items.Add(new MenuItem("PDFAndHtml", "PDFAndHtml") { Tag = typeof(demoPDFAndHtml) });
            demoItem.Items.Add(new MenuItem("OtherControls", "OtherControls") { Tag = typeof(demoPlugins) });
            demoItem.Items.Add(new MenuItem("自定义控件", "自定义控件") { Tag = typeof(demoCustm) });
            demoItem.Items.Add(new MenuItem("Client", "Client") { Tag = typeof(demoClient) });

            this.menuView1.Items.Add(demoItem);
        }

        private List<string> titleList = new List<string>();
        private Dictionary<MenuItem, int> orderDict = new Dictionary<MenuItem, int>();
        private List<MenuItem> itemsList = new List<MenuItem>();
        private int dictIndex = 0;
        private void menuView1_MenuItemClick(object sender, MenuViewItemClickEventArgs e)
        {
            if (e.Item != null && e.Item.Tag != null)
            {
                var existTagControl = this.tabPageView1.Controls.Find(e.Item.Id);
                if (existTagControl != null)
                {
                    this.tabPageView1.PageIndex = this.tabPageView1.Controls.IndexOf(existTagControl);
                }
                else
                {
                    TabPageControl tagControl = new TabPageControl();
                    tagControl.Name = e.Item.Id;
                    tagControl.Padding = new Padding(20);
                    tagControl.Border = new Border(0, 1, 0, 0);
                    Type menuType = e.Item.Tag as Type;
                    SwebControl menuControl = Activator.CreateInstance(menuType) as SwebControl;
                    menuControl.Flex = 1;
                    menuControl.BackColor = System.Drawing.Color.White;
                    tagControl.Controls.Add(menuControl);
                    titleList.Add(e.Item.Text);

                    this.tabPageView1.Controls.Add(tagControl);
                    this.tabPageView1.Titles = titleList.ToArray();
                    this.tabPageView1.PageIndex = this.tabPageView1.Controls.Count - 1;
                }
            }
            if (orderDict.ContainsKey(e.Item) == false)
            {
                orderDict.Add(e.Item, dictIndex);
                dictIndex++;
                itemsList.Add(e.Item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.palMenu.Width = this.palMenu.Width >= 200 ? 70 : 200;
        }

        private void tabPageView1_PageClosed(object sender, TabPageViewClosedEventArgs e)
        {
            titleList.RemoveAt(e.PageIndex);
            orderDict.Remove(itemsList[e.PageIndex]);
            itemsList.RemoveAt(e.PageIndex);
        }

        private void tabPageView1_PageChanged(object sender, TabPageViewChangedEventArgs e)
        {
            if (itemsList.Count > e.PageIndex)
            {
                menuView1.DefaultSelectedItem = itemsList[e.PageIndex];
            }
            else {
                menuView1.DefaultSelectedItem = null;
            }
        }

        private void SwebForm1_CustomCallBack(object sender, CustomCallBackEventArgs e)
        {
            Toast("SwebForm1 窗体接收到："+e.Params.ToString());
        }
    }
}