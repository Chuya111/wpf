using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {//声明接口，插头：
            InitializeComponent();
            interface Iinterface /*接口名称 */
        {
            void/*返回值类型，前面不能加任何修饰符 */Method1(int,int)/*圆括号里面代表方法的参数 */;/*分号代替方法主题 */
            double Method2;
            }
        //实现接口：
            class myclass : Iinterface 
        {
            void Method1(int, int) { }具体方法要写出来了
            double Method2 { }
        }

        }
    }
}
