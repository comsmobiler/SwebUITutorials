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
            webView1.Url = "www.baidu.com";
        }

      
    }
}