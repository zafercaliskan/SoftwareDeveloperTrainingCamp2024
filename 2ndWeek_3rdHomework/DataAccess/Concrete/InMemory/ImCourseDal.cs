using _2ndWeek_3rdHomework.Entities.Concrete;


namespace _2ndWeek_3rdHomework.DataAccess.Concrete.InMemory
{
    public class ImCourseDal
    {
        List<Course> _courses = new List<Course>();
        public ImCourseDal()
        {
            _courses = new List<Course>();
        }
        public void Add(Course entity)
        {
            _courses.Add(entity);
        }

        public void Delete(Course entity)
        {
            var found = _courses.FirstOrDefault(c => c.Id == entity.Id);
            if (found != null)
            {
                _courses.Remove(found);
            }
        }

        public Course? Get(Func<Course, bool> filter)
        {
            return _courses.SingleOrDefault(filter);
        }

        public IList<Course> GetList(Func<Course, bool> filter)
        {
            return _courses.Where(filter).ToList();
        }

        public void Update(Course entity)
        {
            var course = _courses.FirstOrDefault(c => c.Id == entity.Id);
            if (course != null)
            {
                course.CourseName = entity.CourseName;
            }
        }
    }
}
