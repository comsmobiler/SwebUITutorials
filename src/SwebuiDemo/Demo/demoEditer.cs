using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebuiDemo.Demo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demoEditer : Swebui.Controls.SwebUserControl
    {
        public demoEditer() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editer1.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editer1.ClearStack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            editer1.Undo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            editer1.Redo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> keyValuePair = new Dictionary<string, string>();
            keyValuePair.Add("insert", "更新内容" + DateTime.Now.ToString());
            editer1.UpdateDelta(new object[] { keyValuePair });
        }

        private void demoEditer_Load(object sender, EventArgs e)
        {
            editer1.PlaceHolder = "水印";
            editer1.Theme = Editer.EditerTheme.Snow;//设置Bubble 就没有工具栏

            Dictionary<string, string> keyValuePair = new Dictionary<string, string>();
            keyValuePair.Add("insert", "初始");
            editer1.DefaultDelta = new object[] { keyValuePair };

            //
            //List<EditerAttachButton> attachButtons = new List<EditerAttachButton>();
            //attachButtons.Add(EditerAttachButton.Formula);
            //attachButtons.Add(EditerAttachButton.Image);
            //editer1.ToolbarOptions.AttachButtons = new  AttachButton(attachButtons);

            //List<EditeListButton> editeListButtons = new List<EditeListButton>();
            //editeListButtons.Add(EditeListButton.Check);
            //editeListButtons.Add(EditeListButton.Ordered);
            //editer1.ToolbarOptions.ListButtons = new ListButton(editeListButtons);

            //List<EditerFontStyle> editerFontStyles = new List<EditerFontStyle>();
            //editerFontStyles.Add(EditerFontStyle.Bold);
            //editer1.ToolbarOptions.ToggledButtons=new ToggledButton(editerFontStyles);
            //editer1.ToolbarOptions.Header = new object[] { 1, 2, 3, 5, 6, false };
            //editer1.ToolbarOptions.Color = new System.Drawing.Color[] { System.Drawing.Color.Red };

        }
    }
}