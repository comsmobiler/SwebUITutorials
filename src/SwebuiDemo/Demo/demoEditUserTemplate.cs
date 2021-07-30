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
    partial class demoEditUserTemplate : SwebUserControl
    {
        private string PageStatus = "";
        private User user = new User();
        public demoEditUserTemplate() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            PageStatus = "add";
        }
        public demoEditUserTemplate(User user) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            PageStatus = "edit";
            this.user = user;
        }
        private void demoUserTemplate_Load(object sender, EventArgs e)
        {
            if (PageStatus == "add")
            {
                label1.Text = "新增用户";
                button3.Visible = false;
                tabPageView1.Controls.Add(new tabUserLayout1());
                tabPageView1.Controls.Add(new tabUserLayout2());
                tabPageView1.Controls.Add(new tabUserLayout3());
            }
            else
            {
                label1.Text = "编辑用户";
                tabPageView1.Controls.Add(new tabUserLayout1(user));
                tabPageView1.Controls.Add(new tabUserLayout2(user));
                tabPageView1.Controls.Add(new tabUserLayout3(user));
            }
        }
        /// <summary>
        /// 保存事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            user = ((tabUserLayout1)tabPageView1.Controls[0]).ReturnUser(user);
            user = ((tabUserLayout2)tabPageView1.Controls[1]).ReturnUser(user);
            user = ((tabUserLayout3)tabPageView1.Controls[2]).ReturnUser(user);
            //新增保存
            if (PageStatus == "add" && string.IsNullOrEmpty(user.Id) == false)
            {

                XElement xe = XElement.Load(SwebResourceManager.DefaultDocumentPath + "/userinfo.xml");
                XElement record = new XElement(
                new XElement("user",
                new XElement("id", user.Id),
                new XElement("name", user.Name),
                new XElement("psd", user.Psd),
                new XElement("language", user.Language),
                new XElement("sex", user.Sex),
                new XElement("status", user.Status),
                new XElement("authentication", user.Authentication),
                new XElement("birth", user.Birth),
                new XElement("phone", user.Phone),
                new XElement("develop", user.Develop),
                new XElement("command", user.Command),
                new XElement("commandtype", user.CommandType),
                new XElement("other", user.Other),
                new XElement("isad", user.IsAD),
                new XElement("extend2", user.Extend2),
                new XElement("extend3", user.Extend3),
                new XElement("remarks", user.Remarks),
                new XElement("avtar", user.Avtar)
                ));
                xe.Add(record);
                xe.Save(SwebResourceManager.DefaultDocumentPath + "/userinfo.xml");
                Toast("新增成功！");

                this.Parent.Controls.Add(new demoUserTemplate() { Flex=1});
                this.Parent.Controls.RemoveAt(0);
            }
            //编辑保存
            if(PageStatus=="edit"&& string.IsNullOrEmpty(user.Id) == false)
            {
                XElement xe = XElement.Load(SwebResourceManager.DefaultDocumentPath + "/userinfo.xml");
                IEnumerable<XElement> element = from ele in xe.Elements("user")
                                                where ele.Element("id").Value == user.Id
                                                select ele;
                if (element.Count() > 0)
                {
                    XElement first = element.First();
                    ///替换新的节点         
                    first.ReplaceNodes(
                    new XElement("id", user.Id),
                    new XElement("name", user.Name),
                    new XElement("psd", user.Psd),
                    new XElement("language", user.Language),
                    new XElement("sex", user.Sex),
                    new XElement("status", user.Status),
                    new XElement("authentication", user.Authentication),
                    new XElement("birth", user.Birth),
                    new XElement("phone", user.Phone),
                    new XElement("develop", user.Develop),
                    new XElement("command", user.Command),
                    new XElement("commandtype", user.CommandType),
                    new XElement("other", user.Other),
                    new XElement("isad", user.IsAD),
                    new XElement("extend2", user.Extend2),
                    new XElement("extend3", user.Extend3),
                    new XElement("remarks", user.Remarks),
                    new XElement("avtar", user.Avtar));
                    xe.Save(SwebResourceManager.DefaultDocumentPath + "/userinfo.xml");
                    Toast("修改成功！");
                    this.Parent.Controls.Add(new demoUserTemplate() { Flex = 1 });
                    this.Parent.Controls.RemoveAt(0);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new demoUserTemplate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PageStatus == "edit" && string.IsNullOrEmpty(user.Id) == false)
            {
                XElement xe = XElement.Load(SwebResourceManager.DefaultDocumentPath + "/userinfo.xml");
                IEnumerable<XElement> element = from ele in xe.Elements("user")
                                                where ele.Element("id").Value == user.Id
                                                select ele;
                if (element.Count() > 0)
                    element.First().Remove();
                xe.Save(SwebResourceManager.DefaultDocumentPath + "/userinfo.xml");
                Toast("删除成功！");
                this.Parent.Controls.Add(new demoUserTemplate() { Flex = 1 });
                this.Parent.Controls.RemoveAt(0);
                ;
            }
        }
    }
}