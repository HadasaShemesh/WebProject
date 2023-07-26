using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using DTO;
using DAL;

namespace BL
{
   public class managerBL
    {
        public static int BuyCard(string id)
        {
            return managerDAL.Card(id);
        }
        public static int toResetLessonsToSend(string id)
        {
            return managerDAL.toResetLessonsToSend(id);
        }
        public static int checkPassword(string password)
        {
            return managerDAL.enterManager(password);
        }
        public static int deleteCustomerR(string id)
        {
            return managerDAL.deleteCustomer(id);
        }

        public static Customers GetDataCustomer(string id)
        {
            DAL.Customer c1 = managerDAL.GetDataCustomer(id);
            DTO.Customers c = DTO.Customers.ConvertUserToDTOR(c1);
            return c;
        }

        public static DTO.Teachers GetDataTeacher(string id)
        {
            DAL.Teacher t1 = managerDAL.getGetDataTeacher(id);
            DTO.Teachers t = DTO.Teachers.ConvertTeacherToDTO(t1);
            return t;
        }

        public static DTO.Customers GetDataCustomerSpecial(string id)
        {
            
            DAL.Customer c1 = managerDAL.GetDataCustomerSpecial(id);
            DTO.Customers c = DTO.Customers.ConvertUserToDTOT(c1);
            return c;
        }
        public static int deleteTeacher(string id)
        {
            return managerDAL.deleteTeacher(id);
        }

        public static int deleteCustomerT(string id)
        {
            return managerDAL.deleteCustomerT(id);
        }

        public static int checkId(string id)
        {
            return managerDAL.checkId(id);
        }

        public static int checkIdToDelete(string id)
        {
            return managerDAL.checkIdToDelete(id);
        }
        public static int updateCustomer(DTO.Customers customer)
        {
                DAL.Customer CDAL = DTO.Customers.ConvertUserToDALR(customer);
                return managerDAL.updateCustomer(CDAL);
        }

        public static int UpdateSpecialUser(DTO.Customers customer)
        {
            DAL.Customer CDAL = DTO.Customers.ConvertUserToDALT(customer);
            return managerDAL.updateCustomerSpecial(CDAL);
        }
        public static int updateTeacher(DTO.Teachers teacher)
        {
            DAL.Teacher CDAL = DTO.Teachers.ConvertTeacherToDAL1(teacher);
            return managerDAL.updateTeacher(CDAL);
        }
        public static List<DTO.Customers> showCustomersR()
        {
            List<DAL.Customer> listCustomers= managerDAL.showCustomersR();
            List<DTO.Customers> c = new List<DTO.Customers>();
            for(int i=0;i< listCustomers.Count; i++)
            {
                c.Add(DTO.Customers.ConvertUserToDTOR(listCustomers[i]));
            }
            return c;
        }

        public static List<DTO.Customers> showCustomersT()
        {
            List<DAL.Customer> listCustomers = managerDAL.showCustomersT();
            List<DTO.Customers> c = new List<DTO.Customers>();
            for (int i = 0; i < listCustomers.Count; i++)
                c.Add(DTO.Customers.ConvertUserToDTOT(listCustomers[i]));
           
            return c;
        }

        public static List<DTO.Teachers> showTeachers()
        {
            List<Teacher> listTeachers = managerDAL.showTeachers();
            List<DTO.Teachers> t = new List<DTO.Teachers>();
            for (int i = 0; i < listTeachers.Count; i++)
                t.Add(DTO.Teachers.ConvertTeacherToDTO(listTeachers[i]));
           
            return t;
        }

        public static int ChangeCP(string id,string password)
        {
            return managerDAL.ChangePasswordC(id,password);
        }

        public static int ChangeTP(string id, string password)
        {
            return managerDAL.ChangePasswordT(id, password);
        }

        public static int ChangeMP(string id, string password)
        {
            return managerDAL.ChangePasswordM(id, password);
        }

        public static int GetAddLesson(Lessons lesson)
        {
            DAL.Lesson lesson1 =DTO.Lessons.ConvertLessonToDAL(lesson);
            return managerDAL.GetAddLesson(lesson1);
        }

        public static int GetDeleteLesson(Lessons lesson)
        {
            DAL.Lesson lesson1 = DTO.Lessons.ConvertLessonToDAL(lesson);
            return managerDAL.GetDeleteLesson(lesson1);
        }

        public static DTO.Lessons GetIdUpdateLesson(Lessons lesson)
        {
            DAL.Lesson lesson1 = DTO.Lessons.ConvertLessonToDAL(lesson);
            DAL.Lesson l1= managerDAL.GetIdUpdateLesson(lesson1);
            if (l1 == null)
                return null;
            return  DTO.Lessons.ConvertLessonToDTO(l1);

        }
        public static int GetUpdateLesson( Lessons lesson)
        {
            DAL.Lesson lesson1 = DTO.Lessons.ConvertLessonToDAL(lesson);
            return managerDAL.GetUpdateLesson( lesson1);
        }

        public static List<DTO.Lessons> GetShowAllLesson()
        {
            List<DAL.Lesson> listLessons = managerDAL.showLesson();
            List<DTO.Lessons> l = new List<DTO.Lessons>();
            for (int i = 0; i < listLessons.Count; i++)
            {
                l.Add(DTO.Lessons.ConvertLessonToDTO(listLessons[i]));
            }
            return l;
        }
    }
}
