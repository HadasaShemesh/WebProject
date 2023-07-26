using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Courses
    {
        public string Id { get; set; }
        public DayOfWeek day { get; set; }
        public TimeFull hour { get; set; }
        public Teachers teacher { get; set; }

       

        public Courses(string id, DayOfWeek day, int hour,
            int mminutes, Teachers teacher)
        {
            Id = id;
            this.day = day;
            this.hour = new TimeFull(hour, mminutes);
            this.teacher = teacher;
            
        }

        public Courses(string id, Teachers Teacher)
        {
            Id = id;
            teacher = Teacher;
          
        }

        public Courses()
        {

        }
    }
}
