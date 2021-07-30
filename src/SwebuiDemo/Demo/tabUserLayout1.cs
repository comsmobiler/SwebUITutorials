using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Swebui.Controls;

namespace SwebuiDemo.Demo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class tabUserLayout1 : SwebUserControl
    {
        private User _user=new User();
        public tabUserLayout1( User user) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            _user = user;
        }
        private void demoUserTemplate_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_user.Id) == false)
            {
                textBox1.Text = _user.Id;
                textBox1.ReadOnly = true;
                textBox2.Text = _user.Name;
                textBox3.Text = _user.Psd;
                comboBox1.Text = _user.Language;
                comboBox2.Text = _user.Sex;
                comboBox3.Text = _user.Status;
                comboBox4.Text = _user.Authentication;
                datePicker1.Value = Convert.ToDateTime(_user.Birth);
                textBox4.Text = _user.Phone;
            }
        }
        public User ReturnUser( User user)
        {
            user.Id = textBox1.Text;
            user.Name = textBox2.Text;
            user.Psd = textBox3.Text;
            user.Language = comboBox1.Text;
            user.Sex = comboBox2.Text;
            user.Status = comboBox3.Text;
            user.Authentication = comboBox4.Text;
            user.Birth = datePicker1.Value.ToString();
            user.Phone = textBox4.Text;
            return user;
        }

    }
}