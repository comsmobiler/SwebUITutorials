## SWEBUITutorials
* SWEBUITutorials.sln 对应1.0版本
* 也可前往Gitee码云获取源码，https://gitee.com/smobiler/SmobilerTutorials
### 快速入门 - 环境搭建

##### 服务端
* 操作系统：windows 8.1及windows server 2012
* 开发环境：.NET Framework 4.5及以上版本 ，.支持NET Core 3.0及以上版本
* 开发工具：Visual Studio 2012及以上版本
* 打开电脑上的浏览器，访问 https://www.swebui.com/download.html ，并选择Designer，下载并安装。

### 开发第一个示例应用

* 可参考：
	* https://www.swebui.com/guide/quickstart.aspx
	* https://www.cnblogs.com/oudi/p/8288617.html

### 控件介绍

#### Smobiler继承结构
* SwebControl【控件，有UI，可展示】
	* SwebBindableControl【所有可做数据绑定的控件***基类***】
		* Button、Label、TextBox、Image...
	* SegmentedControl、WebView、MapTagView、Line...
	* SwebLayoutControl【布局控件***基类***】
		* ListView、GridView...
		* SwebContainerControl【容器控件***基类***】
			* Panel、TabPageView...
			* SwebParentControl【父控件***基类***】
				* SwebForm【窗体】
				* SwebUserControl【用户控件】
			* SwebNativeContainerControl【插件容器控件***基类***】
				* PercentageCircle

---

#### [SwebControl](Document/Components/SwebControl.MD)

#### 基础控件
| 名称 | 说明 | 名称 | 说明 |
|:---|:---|:---|:---|
| [Button](Document/Components/Button.MD) | 按钮控件 | [Label](Document/Components/Label.MD) | 文本控件 |
| [TextBox](Document/Components/TextBox.MD) | 输入框控件 | [CheckBox](Document/Components/CheckBox.MD) | 单选控件 |
| [Swith](Document/Components/Swith.MD) | 开关控件 | [Image](Document/Components/Image.MD) | 图像控件 |
| [FontIcon](Document/Components/FontIcon.MD) | 图标控件 | [ZoomImage](Document/Components/ZoomImage.MD) | 缩放图像控件 |
| [Line](Document/Components/Line.MD) | 线条控件 | [Slider](Document/Components/Slider.MD) | 滚动条控件 |
| [DatePicker](Document/Components/DatePicker.MD) | 日期选择控件 | [Calendar](Document/Components/Calendar.MD) | 日历控件 |
| [Picker](Document/Components/Picker.MD) | 元素选择控件 | [Progress](Document/Components/Progress.MD) | 进度条控件 | | [SegmentedControl](Document/Components/SegmentedControl.MD) | 单元控件 |
| [WebView](Document/Components/WebView.MD) | 浏览器控件 | [MapTagView](Document/Components/MapTagView.MD) | 地理位置标签控件 |
| [BarcodeView](Document/Components/BarcodeView.MD) | 条码控件 |  |  |

#### SwebContainerControl 容器控件
* Panel
	* TouchablePanel
	* ScrollablePanel
* TabPageView

#### SwebParentControl 父控件
* [SwebForm](Document/Components/SwebForm.MD)
* [SwebUserControl](Document/Components/SwebUserControl.MD)

#### [SwebLayoutControl](Document/Components/SwebLayoutControl.MD) 模板控件
* ListView
* GridView
* PageView

#### 图表控件 Chart
| 名称 | 说明 |
|:---|:---|
| [Echart](Document/Components/Echart.MD) | echart|


