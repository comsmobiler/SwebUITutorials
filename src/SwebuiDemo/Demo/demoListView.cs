using System;
using System.Collections.Generic;
using System.Data;
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
            DataTable dt = new DataTable();
            dt.Columns.Add("img");
            dt.Columns.Add("title");
            dt.Columns.Add("subtitle");
            dt.Columns.Add("num");
            dt.Columns.Add("date");
            for (int i = 0; i < 10; i++)
            {
                dt.Rows.Add("user_image.png", "请教一下关于项目部署的问题", "最近尝试了贵公司的产品，用C#开发手机端应用的创意非常赞", i * 10 + 1, DateTime.Now.ToString("yyyy/MM/dd"));
            }
            listView1.DataSource = dt;
            listView1.DataBind();
            this.listView1.DataBind();
        }
    }
}