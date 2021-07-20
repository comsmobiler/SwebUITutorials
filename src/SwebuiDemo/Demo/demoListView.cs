using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swebui.Controls;

namespace SwebuiDemo.Demo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demoListView : SwebUserControl
    {
        private void demoTemplate_Load(object sender, EventArgs e)
        {
            this.listView1.TemplateControl = new demoListViewTemplate();
            this.listView1.DataSource = DemoGlobal.GetListViewTable(20);
            this.listView1.DataBind();
        }
    }
}