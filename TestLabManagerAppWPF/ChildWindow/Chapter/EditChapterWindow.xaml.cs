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

namespace TestLabManagerAppWPF.ChildWindow.Chapter
{
    /// <summary>
    /// Interaction logic for EditChapterWindow.xaml
    /// </summary>
    public partial class EditChapterWindow : Window
    {
        TlChapter tlChapter;
        public EditChapterWindow(TlChapterObj tlChapterObj)
        {
            InitializeComponent();
            var courseRepo = MyService.serviceProvider.GetRequiredService<IQuestionRepository>();
            cmbCourse.ItemsSource = courseRepo.GetCourses();
            this.tlChapter = MyMapper.mapper.Map<TlChapter>(tlChapterObj);
            cmbCourse.SelectedValue = tlChapter.CourseId;
            txtChapterName.Text = tlChapter.ChapterName;
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
                TlChapter tlChapter = this.tlChapter;
                tlChapter.ChapterName = txtChapterName.Text;
                tlChapter.CourseId = (int)cmbCourse.SelectedValue;
                tlChapter.CreateBy = 1;
                var chapterRepo = MyService.serviceProvider.GetRequiredService<IQuestionRepository>();
                chapterRepo.UpdateChapter(tlChapter);
                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
