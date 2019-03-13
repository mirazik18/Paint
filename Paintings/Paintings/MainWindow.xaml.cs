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

namespace Paintings
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation animation = new DoubleAnimation();
            animation.AutoReverse = true;
           // animation.Duration = TimeSpan.FromDays(365);
            animation.RepeatBehavior = RepeatBehavior.Forever;
            animation.From = ellipse.Width;
            animation.To = 500;
            ellipse.BeginAnimation(Ellipse.WidthProperty, animation);
        }

        private void rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            rectangle.Fill = Brushes.DarkGreen;
            rectangle.Stroke = Brushes.DarkGreen;
        }

        private void rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            rectangle.Fill = Brushes.DarkBlue;
            rectangle.Stroke = Brushes.DarkBlue;
        }
    }
}
