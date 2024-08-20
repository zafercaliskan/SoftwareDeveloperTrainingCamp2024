using _2ndWeek_3rdHomework.Entities.Abstract;

namespace _2ndWeek_3rdHomework.Entities.Concrete
{
    public class Instructor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
