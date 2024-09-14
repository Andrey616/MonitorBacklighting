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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MonitorBacklightingWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thickness margin = ColorPep.Margin;
            margin.Left += 5 ;
            margin.Right -= 5;
            margin.Top += 6;
            margin.Bottom -= 6;
            this.ColorPep.BeginAnimation(FrameworkElement.MarginProperty, new ThicknessAnimation(margin, TimeSpan.FromSeconds(0.10)));
            
        }
    }
}
