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
    /// Логика взаимодействия для GroupBox_Expander.xaml
    /// </summary>
    public partial class GroupBox_Expander : Window
    {
        public GroupBox_Expander()
        {
            InitializeComponent();
            

        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            ((Expander)sender).Content = new Button() { Width = 80, Height = 30, Content = "Привет" };
        }

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Экспандер свернут");
        }
    }
}
