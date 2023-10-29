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
using TestLabEntity.BusinessObject;
using TestLabLibrary.Repository;

namespace TestLabManagerAppWPF.ChildWindow.Course
{
    /// <summary>
    /// Interaction logic for EditCourseWindow.xaml
    /// </summary>
    public partial class EditCourseWindow : Window
    {
        TlCourse tlCourse;
        public EditCourseWindow(TlCourseObj tlCourseObj)
        {
            InitializeComponent();
            this.tlCourse = MyMapper.mapper.Map<TlCourse>(tlCourseObj);
            txtCourseName.Text = tlCourse.CourseName;
        }

        // GetTlCourse
        private TlCourse? GetTlCourse()
        {
            TlCourse tlCourse = this.tlCourse;
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
            return tlCourse;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void btnSave(object sender, RoutedEventArgs e)
        {
            try
            {
                TlCourse? tlCourse = GetTlCourse();
                if (tlCourse == null) return;
                var courseRepository = MyService.serviceProvider.GetService<IQuestionRepository>();
                courseRepository.UpdateCourse(tlCourse);
                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
