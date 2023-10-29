using Microsoft.Extensions.DependencyInjection;
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
using TestLabEntity.AutoDB;
using TestLabLibrary.Repository;

namespace TestLabManagerAppWPF.ChildWindow.Question
{
    /// <summary>
    /// Interaction logic for AddAnswerQuestionWindow.xaml
    /// </summary>
    public partial class AddAnswerQuestionWindow : Window
    {
        TlAnswer _answer;

        public TlAnswer Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        public AddAnswerQuestionWindow()
        {
            InitializeComponent();
        }


        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }
        private void btnCancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void btnSave(object sender, RoutedEventArgs e)
        {
            Answer = new TlAnswer();
            Answer.AnswerText = txtAnswerContent.Text;
            Answer.IsCorrect = false;
            DialogResult = true;
        }
    }
}
