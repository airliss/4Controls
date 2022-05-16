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
    /// Логика взаимодействия для CheckBoxRadioButton.xaml
    /// </summary>
    public partial class CheckBoxRadioButton : Window
    {
        public CheckBoxRadioButton()
        {
            InitializeComponent();

            //Программное добавление флажка:
            // создаем флажок
            CheckBox checkBox4 = new CheckBox { Content = "Новый флажок", MinHeight = 20, IsChecked = true };
            // установка обработчика
            checkBox4.Checked += checkBox_Checked;
            // добавление в StackPanel
            stackPanel.Children.Add(checkBox4);

            //Программная реализация чекбокса
            RadioButton rb = new RadioButton { IsChecked = true, GroupName = "Languages", Content = "JavaScript" };
            rb.Checked += RadioButton_Checked;
            stackPanel1.Children.Add(rb);
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox.Content.ToString() + " отмечен");
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox.Content.ToString() + " не отмечен");
        }

        private void checkBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox.Content.ToString() + " в неопределенном состоянии");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            MessageBox.Show(pressed.Content.ToString());//Выводит контент нажатого чека
        }
    }
}
