using _2ndWeek_3rdHomework.Entities.Concrete;


namespace _2ndWeek_3rdHomework.DataAccess.Concrete.InMemory
{
    public class ImInstructorDal
    {
        List<Instructor> _instructors = new List<Instructor>();
        public ImInstructorDal()
        {
            _instructors = new List<Instructor>();
        }
        public void Add(Instructor entity)
        {
            _instructors.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            var found = _instructors.FirstOrDefault(c => c.Id == entity.Id);
            if (found != null)
            {
                _instructors.Remove(found);
            }
        }

        public Instructor? Get(Func<Instructor, bool> filter)
        {
            return _instructors.SingleOrDefault(filter);
        }

        public IList<Instructor> GetList(Func<Instructor, bool> filter)
        {
            return _instructors.Where(filter).ToList();
        }

        public void Update(Instructor entity)
        {
            var found = _instructors.FirstOrDefault(c => c.Id == entity.Id);
            if (found != null)
            {
                found.Name = entity.Name;
            }
        }
    }
}
