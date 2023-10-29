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

namespace TestLabManagerAppWPF.ChildWindow.Course
{
    /// <summary>
    /// Interaction logic for AddCourseWindow.xaml
    /// </summary>
    public partial class AddCourseWindow : Window
    {
        public AddCourseWindow()
        {
            InitializeComponent();
        }

        // GetTlCourse
        private TlCourse? GetTlCourse()
        {
            TlCourse tlCourse = new TlCourse();
            try
            {
                // check empty all field
                if (txtCourseName.Text == "")
                {
                    MessageBox.Show("Please fill all field");
                    return null;
                }
                tlCourse.CourseName = txtCourseName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tlCourse.CreateBy = 1;
            return tlCourse;
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
            try
            {
                TlCourse? tlCourse = GetTlCourse();
                if (tlCourse != null)
                {
                    var courseRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
                    courseRepository.AddCourse(tlCourse);
                    DialogResult = true;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
