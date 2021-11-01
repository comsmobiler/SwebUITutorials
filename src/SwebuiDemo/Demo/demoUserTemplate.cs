using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Swebui;
using Swebui.Controls;

namespace SwebuiDemo.Demo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demoUserTemplate : SwebUserControl
    {
        private void demoUserTemplate_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("用户编号");
            dt.Columns.Add("用户名");
            dt.Columns.Add("性别");
            dt.Columns.Add("用户状态");


            XElement xe = XElement.Load(SwebResourceManager.DefaultDocumentPath + "/userinfo.xml");
            IEnumerable<XElement> elements = from ele in xe.Elements("user") select ele;
            foreach (var ele in elements)
            {
                dt.Rows.Add(ele.Element("id").Value, ele.Element("name").Value, ele.Element("sex").Value, ele.Element("status").Value);
            }
            gridView1.DataSource = dt;
            gridView1.DataBind();
        }

        private void comboBox1_ValueChanged(object sender, EventArgs e)
        {
            Toast(this.ToString());
        }

        private void treeView1_Press(object sender, TreeViewOnPressEventArgs e)
        {
            switch (e.TreeID)
            {
                case "1-1":
                    SelectData("sex", "男");
                    break;
                case "1-2":
                    SelectData("sex", "女");
                    break;
                case "2-1":
                    SelectData("status", "激活");
                    break;
                case "2-2":
                    SelectData("status", "未激活");
                    break;
                default:
                    SelectData();
                    break;
            }
        }

        public void SelectData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("用户编号");
            dt.Columns.Add("用户名");
            dt.Columns.Add("性别");
            dt.Columns.Add("用户状态");

            XElement xe = XElement.Load(SwebResourceManager.DefaultDocumentPath + "/userinfo.xml");
            IEnumerable<XElement> elements = from ele in xe.Elements("user") select ele;
            foreach (var ele in elements)
            {
                dt.Rows.Add(ele.Element("id").Value, ele.Element("name").Value, ele.Element("sex").Value, ele.Element("status").Value);
            }
            gridView1.Reload(dt);
            
        }
        public void SelectData(string prop, string value)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("用户编号");
            dt.Columns.Add("用户名");
            dt.Columns.Add("性别");
            dt.Columns.Add("用户状态");

            XElement xe = XElement.Load(SwebResourceManager.DefaultDocumentPath + "/userinfo.xml");
            IEnumerable<XElement> elements = from ele in xe.Elements("user") select ele;
            foreach (var ele in elements)
            {
                if (ele.Element(prop).Value == value)
                    dt.Rows.Add(ele.Element("id").Value, ele.Element("name").Value, ele.Element("sex").Value, ele.Element("status").Value);
            }
            gridView1.Reload(dt);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new demoEditUserTemplate());
            this.Parent.Controls.RemoveAt(0);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows != null && args.SelectedRows.Count > 0)
                {
                    string id = args.SelectedRows[0]["用户编号"].ToString();
                    User user = FindUserByID(id);
                    this.Parent.Controls.Add(new demoEditUserTemplate(user));
                    this.Parent.Controls.RemoveAt(0);

                }
                else
                {
                    Toast("请先选择需要编辑的行");
                }
            });

        }
        private User FindUserByID(string id)
        {
            User user = new User();
            XElement xe = XElement.Load(SwebResourceManager.DefaultDocumentPath + "/userinfo.xml");
            IEnumerable<XElement> elements = from ele in xe.Elements("user") select ele;
            foreach (var ele in elements)
            {
                if (id == ele.Element("id").Value)
                {
                    user.Id = ele.Element("id").Value;
                    user.Name = ele.Element("name").Value;
                    user.Psd = ele.Element("psd").Value;
                    user.Language = ele.Element("language").Value;
                    user.Sex = ele.Element("sex").Value;
                    user.Status = ele.Element("status").Value;
                    user.Authentication = ele.Element("authentication").Value;
                    user.Birth = ele.Element("birth").Value;
                    user.Phone = ele.Element("phone").Value;
                    user.Develop = ele.Element("develop").Value;
                    user.Command = ele.Element("command").Value;
                    user.CommandType = ele.Element("commandtype").Value;
                    user.Other = ele.Element("other").Value;
                    user.IsAD = ele.Element("isad").Value;
                    user.Extend2 = ele.Element("extend2").Value;
                    user.Extend3 = ele.Element("extend3").Value;
                    user.Avtar = ele.Element("avtar").Value;
                    break;
                }
            }
            return user;
        }
    }
}