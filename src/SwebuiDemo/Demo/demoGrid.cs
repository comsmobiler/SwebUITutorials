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
            this.gridView1.DataSource = DemoGlobal.GetListViewTable(this.Client.SessionID,100);
            this.gridView1.DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridView1.AllowFiltering = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<GridSearchData> searchDatas = new List<GridSearchData>();
            searchDatas.Add(new GridSearchData() { Field = "Label", SearchValue = new string[] { "1", "2" }, Predicate = Predicate.Or });
            searchDatas.Add(new GridSearchData() { Field = "Switch", SearchValue = new string[] { "true" }, Predicate = Predicate.And });
            gridView1.SearchRow(searchDatas);
        }
    }
}