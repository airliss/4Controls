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
using System.Windows.Shapes;

namespace _4Controls
{
    /// <summary>
    /// Логика взаимодействия для ControlBatton.xaml
    /// </summary>
    public partial class ControlBatton : Window
    {
        public ControlBatton()
        {
            InitializeComponent();
            button1.Click += Button_Click; //обработчик в коде
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You click Button");
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Действие выполнено");//по нажатию Enter
        }

        private void escButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // закрытие окна Esc
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (ToggleButton.IsChecked == false)
            {
                ToggleButton.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            }
            else
                ToggleButton.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
        } 
    }
}
