using AutoMapper;
using Online_Course_API.DTO;
using Online_Course_API.Model;

namespace Online_Course_API.Mapper
{
    public class mapping : Profile
    {
        public mapping()
        {
            CreateMap<Choise, ChoiseDTO>().ReverseMap();
            CreateMap<Course, CourseDTO>().ReverseMap();
            CreateMap<Grade, GradeDTO>().ReverseMap();
            CreateMap<Group, GroupDTO>().ReverseMap();
            CreateMap<Question, QuestionDTO>().ReverseMap();
            CreateMap<Quiz, QuizDTO>().ReverseMap();
        }
    }
}
