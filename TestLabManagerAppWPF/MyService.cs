using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabManagerAppWPF.ChildWindow.Student;
using TestLabManagerAppWPF.ViewModel;
using TestLabLibrary.Repository;

namespace TestLabManagerAppWPF
{
    public static class MyService
    {
        public static ServiceProvider serviceProvider { get; set; } = null!;

        public static void Initialize()
        {
            // lock instane of MyService
            if (serviceProvider == null)
            {
                ServiceCollection services = new ServiceCollection();
                ConfigureServices(services);
                serviceProvider = services.BuildServiceProvider();
            }
            else
            {
                return;
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddSingleton<WindowLogin>();
            services.AddSingleton<Student>();
            services.AddSingleton(typeof(IStudentRepository), typeof(StudentRepository));
            services.AddSingleton(typeof(IQuestionRepository), typeof(QuestionRepository));
            services.AddSingleton(typeof(IPaperRepository), typeof(PaperRepository));
            services.AddSingleton(typeof(IAdminRepository), typeof(AdminRepository));
        }
    }
}
