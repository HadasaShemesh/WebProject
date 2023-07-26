using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Lessons
    {
        public int IdLesson { get; set; }
        public string Day { get; set; }
        public string Hour { get; set; }
        public string NameOfCourse { get; set; }

        public Lessons(int idLesson, string day, string hour, string nameOfCourse)
        {
            IdLesson = idLesson;
            Day = day;
            Hour = hour;
            NameOfCourse = nameOfCourse;
        }

        public Lessons( string day, string hour, string nameOfCourse)
        {
            Day = day;
            Hour = hour;
            NameOfCourse = nameOfCourse;
        }

        public Lessons()
        {

        }


        public static DAL.Lesson ConvertLessonToDAL(DTO.Lessons L)
        {
            return new DAL.Lesson()
            {
                IdLesson = L.IdLesson,
                day = L.Day,
                hour=L.Hour,
                nameOfCourse=L.NameOfCourse
            };
        }

        public static DTO.Lessons ConvertLessonToDTO(DAL.Lesson L)
        {
            return new DTO.Lessons()
            {
                IdLesson = L.IdLesson,
                Day = L.day,
                Hour = L.hour,
                NameOfCourse = L.nameOfCourse
            };
        }
    }
}
