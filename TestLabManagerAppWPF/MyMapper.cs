using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;
using TestLabEntity.BusinessObject;

namespace TestLabManagerAppWPF
{
    public static class MyMapper
    {
        private static bool _isInitialized;
        public static Mapper mapper { get; set; } = null!;
        public static void Initialize()
        {
            if (_isInitialized)
                return;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TlStudent, TlStudentObj>();
                cfg.CreateMap<TlPaper, TlPaperObj>();
                cfg.CreateMap<TlQuestion, TlQuestionObj>();
                cfg.CreateMap<TlAdmin, TlAdminObj>();
                cfg.CreateMap<TlCourse, TlCourseObj>();
                cfg.CreateMap<TlChapter, TlChapterObj>();
                cfg.CreateMap<TlAnswer, TlAnswerObj>();
                cfg.CreateMap<TlQuestionPaper, TlQuestionPaperObj>();
                cfg.CreateMap<TlSubmitpaper, TlSubmitpaperObj>();
                cfg.CreateMap<TlSubmitpaperDetail, TlSubmitpaperDetailObj>();

                cfg.CreateMap<TlStudentObj, TlStudent>();
                cfg.CreateMap<TlPaperObj, TlPaper>();
                cfg.CreateMap<TlQuestionObj, TlQuestion>();
                cfg.CreateMap<TlAdminObj, TlAdmin>();
                cfg.CreateMap<TlCourseObj, TlCourse>();
                cfg.CreateMap<TlChapterObj, TlChapter>();
                cfg.CreateMap<TlAnswerObj, TlAnswer>();
                cfg.CreateMap<TlQuestionPaperObj, TlQuestionPaper>();
                cfg.CreateMap<TlSubmitpaperObj, TlSubmitpaper>();
                cfg.CreateMap<TlSubmitpaperDetailObj, TlSubmitpaperDetail>();

            });
            mapper = new Mapper(config);
            _isInitialized = true;
        }
    }
}
