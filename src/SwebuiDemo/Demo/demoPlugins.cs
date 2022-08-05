using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swebui.Controls;

namespace SwebuiDemo.Demo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demoPlugins : SwebUserControl
    {

        private void demoPlugins_Load(object sender, EventArgs e)
        {
            #region"echart"
            eCharts1.Option = @"{
            tooltip: {
                trigger: 'axis',
                axisPointer: {
                    type: 'cross',
                    crossStyle: {
                        color: '#999'
                    }
                }
            },
            toolbox: {
                feature: {
                    dataView: {show: true, readOnly: false},
                    magicType: {show: true, type: ['line', 'bar']},
                    restore: {show: true},
                    saveAsImage: {show: true}
                }
            },
            legend: {
                data: ['蒸发量', '降水量', '平均温度']
            },
            xAxis: [
                {
                    type: 'category',
                    data: ['1月', '2月', '3月', '4月', '5月', '6月', '7月', '8月', '9月', '10月', '11月', '12月'],
                    axisPointer: {
                        type: 'shadow'
                    }
                }
            ],
            yAxis: [
                {
                    type: 'value',
                    name: '水量',
                    min: 0,
                    max: 250,
                    interval: 50,
                    axisLabel: {
                        formatter: '{value} ml'
                    }
                },
                {
                    type: 'value',
                    name: '温度',
                    min: 0,
                    max: 25,
                    interval: 5,
                    axisLabel: {
                        formatter: '{value} °C'
                    }
                }
            ],
            series: [
                {
                    name: '蒸发量',
                    type: 'bar',
                    data: [2.0, 4.9, 7.0, 23.2, 25.6, 76.7, 135.6, 162.2, 32.6, 20.0, 6.4, 3.3]
                },
                {
                    name: '降水量',
                    type: 'bar',
                    data: [2.6, 5.9, 9.0, 26.4, 28.7, 70.7, 175.6, 182.2, 48.7, 18.8, 6.0, 2.3]
                },
                {
                    name: '平均温度',
                    type: 'line',
                    yAxisIndex: 1,
                    data: [2.0, 2.2, 3.3, 4.5, 6.3, 10.2, 20.3, 23.4, 23.0, 16.5, 12.0, 6.2]
                }
            ]
        }";
            #endregion

            #region"animation"
            int i = animationPanel.Width / 23;
            for (int j = 0; j < i; j++)
            {
                Label label = new Label() { Location = new System.Drawing.Point(j * 20, 3), Size = new System.Drawing.Size(3, 3), BackColor = System.Drawing.Color.White };
                label.Animation = "animation1";
                animationPanel.Controls.Add(label);
            }
            #endregion

            ///svg
            svg1.Content = @"<svg class='svgpath' width='256' height='112' viewBox='0 0 256 112'>
    <path fill='none'' stroke='currentColor' stroke-width='1' d='M8,56 C8,33.90861 25.90861,16 48,16 C70.09139,16 88,33.90861 88,56 C88,78.09139 105.90861,92 128,92 C150.09139,92 160,72 160,56 C160,40 148,24 128,24 C108,24 96,40 96,56 C96,72 105.90861,92 128,92 C154,93 168,78 168,56 C168,33.90861 185.90861,16 208,16 C230.09139,16 248,33.90861 248,56 C248,78.09139 230.09139,96 208,96 L48,96 C25.90861,96 8,78.09139 8,56 Z'></path>
 </svg>";
            ///html
            //            htmlView1.HTML = @" <div class='scrolllabel' style='height:20px; width: 20px;  background-color: rgb(255, 0, 0);'></div>
            //<svg class='svgpath' width='256' height='112' viewBox='0 0 256 112'>
            //    <path fill='none'' stroke='currentColor' stroke-width='1' d='M8,56 C8,33.90861 25.90861,16 48,16 C70.09139,16 88,33.90861 88,56 C88,78.09139 105.90861,92 128,92 C150.09139,92 160,72 160,56 C160,40 148,24 128,24 C108,24 96,40 96,56 C96,72 105.90861,92 128,92 C154,93 168,78 168,56 C168,33.90861 185.90861,16 208,16 C230.09139,16 248,33.90861 248,56 C248,78.09139 230.09139,96 208,96 L48,96 C25.90861,96 8,78.09139 8,56 Z'></path>
            // </svg>";
            htmlView1.HTML = @"<div style='height: 0;line-height: 1'>
<div class='scrolllabel1'  style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel1'  style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel1'  style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel1'  style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel1'  style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel1'  style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel1'  style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel2'  style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel2'  style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel2' style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel2' style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel2' style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel2' style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel2' style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel3' style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel3' style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel3' style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel3' style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel3' style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel3' style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div>
<div class='scrolllabel3' style='height:3px; width: 3px;  background-color: #adc863;display:inline-block;position: absolute;top:0;left:0;box-shadow: 0px 0px 2px 2px #adc8637a;'></div></div>

<svg class='svgpath1'width='120' height='570' xmlns='http://www.w3.org/2000/svg'>
 <!-- Created with Method Draw - http://github.com/duopixel/Method-Draw/ -->
 <g>
  <title>background</title>
  <rect fill='#06152e' id='canvas_background' height='572' width='122' y='-1' x='-1'/>
  <g display='none' overflow='visible' y='0' x='0' height='100%' width='100%' id='canvasGrid'>
   <rect fill='url(#gridpattern)' stroke-width='0' y='0' x='0' height='100%' width='100%'/>
  </g>
 </g>
 <g>
  <title>Layer 1</title>
  <path  class='scrollpath' id='svg_2' d='m-0.5,270.453125c29.017236,0 28,-1 27.5,-1.453125c0.5,0.453125 0.5,-258.554597 -2,-259c0.5,0.453125 81.506173,0.453125 81,0' opacity='0.5' stroke-width='1.5' stroke='#36a9e6' fill='#ffffff00'/>
  <path   class='scrollpath1' id='svg_4'  d='m-1.5,271.453125c29.154759,0 29,0 28.5,-0.453125c0.5,0.453125 0.5,283.742729 0,283c0,0.788685 79.509614,-0.546875 79,0' opacity='0.5' stroke-width='1.5' stroke='#36a9e6' fill='#ffffff00'/>
  <path class='scrollpath2 id='svg_6'  d='m119.5,456.453125c-38.052595,0 -38,1 -38.5,0.546875c0.5,0.453125 0.5,-346.552639 0,-347c0,0.444108 24.522716,0.453125 24,0' opacity='0.5' stroke-width='1.5' stroke='#36a9e6' fill='#ffffff00'/>
  <path id='svg_7' d='m107.26302,10.915834l-8.898614,-13.500004l15.999993,13.500004l-15.999993,13.499997l8.898614,-13.499997z' stroke-width='1.5' stroke='#36a9e6' fill='#36a9e6'/>
  <path id='svg_8' d='m108.26302,109.91583l-8.89861,-13.5l15.99999,13.5l-15.99999,13.5l8.89861,-13.5z' stroke-width='1.5' stroke='#36a9e6' fill='#36a9e6'/>
  <path id='svg_9' d='m109.26302,553.91583l-8.89861,-13.5l15.99999,13.5l-15.99999,13.5l8.89861,-13.5z' stroke-width='1.5' stroke='#36a9e6' fill='#36a9e6'/>
 </g>
</svg>";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            animation1.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        { animation1.Play();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            animation1.Pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            animation2.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            animation2.Pause();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            animation2.Restart();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            animation3.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            animation3.Pause();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            animation3.Restart();
        }

        private void eCharts1_EChartsPress(object sender, EChartsPressEventArgs e)
        {
            if (e.Data != null)
                Toast($"点击项值：{e.Data} 点击项索引：{ e.DataIndex} 点击项图表类型 ：{e.ComponentSubType} 图标索引：{e.ComponentIndex}");
            else
            {
                string str = "";
                foreach(var item in e.Selected)
                {
                    str += "  图例名称: " + item.Key + "  是否显示: " + item.Value+"  ";
                }

                Toast($"点击图例名：{e.PressedName} {str}");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            eCharts1.Theme = EChartsTheme.Dark;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            eCharts1.Theme = EChartsTheme.Light;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            eCharts1.CustomThemeName = "theme1";
            eCharts1.ThemeJson = @"{
    'color': [
        '#516b91',
        '#59c4e6',
        '#edafda',
        '#93b7e3',
        '#a5e7f0',
        '#cbb0e3'
    ],
    'backgroundColor': 'rgba(0,0,0,0)',
    'textStyle': { },
    'title': {
                'textStyle': {
                    'color': '#516b91'
                },
        'subtextStyle': {
                    'color': '#93b7e3'
        }
            },
    'line': {
                'itemStyle': {
                    'borderWidth': '2'
                },
        'lineStyle': {
                    'width': '2'
        },
        'symbolSize': '6',
        'symbol': 'emptyCircle',
        'smooth': true
    },
    'radar': {
                'itemStyle': {
                    'borderWidth': '2'
                },
        'lineStyle': {
                    'width': '2'
        },
        'symbolSize': '6',
        'symbol': 'emptyCircle',
        'smooth': true
    },
    'bar': {
                'itemStyle': {
                    'barBorderWidth': 0,
            'barBorderColor': '#ccc'
                }
            },
    'pie': {
                'itemStyle': {
                    'borderWidth': 0,
            'borderColor': '#ccc'
                }
            },
    'scatter': {
                'itemStyle': {
                    'borderWidth': 0,
            'borderColor': '#ccc'
                }
            },
    'boxplot': {
                'itemStyle': {
                    'borderWidth': 0,
            'borderColor': '#ccc'
                }
            },
    'parallel': {
                'itemStyle': {
                    'borderWidth': 0,
            'borderColor': '#ccc'
                }
            },
    'sankey': {
                'itemStyle': {
                    'borderWidth': 0,
            'borderColor': '#ccc'
                }
            },
    'funnel': {
                'itemStyle': {
                    'borderWidth': 0,
            'borderColor': '#ccc'
                }
            },
    'gauge': {
                'itemStyle': {
                    'borderWidth': 0,
            'borderColor': '#ccc'
                }
            },
    'candlestick': {
                'itemStyle': {
                    'color': '#edafda',
            'color0': 'transparent',
            'borderColor': '#d680bc',
            'borderColor0': '#8fd3e8',
            'borderWidth': '2'
                }
            },
    'graph': {
                'itemStyle': {
                    'borderWidth': 0,
            'borderColor': '#ccc'
                },
        'lineStyle': {
                    'width': 1,
            'color': '#aaaaaa'
        },
        'symbolSize': '6',
        'symbol': 'emptyCircle',
        'smooth': true,
        'color': [
            '#516b91',
            '#59c4e6',
            '#edafda',
            '#93b7e3',
            '#a5e7f0',
            '#cbb0e3'
        ],
        'label': {
                    'color': '#eeeeee'
        }
            },
    'map': {
                'itemStyle': {
                    'areaColor': '#f3f3f3',
            'borderColor': '#516b91',
            'borderWidth': 0.5
                },
        'label': {
                    'color': '#000'
        },
        'emphasis': {
                    'itemStyle': {
                        'areaColor': '#a5e7f0',
                'borderColor': '#516b91',
                'borderWidth': 1
                    },
            'label': {
                        'color': '#516b91'
            }
                }
            },
    'geo': {
                'itemStyle': {
                    'areaColor': '#f3f3f3',
            'borderColor': '#516b91',
            'borderWidth': 0.5
                },
        'label': {
                    'color': '#000'
        },
        'emphasis': {
                    'itemStyle': {
                        'areaColor': '#a5e7f0',
                'borderColor': '#516b91',
                'borderWidth': 1
                    },
            'label': {
                        'color': '#516b91'
            }
                }
            },
    'categoryAxis': {
                'axisLine': {
                    'show': true,
            'lineStyle': {
                        'color': '#cccccc'
            }
                },
        'axisTick': {
                    'show': false,
            'lineStyle': {
                        'color': '#333'
            }
                },
        'axisLabel': {
                    'show': true,
            'color': '#999999'
        },
        'splitLine': {
                    'show': true,
            'lineStyle': {
                        'color': [
                            '#eeeeee'
                ]
            }
                },
        'splitArea': {
                    'show': false,
            'areaStyle': {
                        'color': [
                            'rgba(250,250,250,0.05)',
                    'rgba(200,200,200,0.02)'
                ]
            }
                }
            },
    'valueAxis': {
                'axisLine': {
                    'show': true,
            'lineStyle': {
                        'color': '#cccccc'
            }
                },
        'axisTick': {
                    'show': false,
            'lineStyle': {
                        'color': '#333'
            }
                },
        'axisLabel': {
                    'show': true,
            'color': '#999999'
        },
        'splitLine': {
                    'show': true,
            'lineStyle': {
                        'color': [
                            '#eeeeee'
                ]
            }
                },
        'splitArea': {
                    'show': false,
            'areaStyle': {
                        'color': [
                            'rgba(250,250,250,0.05)',
                    'rgba(200,200,200,0.02)'
                ]
            }
                }
            },
    'logAxis': {
                'axisLine': {
                    'show': true,
            'lineStyle': {
                        'color': '#cccccc'
            }
                },
        'axisTick': {
                    'show': false,
            'lineStyle': {
                        'color': '#333'
            }
                },
        'axisLabel': {
                    'show': true,
            'color': '#999999'
        },
        'splitLine': {
                    'show': true,
            'lineStyle': {
                        'color': [
                            '#eeeeee'
                ]
            }
                },
        'splitArea': {
                    'show': false,
            'areaStyle': {
                        'color': [
                            'rgba(250,250,250,0.05)',
                    'rgba(200,200,200,0.02)'
                ]
            }
                }
            },
    'timeAxis': {
                'axisLine': {
                    'show': true,
            'lineStyle': {
                        'color': '#cccccc'
            }
                },
        'axisTick': {
                    'show': false,
            'lineStyle': {
                        'color': '#333'
            }
                },
        'axisLabel': {
                    'show': true,
            'color': '#999999'
        },
        'splitLine': {
                    'show': true,
            'lineStyle': {
                        'color': [
                            '#eeeeee'
                ]
            }
                },
        'splitArea': {
                    'show': false,
            'areaStyle': {
                        'color': [
                            'rgba(250,250,250,0.05)',
                    'rgba(200,200,200,0.02)'
                ]
            }
                }
            },
    'toolbox': {
                'iconStyle': {
                    'borderColor': '#999999'
                },
        'emphasis': {
                    'iconStyle': {
                        'borderColor': '#666666'
                    }
                }
            },
    'legend': {
                'textStyle': {
                    'color': '#999999'
                }
            },
    'tooltip': {
                'axisPointer': {
                    'lineStyle': {
                        'color': '#cccccc',
                'width': 1
                    },
            'crossStyle': {
                        'color': '#cccccc',
                'width': 1
            }
                }
            },
    'timeline': {
                'lineStyle': {
                    'color': '#8fd3e8',
            'width': 1
                },
        'itemStyle': {
                    'color': '#8fd3e8',
            'borderWidth': 1
        },
        'controlStyle': {
                    'color': '#8fd3e8',
            'borderColor': '#8fd3e8',
            'borderWidth': 0.5
        },
        'checkpointStyle': {
                    'color': '#8fd3e8',
            'borderColor': '#8a7ca8'
        },
        'label': {
                    'color': '#8fd3e8'
        },
        'emphasis': {
                    'itemStyle': {
                        'color': '#8fd3e8'
                    },
            'controlStyle': {
                        'color': '#8fd3e8',
                'borderColor': '#8fd3e8',
                'borderWidth': 0.5
            },
            'label': {
                        'color': '#8fd3e8'
            }
                }
            },
    'visualMap': {
                'color': [
                    '#516b91',
            '#59c4e6',
            '#a5e7f0'
        ]
    },
    'dataZoom': {
                'backgroundColor': 'rgba(0,0,0,0)',
        'dataBackgroundColor': 'rgba(255,255,255,0.3)',
        'fillerColor': 'rgba(167,183,204,0.4)',
        'handleColor': '#a7b7cc',
        'handleSize': '100%',
        'textStyle': {
                    'color': '#333'
        }
            },
    'markPoint': {
                'label': {
                    'color': '#eeeeee'
                },
        'emphasis': {
                    'label': {
                        'color': '#eeeeee'
                    }
                }
            }
        }
";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Client.JSEval(@"var path = anime.path('.svgpath1 .scrollpath');
                  anime({targets: '.scrolllabel1',
                  translateX: path('x'),
                  translateY: path('y'),
                  rotate: path('angle'),
                  easing: 'linear',   
                    delay: anime.stagger(300),
                  duration: 2000,
                  loop: true
                });

            var path1 = anime.path('.svgpath1 .scrollpath1');
             anime({targets: '.scrolllabel2',
                  translateX: path1('x'),
                  translateY: path1('y'),
                  rotate: path1('angle'),
                  easing: 'linear',
                  delay: anime.stagger(300),
                  duration: 2000, 
                  loop: true
            });
      
             var path2 = anime.path('.svgpath1 .scrollpath2');
             anime({targets: '.scrolllabel3',
                  translateX: path2('x'),
                  translateY: path2('y'),
                  rotate: path2('angle'),
                  easing: 'linear',
                  duration: 2000, 
                  delay: anime.stagger(300),
                  loop: true
            });
            ", (obj, args) =>
            {

                if (args.errorCode == 0)
                    Toast("success");
            });
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            mediaView1.Seek(60);
        }
        bool isflag = true;
        private void button17_Click(object sender, EventArgs e)
        {
            mediaView1.Pause(isflag);
            isflag = !isflag;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tts1.Speak("你好世界 ！这是测试语句", TTSLanguage.zh, 1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tts1.Speak("你好世界 ！这是测试语句", TTSLanguage.zh, 2);
        
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tts1.Speak("Hello, this is an English test sentence", TTSLanguage.en, 1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tts1.Speak("Hello, this is an English test sentence", TTSLanguage.en, 2);
        }

        private void popPanel1_Select(object sender, PopPanelItemSelectEventArgs e)
        {

        }
    }
}