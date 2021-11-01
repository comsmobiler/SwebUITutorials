using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swebui.Controls;

namespace SwebuiDemo.Demo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demoTemplate : SwebUserControl
    {
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = DateTime.Now.ToString();
        }

        private void calendar1_DateChanged(object sender, EventArgs e)
        {
            Toast(calendar1.SelectDate.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            Toast("当前选中状态:" + ((CheckBox)sender).Checked.ToString());
        }

        private void datePicker1_ValueChanged(object sender, EventArgs e)
        {
            Toast(datePicker1.Value.ToString());
        }

        private void menuView1_MenuItemClick(object sender, MenuViewItemClickEventArgs e)
        {
            Toast("当前点击项" + e.Item.Text);
        }

        private void segmentedControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Toast("当前点击项 索引：" + segmentedControl1.SelectedIndex + "文本：" + segmentedControl1.SelectedItem);
        }

        private void switch3_CheckedChanged(object sender, EventArgs e)
        {
            Switch @switch = (Switch)sender;
            Toast("当前switch的值" + @switch.Checked.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.GoToBlur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.GoToFocus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Toast(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Toast("changed:" + textBox1.Text);
        }

        private void textBox1_TouchEnter(object sender, EventArgs e)
        {
            Toast("enter");
        }

        private void textBox1_TouchLeave(object sender, EventArgs e)
        {
            Toast("leave");
        }

        private void textBox1_SubmitEditing(object sender, EventArgs e)
        {
            Toast("回车");
        }

        private void demoTemplate_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            comboBox1.Items.Add( new ComboBoxItem(i.ToString(), "选项" + i.ToString()));
        }

        private void slide1_ValueChanged(object sender, EventArgs e)
        {
            Toast(slide1.Value.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Client.SetEJControlTheme(EJTheme.Dark);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Client.SetEJControlTheme(EJTheme.Light);
        }
    }
}