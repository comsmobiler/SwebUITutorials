using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
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

            DataTable dt1 = new DataTable();
            dt1.Columns.Add("SectLab");
            dt1.Columns.Add("img");
            dt1.Columns.Add("title");
            dt1.Columns.Add("subtitle");
            dt1.Columns.Add("num");
            dt1.Columns.Add("date");
            for (int i = 0; i < 10; i++)
            {
                dt1.Rows.Add("Sect " + i, "user_image.png", "请教一下关于项目部署的问题", "最近尝试了贵公司的产品，用C#开发手机端应用的创意非常赞", i * 10 + 1, DateTime.Now.ToString("yyyy/MM/dd"));
            }
            sectionListView1.SectionControl = new SectLayout();
            sectionListView1.TemplateControl = new demoListViewTemplate();

            sectionListView1.DataSource = dt1;
            sectionListView1.DataBind();
            Thread thread = new Thread(() =>
            {
              
                    Thread.Sleep(2000);
                sectionListView1.AutoScroll(new AutoScrollParameter() { Type = AutoScrollType.Repeat, Speed = 10 });


                Console.WriteLine("完成！");
            });
            thread.Start();
          
        }
    }
}