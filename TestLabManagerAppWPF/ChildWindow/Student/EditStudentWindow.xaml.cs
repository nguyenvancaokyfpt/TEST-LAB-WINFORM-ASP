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

namespace TestLabManagerAppWPF.ChildWindow.Student
{
    /// <summary>
    /// Interaction logic for EditStudentWindow.xaml
    /// </summary>
    public partial class EditStudentWindow : Window
    {
        TlStudent tlStudent;
        public EditStudentWindow(TlStudentObj tlStudent)
        {
            InitializeComponent();
            this.tlStudent = MyMapper.mapper.Map<TlStudent>(tlStudent);
            SetStudent(this.tlStudent);
        }

        private void SetStudent(TlStudent tlStudent)
        {
            txtFullname.Text = tlStudent.Fullname;
            txtUsername.Text = tlStudent.Username;
            txtPassword.Text = tlStudent.Password;
            txtId.Text = tlStudent.Id.ToString();
        }

        private TlStudent? GetTlStudent()
        {
            TlStudent tlStudent = this.tlStudent;
            try
            {
                // check empty all field
                if (txtUsername.Text == "" || txtPassword.Text == "" || txtFullname.Text == "")
                {
                    MessageBox.Show("Please fill all field");
                    return null;
                }
                // check password length
                if (txtPassword.Text.Length < 3)
                {
                    MessageBox.Show("Password must be at least 3 characters");
                    return null;
                }
                tlStudent.Username = txtUsername.Text;
                tlStudent.Password = txtPassword.Text;
                tlStudent.Fullname = txtFullname.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tlStudent;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void btnSave(object sender, RoutedEventArgs e)
        {
            // get student
            TlStudent? tlStudent = GetTlStudent();
            if (tlStudent != null)
            {
                // update student
                var studentRepository = MyService.serviceProvider.GetService<IStudentRepository>();
                studentRepository.UpdateStudent(tlStudent);
                // close dialog and return true
                DialogResult = true;
            }
        }

        private void btnCancel(object sender, RoutedEventArgs e)
        {
            // close dialog and return false
            DialogResult = false;
        }
    }
}
