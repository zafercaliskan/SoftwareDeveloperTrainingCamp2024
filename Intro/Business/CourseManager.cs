using Intro.DataAccess.Abstracts;
using Intro.Entities;

namespace Intro.Business
{

    public class CourseManager
    {
        //dependency injection
        private readonly ICourseDal _courseDal;

        //constructor
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        Course[] courses = new Course[3];

        public List<Course> GetAll()
        {
            // business rules
            return _courseDal.GetAll();
        }
    }
}