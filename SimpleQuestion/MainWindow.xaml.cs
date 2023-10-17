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

namespace SimpleQuestion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static string Answer = "YES OF COURSE YOU ARE!";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonYes_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonYes.Content.ToString() == "YES")
                AnswerTextBlock.Text = Answer;
        }

        private void ButtonNo_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonNo.Content.ToString() == "YES")
                AnswerTextBlock.Text = Answer;
        }

        private void ButtonYes_MouseEnter(object sender, MouseEventArgs e)
        {
            if (ButtonYes.Content.ToString() == "NO")
            {
                ButtonYes.Content = "YES";
                ButtonNo.Content = "NO";
            }
        }

        private void ButtonNo_MouseEnter(object sender, MouseEventArgs e)
        {
            if (ButtonNo.Content.ToString() == "NO")
            {
                ButtonYes.Content = "NO";
                ButtonNo.Content = "YES";
            }
        }

    }
}
