using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Swebui.Controls;

namespace SwebuiDemo.Demo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class tabUserLayout2 : SwebUserControl
    {
        private User _user = new User();
        public tabUserLayout2(User user) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            _user = user;
        }
        private void demoUserTemplate_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_user.Id) == false)
            {
                comboBox5.Text = _user.Develop;
                textBox1.Text = _user.Command;
                comboBox6.Text = _user.CommandType;
                textBox2.Text = _user.Other;
                checkBox1.Checked = Convert.ToBoolean( _user.IsAD);
                textBox3.Text = _user.Extend2;
                textBox4.Text = _user.Extend3;
                textBox5.Text = _user.Remarks;
            }
         
        }

        public User ReturnUser(User user)
        {
            user.Develop = comboBox5.Text;
            user.Command = textBox1.Text;
            user.CommandType = comboBox6.Text;
            user.Other = textBox2.Text;
            user.IsAD = checkBox1.Checked.ToString();
            user.Extend2 = textBox3.Text;
            user.Extend3 = textBox4.Text;
            user.Remarks = textBox5.Text;
            return user;
        }
    }
}