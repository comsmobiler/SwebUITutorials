using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swebui;

namespace SwebuiDemo.Demo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demoClient : Swebui.Controls.SwebUserControl
    {
        public demoClient() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client.FileUpload((obj, args) => {
                if (args.isError == true)
                    Toast(args.error);
                else
                {
                    args.SaveFile(args.ResourceID);
                    Toast("success");
                }

            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client.FileDownload("logon.png", SwebResourceManager.DefaultImagePath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Client.FileDownload("https://www.baidu.com/img/flexible/logo/pc/result.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Client.SetWebTitle("标题");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这是弹窗", "弹窗标题", (obj, args) =>
            {
                if (args.Result == ShowResult.OK)
                {

                }
            });


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Client.RedirectUrl("http://www.baidu.com", true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Client.RedirectUrl("http://www.baidu.com");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string url = Swebui.SwebResourceManager.GetResourceURL(Client.SessionID, "文件_1.pdf", SwebResourceManager.DefaultDocumentPath);
            Client.Print(url, PrintType.Pdf);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Client.Print("<h1>H1</h1><p>这是一个句子</p>", PrintType.Html);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Client.Print();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string jsid = "jsfunctionview";
            string jsCode = @"alert('Hello');";

            Client.JSAppend(jsid, jsCode, (obj, args) => {
                if (args.isError == false)
                    Toast("success");
                else
                    Toast(args.error);
            }, JScriptType.Script, JScriptAppendType.Body);
        }
    }
}