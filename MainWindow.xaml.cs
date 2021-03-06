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

namespace _4Controls
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "Привет!"; //имя.свойство = свойство;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ControlBatton controlBatton = new ControlBatton();
            controlBatton.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CheckBoxRadioButton checkBoxRadioButton = new CheckBoxRadioButton();
            checkBoxRadioButton.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ToolTipHelp toolTipHelp = new ToolTipHelp();
            toolTipHelp.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            GroupBox_Expander groupBox_Expander = new GroupBox_Expander();
            groupBox_Expander.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ScrollViewer scrollViewer = new ScrollViewer();
            scrollViewer.Show();
        }
    }
}
