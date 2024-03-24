using AutoMapper;
using TestLabWebAPI.Models;
using TestLabWebAPI.DTOs;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Microsoft.EntityFrameworkCore;

namespace TestLabWebAPI
{
    public class Mapping : Profile
    {
        // string to dateonly
        public static DateOnly ParseDate(string date)
        {
            string[] dateParts = date.Split('-');
            return new DateOnly(int.Parse(dateParts[0]), int.Parse(dateParts[1]), int.Parse(dateParts[2]));
        }

        public Mapping() {

            CreateMap<Admin, AdminDTO>()
                .ForMember(dest => dest.Birthday, opt => opt.MapFrom(src => src.Birthday.ToString()));
            CreateMap<AdminDTO, Admin>()
                .ForMember(dest => dest.Birthday, opt => opt.MapFrom(src => ParseDate(src.Birthday)));

            CreateMap<Class, ClassDTO>().ReverseMap();
            CreateMap<Grade, GradeDTO>().ReverseMap();
            CreateMap<Permission, PermissionDTO>().ReverseMap();
            CreateMap<Question, QuestionDTO>().ReverseMap();
            CreateMap<QuestsOfTest, QuestsOfTestDTO>().ReverseMap();
            CreateMap<Score, ScoreDTO>().ReverseMap();
            CreateMap<Speciality, SpecialityDTO>().ReverseMap();
            CreateMap<Status, StatusDTO>().ReverseMap();

            CreateMap<Student, StudentDTO>()
                .ForMember(dest => dest.Birthday, opt => opt.MapFrom(src => src.Birthday.ToString()));
            CreateMap<StudentDTO, Student>()
                .ForMember(dest => dest.Birthday, opt => opt.MapFrom(src => ParseDate(src.Birthday)));

            CreateMap<StudentTestDetail, StudentTestDetailDTO>().ReverseMap();
            CreateMap<Subject, SubjectDTO>().ReverseMap();

            CreateMap<Teacher, TeacherDTO>()
                .ForMember(dest => dest.Birthday, opt => opt.MapFrom(src => src.Birthday.ToString()));
            CreateMap<TeacherDTO, Teacher>()
                .ForMember(dest => dest.Birthday, opt => opt.MapFrom(src => ParseDate(src.Birthday)));

            CreateMap<Test, TestDTO>().ReverseMap();
        }
        
    }
}
