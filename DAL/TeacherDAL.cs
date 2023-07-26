using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public class TeacherDAL
    {
        public static int ATeacher(Teacher t)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                Teacher exist = DB.Teachers.Where(t2 => t2.password == t.password).FirstOrDefault();
                if (exist == null)
                {
                    Person existID = DB.People.Where(c2 => c2.Id == t.IdTeacher).FirstOrDefault();
                    if (existID != null)
                        return -3;
                    DB.People.Add(t.Person);
                    //DB.NormalSports.Add(t.NormalSport1);
                    t.IdTeacher = t.Person.Id;
                    DB.Teachers.Add(t);
                    DB.SaveChanges();
                    return DB.Teachers.ToList().Count();
                }
                return -2;
            }
        }

        public static int ALessonTeacher(string password)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                DAL.Teacher t = DB.Teachers.Where(c1 => c1.password == password).FirstOrDefault();
                if (t == null)
                    return -1;
                else
                {
                    DB.Teachers.First(c1 => c1.password == password).AmountOfLessonTeacher += 1;
                    DB.SaveChanges();
                    return (int)DB.Teachers.First(c1 => c1.password == password).AmountOfLessonTeacher;
                }
            }
        }
       
  }
}
