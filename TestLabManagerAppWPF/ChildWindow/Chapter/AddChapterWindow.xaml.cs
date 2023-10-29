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

namespace TestLabManagerAppWPF.ChildWindow.Chapter
{
    /// <summary>
    /// Interaction logic for AddChapterWindow.xaml
    /// </summary>
    public partial class AddChapterWindow : Window
    {
        public AddChapterWindow(int courseId)
        {
            InitializeComponent();
            var courseRepo = MyService.serviceProvider.GetRequiredService<IQuestionRepository>();
            cmbCourse.ItemsSource = courseRepo.GetCourses();
            cmbCourse.SelectedValue = courseId;
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
                TlChapter tlChapter = new TlChapter();
                tlChapter.ChapterName = txtChapterName.Text;
                tlChapter.CourseId = (int)cmbCourse.SelectedValue;
                tlChapter.CreateBy = 1;
                var chapterRepo = MyService.serviceProvider.GetRequiredService<IQuestionRepository>();
                chapterRepo.AddChapter(tlChapter);
                DialogResult = true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
