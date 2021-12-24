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
            htmlView1.HTML = @" <div class='scrolllabel' style='height:20px; width: 20px;  background-color: rgb(255, 0, 0);'></div>
<svg class='svgpath' width='256' height='112' viewBox='0 0 256 112'>
    <path fill='none'' stroke='currentColor' stroke-width='1' d='M8,56 C8,33.90861 25.90861,16 48,16 C70.09139,16 88,33.90861 88,56 C88,78.09139 105.90861,92 128,92 C150.09139,92 160,72 160,56 C160,40 148,24 128,24 C108,24 96,40 96,56 C96,72 105.90861,92 128,92 C154,93 168,78 168,56 C168,33.90861 185.90861,16 208,16 C230.09139,16 248,33.90861 248,56 C248,78.09139 230.09139,96 208,96 L48,96 C25.90861,96 8,78.09139 8,56 Z'></path>
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
            Client.JSEval(@"var path = anime.path('.svgpath path');
              anime({targets: '.scrolllabel',
              translateX: path('x'),
              translateY: path('y'),
              rotate: path('angle'),
              easing: 'linear',
              duration: 2000,
              loop: true
            })
            ", (obj, args) =>
            {

                if (args.errorCode == 0)
                    Toast("success");
            });


        }
    }
}