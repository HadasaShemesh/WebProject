using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Teachers:Person
    {

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length == 7)
                    password = value;
            }
        }
        public Normal_sport Course { get; set; }

        public int AmountOfLessonTeacher { get; set; }
        //בנאי מלא
        public Teachers(string id, string firstName, string lastName, string address,
            string phone, string password, int amountOfLessonTeacher) : base(id, firstName, lastName, address, phone)
        {
            Password = password;
            AmountOfLessonTeacher = amountOfLessonTeacher;
        }

        public Teachers(string id, string firstName, string lastName, string address,
           string phone, string password, int amountOfLessonTeacher,Normal_sport course) : base(id, firstName, lastName, address, phone)
        {
            Password = password;
            AmountOfLessonTeacher = amountOfLessonTeacher;
            Course = course;
        }
        public Teachers(string id, string firstName, string lastName, string address,
         string phone, string password, Normal_sport course) : base(id, firstName, lastName, address, phone)
        {
            Password = password;
            Course = course;
        }
        public Teachers(string id, string firstName, string lastName, string address,
          string phone, string password) : base(id, firstName, lastName, address, phone)
        {
            Password = password;
        }
        //בנאי ריק 
        public Teachers():base()
        {
            password = "1234567";
        }
        //בנאי חלקי
        public Teachers(string id, string firstName, string lastName):base(id,  firstName,  lastName)
        {
           
        }

        public Teachers(string password,int amountOfLessonTeacher) : base()
        {
            Password = password;
            AmountOfLessonTeacher = amountOfLessonTeacher;
        }

    }
    
}
