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

namespace Answer
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
            byte correctAnswers = 0;

            if (Q1_1.IsChecked == true)
                correctAnswers++;

            if (Q2_2.IsChecked == true)
                correctAnswers++;

            if (Q3_4.IsChecked == true)
                correctAnswers++;

            if (Q4_2.IsChecked == true)
                correctAnswers++;

            MessageBox.Show($"Вы ответили правильно на {correctAnswers}/4 вопросов!");
        }
    }
}
