using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class TeachersBl
    {
        public static int AddTeacher(DTO.Teachers teachers)
        {
            DAL.Teacher TDAL = DTO.Teachers.ConvertTeacherToDAL(teachers);
            TDAL.AmountOfLessonTeacher = 0;
            return TeacherDAL.ATeacher(TDAL);

        }

        public static int AddLessonToTeacher(string password)
        {
            return TeacherDAL.ALessonTeacher(password);
        }
    }
}
