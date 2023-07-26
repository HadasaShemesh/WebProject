using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO

{
    public class Normal_sport:Courses
    {
        public string NameOfCourse { get; set; }

        //private int numofmembers;

        //public int NumOfMembers
        //{
        //    get { return numofmembers; }
        //    set
        //    {
        //        if (value > 15 && value < 25)
        //            numofmembers = value;
        //    }
        //}

        //public Normal_sport(string id, DayOfWeek day, int hour, int minutes, Teachers teacher,
        //    int numOfMembers, string name) : base(id, day, hour, minutes, teacher)
        //{
        //    NameOfCourse = name;
        //    NumOfMembers = numOfMembers;
        //}

        public Normal_sport():base()
        {

        }

        public Normal_sport(string nameOfCourse)
        {
            NameOfCourse = nameOfCourse;
        }

        public static DTO.Normal_sport ConvertNormalSportsToDTO(DAL.NormalSport t)
        {

            return new Normal_sport()
            {
                NameOfCourse = t.NameOfCourse,
          
            };
        }
    }
}
