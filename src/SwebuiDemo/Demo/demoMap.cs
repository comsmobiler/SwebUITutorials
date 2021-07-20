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
            mapView1.Tags.Add(new MapViewTag(120.7998, 30.6909161, "车站"));//赋值地点信息
          
            MapViewRoute route = new MapViewRoute();
            route.Point.Add(new MapViewPoint(121.506396f, 31.245567f, "上海东方明珠"));
            route.Point.Add(new MapViewPoint(120.176823f, 30.283757f, "杭州"));
            route.Point.Add(new MapViewPoint(121.671316f, 31.146357f, "上海迪士尼度假区"));
            mapView1.Routes.Add(route);
            
            mapTrimView1.Latitude = 30.6909161f;
            mapTrimView1.Longitude = 120.7995f;
            mapTrimView1.Description = "车站";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mapView1.Tags.Add(new MapViewTag(120.7998, 30.6909161, "车站"));//赋值地点信息



        }

        private void mapView1_TagClick(object sender, MapViewTagClickEventArgs e)
        {
            Toast("点击Tag");
        }

        private void mapTrimView1_LocationChanged(object sender, MapTrimViewLocationChangedEventArgs e)
        {
            Toast("移动tag");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MapViewRoute route = new MapViewRoute();
            route.Point.Add(new MapViewPoint(121.506396f, 31.245567f, "上海东方明珠"));
            route.Point.Add(new MapViewPoint(120.176823f, 30.283757f, "杭州"));
            route.Point.Add(new MapViewPoint(121.671316f, 31.146357f, "上海迪士尼度假区"));
            mapView1.Routes.Add(route);
        }
    }
}