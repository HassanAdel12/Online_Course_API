using AutoMapper;
using Online_Course_API.DTO;
using Online_Course_API.Model;

namespace Online_Course_API.Mapper
{
    public class mapping : Profile
    {
        public mapping()
        {
            CreateMap<Instructor, InstructorDTO>().ReverseMap();
            CreateMap<Student, StudentDTO>().ReverseMap();
             //.ForMember(dest => dest.Parent_Email, opt => opt.MapFrom(src => src.Parent.Email))
             //.ForMember(dest => dest.Parent_FirstName, opt => opt.MapFrom(src => src.Parent.First_Name))
             //.ForMember(dest => dest.Parent_LastName, opt => opt.MapFrom(src => src.Parent.Last_Name));


            CreateMap<StudentDTO, Student>()
                .ForMember(dest => dest.Parent, opt => opt.Ignore()); // Ignore mapping for Parent, as it's not in StudentDTO
            CreateMap<Session, SessionDTO>().ReverseMap();
            CreateMap<StudentCourseDTO, Student_Course>().ReverseMap();


            CreateMap<StudentQuizDTO, Student_Quiz>().ReverseMap();
            
        }
    }
}
