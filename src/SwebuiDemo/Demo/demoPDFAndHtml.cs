using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo.Demo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demoPDFAndHtml : SwebUserControl
    {
        private void demoPDFAndHtml_Load(object sender, EventArgs e)
        {
            htmlView1.HTML = " <h1> This HTML snippet is now rendered with native components! </h1 ><h2> Enjoy a webview-free and blazing fast application</h2 ><img src =\"https://www.smobiler.com/images/control/listview/phone1.png\" /><em style=\"textAlign: center;\" > Look at how happy this native cat is</em>";

        }
    }
}