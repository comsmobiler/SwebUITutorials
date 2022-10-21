using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swebui.Controls;

namespace SwebuiDemo.Demo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demoWeb : SwebUserControl
    {
        private void demoMap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            webView1.Url = Swebui.SwebResourceManager.GetResourceURL(Client.SessionID, "jsCookie.html", Swebui.SwebResourceManager.DefaultWebResourceName);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.webView1.PostMessage("{\"action\":\"setCookie\",\"data\":{\"name\":\"smo\",\"value\":\"smopwd\"}}");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.webView1.PostMessage("{\"action\":\"getCookie\",\"data\":{\"name\":\"smo\"}}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.webView1.PostMessage("{\"action\":\"delCookie\",\"data\":{\"name\":\"smo\"}}");
        }

        private void webView1_OnMessage(object sender, WebViewMessageEventArgs e)
        {
            if (webView1.Url != "https://www.smobiler.com")
            {
                //这里直接弹出消息框显示接收到的数据
                MessageBox.Show("OnMessage: " + e.Message);
            }
        }
    }
}