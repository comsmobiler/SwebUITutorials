using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwebuiDemo
{
    class DemoGlobal
    {
        private static Random rd = new Random();
        public static void SetRandomControlBasicProperty<T>(SwebControl ctl) where T : SwebControl
        {
            ctl.BackColor = GetRandomColor();
            ctl.Border = new Border(rd.Next(0, ctl.Height / 4));
            ctl.BorderColor = GetRandomColor();
            ctl.BorderRadius = rd.Next(0, ctl.Height / 4);
            ctl.BorderStyle = (BorderStyle)rd.Next(0, 3);
            ctl.Margin = new Margin(rd.Next(0, ctl.Height / 4));
            ctl.Padding = new Padding(rd.Next(0, ctl.Height / 4));
        }

        internal static DataTable GetListViewTable(int dataCount, int sectionCount = 0)
        {
            DataTable dt = new DataTable("Table");
            dt.Columns.Add(new DataColumn("Label", typeof(string)));
            dt.Columns.Add(new DataColumn("Button", typeof(string)));
            dt.Columns.Add(new DataColumn("TextBox", typeof(string)));
            dt.Columns.Add(new DataColumn("Progress", typeof(float)));
            dt.Columns.Add(new DataColumn("Slider", typeof(float)));
            dt.Columns.Add(new DataColumn("CheckBox", typeof(bool)));
            dt.Columns.Add(new DataColumn("Switch", typeof(bool)));
            dt.Columns.Add(new DataColumn("Image", typeof(string)));
            dt.Columns.Add(new DataColumn("FontIcon", typeof(string)));
            dt.Columns.Add(new DataColumn("DatePicker", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Section", typeof(string)));

            string rdBind = rd.Next(0, 101).ToString();
            if (sectionCount <= 0) sectionCount = dataCount / 10;
            if (sectionCount == 0) sectionCount = 1;
            for (int i = 0; i < dataCount; i++)
            {
                string rdmark = i.ToString() + " - " + rdBind;

                DataRow row = dt.NewRow();
                row["Label"] = rdmark;
                row["Button"] = rdmark;
                row["TextBox"] = rdmark;
                row["Progress"] = rd.Next(0, 101) / 100f;
                row["Slider"] = rd.Next(0, 101) / 100f;
                row["Image"] = i.ToString();
                row["FontIcon"] = "heart";
                row["DatePicker"] = DateTime.Now;
                row["CheckBox"] = (i % 2) > 0 ? true : false;
                row["Switch"] = (i % 2) == 0 ? true : false;
                row["Section"] = ((int)(Math.Floor((decimal)(i / sectionCount)))).ToString();
                dt.Rows.Add(row);
            }
            return dt;
        }

        internal static List<ListViewGeneric> GetListViewGeneric(int dataCount, int sectionCount = 0)
        {
            List<ListViewGeneric> dt = new List<ListViewGeneric>();
            string rdBind = rd.Next(0, 101).ToString();
            if (sectionCount <= 0) sectionCount = dataCount / 10;
            if (sectionCount == 0) sectionCount = 1;
            for (int i = 0; i < dataCount; i++)
            {
                string rdmark = i.ToString() + " - " + rdBind;

                ListViewGeneric row = new ListViewGeneric();
                row.Label = rdmark;
                row.Button = rdmark;
                row.TextBox = rdmark;
                row.Progress = rd.Next(0, 101) / 100f;
                row.Slider = rd.Next(0, 101) / 100f;
                row.Image = i.ToString();
                row.FontIcon = "heart";
                row.DatePicker = DateTime.Now;
                row.CheckBox = (i % 2) > 0 ? true : false;
                row.Switch = (i % 2) == 0 ? true : false;
                row.Section = ((int)(Math.Floor((decimal)(i / sectionCount)))).ToString();
                dt.Add(row);
            }
            return dt;
        }

        public static T SetDefaultControlBasicProperty<T>(SwebControl ctl) where T : SwebControl
        {
            T instanceCtl = (T)Activator.CreateInstance<T>();
            ctl.BackColor = instanceCtl.BackColor;
            ctl.Border = instanceCtl.Border;
            ctl.BorderColor = instanceCtl.BorderColor;
            ctl.BorderRadius = instanceCtl.BorderRadius;
            ctl.BorderStyle = instanceCtl.BorderStyle;
            ctl.Margin = instanceCtl.Margin;
            ctl.Padding = instanceCtl.Padding;
            return instanceCtl;
        }

        internal static DataTable GetChartDemoTable()
        {
            DataTable dt = new DataTable("Table");
            dt.Columns.Add(new DataColumn("S", typeof(string)));
            dt.Columns.Add(new DataColumn("X", typeof(string)));
            dt.Columns.Add(new DataColumn("Y", typeof(double)));
            dt.Columns.Add(new DataColumn("Z", typeof(double)));
            dt.Columns.Add(new DataColumn("VH", typeof(double)));
            dt.Columns.Add(new DataColumn("VL", typeof(double)));
            dt.Columns.Add(new DataColumn("VO", typeof(double)));
            dt.Columns.Add(new DataColumn("VC", typeof(double)));
            dt.Columns.Add(new DataColumn("SP", typeof(int)));
            for (int s = 1; s <= 2; s++)
            {
                for (int i = 1; i <= 12; i++)
                {
                    DataRow row = dt.NewRow();
                    row["S"] = s.ToString();
                    row["X"] = i.ToString();
                    row["Y"] = i * s;
                    row["Z"] = i * s;
                    row["VH"] = i * s + i;
                    row["VL"] = i * s - i;
                    row["VO"] = i * s - s;
                    row["VC"] = i * s + s;
                    row["SP"] = rd.Next(0, 5);
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }

        public static string GetRandomControlBasicPropertyString<T>(SwebControl ctl) where T : SwebControl
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("ControlType:{0} ControlName:{1}", ctl.GetType().Name, ctl.Name));
            sb.AppendLine(string.Format("BackColor:{0}", GetColorString(ctl.BackColor)));
            sb.AppendLine(string.Format("Border:{0}", ctl.Border.Top));
            sb.AppendLine(string.Format("BorderColor:{0}", GetColorString(ctl.BorderColor)));
            sb.AppendLine(string.Format("BorderRadius:{0}", ctl.BorderRadius));
            sb.AppendLine(string.Format("BorderStyle:{0}", ctl.BorderStyle));
            sb.AppendLine(string.Format("Margin:{0}", ctl.Margin.Top));
            sb.AppendLine(string.Format("Padding:{0}", ctl.Padding.Top));
            return sb.ToString();
        }

        public static System.Drawing.Color GetRandomColor()
        {
            return System.Drawing.Color.FromArgb(rd.Next(0, 256), rd.Next(0, 256), rd.Next(0, 256), rd.Next(0, 256));
        }

        public static System.Drawing.Color GetRandomKnownColor()
        {
            //范围是1到174，随机需要到175
            return System.Drawing.Color.FromKnownColor((System.Drawing.KnownColor)rd.Next(1, 175));
        }

        public static string GetColorString(System.Drawing.Color color)
        {
            return string.Format("{0}/{1}/{2}/{3}", color.A, color.R, color.B, color.G);
        }
    }

    class ListViewGeneric
    {
        public string Label { get; set; }
        public string Button { get; set; }
        public string TextBox { get; set; }
        public float Progress { get; set; }
        public float Slider { get; set; }
        public bool CheckBox { get; set; }
        public bool Switch { get; set; }
        public string Image { get; set; }
        public string FontIcon { get; set; }
        public DateTime DatePicker { get; set; }
        public string Section { get; set; }
    }
}
