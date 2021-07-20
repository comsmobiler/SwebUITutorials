using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swebui.Controls;

namespace SwebuiDemo.Demo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demoGrid : SwebUserControl
    {
        private void demoGrid_Load(object sender, EventArgs e)
        {
            this.gridView1.DataSource = DemoGlobal.GetListViewTable(100);
            this.gridView1.DataBind();
        }
    }
}