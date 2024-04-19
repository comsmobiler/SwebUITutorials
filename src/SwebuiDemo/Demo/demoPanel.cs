using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebuiDemo.Demo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demoPanel : Swebui.Controls.SwebUserControl
    {
        public demoPanel() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        private void imageButton1_ImagePress(object sender, EventArgs e)
        {

        }

        private void panel2_MouseEnter(object sender, SwebMouseMoveEventArgs e)
        {
            Toast("Enter " + "方向：" + e.Position.ToString() + " Top " + e.Top.ToString() + " Height " + e.Height.ToString() + " X " + e.X.ToString() + " Y " + e.Y.ToString() + " Width " + e.Width.ToString());

        }

        private void panel2_MouseLeave(object sender, SwebMouseMoveEventArgs e)
        {
            Toast("Leave " + "方向：" + e.Position.ToString() + " Top " + e.Top.ToString() + " Height " + e.Height.ToString() + " X " + e.X.ToString() + " Y " + e.Y.ToString() + " Width " + e.Width.ToString());
        }

        private void panel2_Press(object sender, SwebMousePressEventArgs e)
        {
            Toast(" Top " + e.Top.ToString() + " Height " + e.Height.ToString() + " X " + e.X.ToString() + " Y " + e.Y.ToString() + " Width " + e.Width.ToString());
        }
    }
}