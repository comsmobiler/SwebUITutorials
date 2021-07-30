using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Swebui.Controls;

namespace SwebuiDemo.Demo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class tabUserLayout3 : SwebUserControl
    {
        private User _user = new User();
        public tabUserLayout3(User user) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            _user = user;
        }
        private void demoUserTemplate_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_user.Id) == false)
            {
                image1.ResourceID = _user.Avtar;
            }
        }

        public User ReturnUser(User user)
        {
            user.Avtar = image1.ResourceID;
            return user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Form.Client.FileUpload((obj, args) =>
            {
                if (args.isError == false)
                {
                        args.SaveFile(args.ResourceID);
                        image1.ResourceID=args.ResourceID;
                }
            });
        }
    }
}