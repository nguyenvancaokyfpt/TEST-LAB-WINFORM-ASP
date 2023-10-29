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

namespace TestLabManagerAppWPF.ChildWindow.Chapter
{
    /// <summary>
    /// Interaction logic for Chapter.xaml
    /// </summary>
    public partial class Chapter : UserControl
    {
        public Chapter()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // call to view model command

        }
    }
}
