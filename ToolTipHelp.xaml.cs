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
    /// Логика взаимодействия для ToolTipHelp.xaml
    /// </summary>
    public partial class ToolTipHelp : Window
    {
        public ToolTipHelp()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();//создаем подсказку
            StackPanel toolTipPanel = new StackPanel(); //определяем родителя
            toolTipPanel.Children.Add(new TextBlock { Text = "Заголовок", FontSize = 16 });//задаем свойство текст блок для дочернего тула
            toolTipPanel.Children.Add(new TextBlock { Text = "Текст" });//и еще один слепили
            toolTip.Content = toolTipPanel; //сгенериное сохраняем в контент
            button1.ToolTip = toolTip; //указываем кому прилепляем в родительской панели
        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            popup1.IsOpen = true;
        }
    }
}
