using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo.Demo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demoMap : SwebUserControl
    {
        private void demoMap_Load(object sender, EventArgs e)
        {
            mapView1.Tags.Add(new MapViewTag(120.7998, 30.6909161, "��վ"));//��ֵ�ص���Ϣ
          
            MapViewRoute route = new MapViewRoute();
            route.Point.Add(new MapViewPoint(121.506396f, 31.245567f, "�Ϻ���������"));
            route.Point.Add(new MapViewPoint(120.176823f, 30.283757f, "����"));
            route.Point.Add(new MapViewPoint(121.671316f, 31.146357f, "�Ϻ���ʿ��ȼ���"));
            mapView1.Routes.Add(route);
            
            mapTrimView1.Latitude = 30.6909161f;
            mapTrimView1.Longitude = 120.7995f;
            mapTrimView1.Description = "��վ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mapView1.Tags.Add(new MapViewTag(120.7998, 30.6909161, "��վ"));//��ֵ�ص���Ϣ



        }

        private void mapView1_TagClick(object sender, MapViewTagClickEventArgs e)
        {
            Toast("���Tag");
        }

        private void mapTrimView1_LocationChanged(object sender, MapTrimViewLocationChangedEventArgs e)
        {
            Toast("�ƶ�tag");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MapViewRoute route = new MapViewRoute();
            route.Point.Add(new MapViewPoint(121.506396f, 31.245567f, "�Ϻ���������"));
            route.Point.Add(new MapViewPoint(120.176823f, 30.283757f, "����"));
            route.Point.Add(new MapViewPoint(121.671316f, 31.146357f, "�Ϻ���ʿ��ȼ���"));
            mapView1.Routes.Add(route);
        }
    }
}