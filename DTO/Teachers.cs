using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace DTO
{
    public class Teachers:Person
    {
        public string Password { get; set; }

        public Normal_sport Course { get; set; }
        public int AmountOfLessonTeacher { get; set; }

        //בנאי מלא
        public Teachers(string id, string firstName, string lastName, string address,
            string phone, string password,int amountOfLessonTeacher) : base( id,  firstName,  lastName, address, phone)
        {
            Password = password;
            AmountOfLessonTeacher = amountOfLessonTeacher;
        }

        //public Teachers(string id,string lastName, string address,
        //    string phone, string password) : base(lastName, address, phone)
        //{
        //    Id = id;
        //    Password = password;
        //}
        public Teachers(string id, string firstName, string lastName, string address,
          string phone, string password, int amountOfLessonTeacher, Normal_sport course) : base(id, firstName, lastName, address, phone)
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

        public Teachers(string id, string lastName, string address,
          string phone) : base(id, lastName, address, phone)
        {
        }
        public Teachers(string id, string firstName, string lastName, string address,
           string phone, string password) : base(id, firstName, lastName, address, phone)
        {
            Password = password;
            
        }
        //בנאי ריק 
        public Teachers():base()
        {
            Password = "1234567";
        }
        //בנאי חלקי
        public Teachers(string id, string firstName, string lastName):base(id,  firstName,  lastName)
        {
           
        }
        public Teachers(string password, int amountOfLessonTeacher) : base()
        {
            Password = password;
            AmountOfLessonTeacher = amountOfLessonTeacher;
        }


       

        public static DAL.Teacher ConvertTeacherToDAL(Teachers teachers)
        {
            DAL.Person teacher = new DAL.Person()
            {
                Id = teachers.Id,
                FirstName = teachers.FirstName,
                LastName = teachers.LastName,
                Addres = teachers.Address,
                Phone = teachers.Phone,
            };
           

            DAL.NormalSport normal = new DAL.NormalSport()
            {
                Cours = new Cours(),
                NameOfCourse = teachers.Course.NameOfCourse
            };

            Teacher t = new Teacher()
            {
                IdTeacher = teacher.Id,
                password = teachers.Password,
                NormalSport1 =normal,
                AmountOfLessonTeacher = teachers.AmountOfLessonTeacher,
                Person = teacher
            };
            return t;
        }


        public static DAL.Teacher ConvertTeacherToDAL1(Teachers teachers)
        {
            DAL.Person teacher = new DAL.Person()
            {
                Id = teachers.Id,
                FirstName = teachers.FirstName,
                LastName = teachers.LastName,
                Addres = teachers.Address,
                Phone = teachers.Phone,
            };


   

            Teacher t = new Teacher()
            {
                IdTeacher = teacher.Id,
                password = teachers.Password,
                AmountOfLessonTeacher = teachers.AmountOfLessonTeacher,
                Person = teacher
            };
            return t;
        }
        //public static DAL.Teacher ConvertTeacherToDAL1(Teachers teachers)
        //{
        //    DAL.Person teacher = new DAL.Person()
        //    {
        //        Id = teachers.Id,
        //        FirstName = teachers.FirstName,
        //        LastName = teachers.LastName,
        //        Addres = teachers.Address,
        //        Phone = teachers.Phone,
        //    };


        //    Teacher t = new Teacher()
        //    {
        //        IdTeacher = teacher.Id,
        //        password = teachers.password,
        //        AmountOfLessonTeacher = teachers.AmountOfLessonTeacher,
        //        Person = teacher
        //    };
        //    return t;
        //}

        //convert dal ==>dto
        public static DTO.Teachers ConvertTeacherToDTO(DAL.Teacher teachers)
        {

            return new Teachers()
            {
                Id =teachers.Person.Id,
                FirstName = teachers.Person.FirstName,
                LastName = teachers.Person.LastName,
                Address = teachers.Person.Addres,
                Phone = teachers.Person.Phone,
                Password = teachers.password,
                AmountOfLessonTeacher = (int)teachers.AmountOfLessonTeacher,
                Course = Normal_sport.ConvertNormalSportsToDTO(teachers.NormalSport1),
                
            };

        }

        

    }

}
