using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class managerDAL
    {
        public static int enterManager(string password)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                DAL.Manager p = DB.Managers.Where(c1 => c1.Password == password).FirstOrDefault();
                if(p==null)
                   return 0;
                return 1;
            }
        }
        //בכוונה יש 2 פונקציות דומות כאן כי בגווה סקריפט כל אחד שולח לפונקציות אחרות
        public static int checkId(string id)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
               Person p = DB.People.Where(c1 => c1.Id == id).FirstOrDefault();
                if (p == null)
                    return -1;
                Customer c = DB.Customers.Where(c1 => c1.CustomerId == p.Id).FirstOrDefault();
                Teacher t = DB.Teachers.Where(p1 => p1.IdTeacher == p.Id).FirstOrDefault();
                if (t == null)
                    if (c.SpecialSport != null)
                        //ספורט טיפולי
                        return 1;
                    //ספורט רגיל
                    else
                        return 2;
                //מורה
                else if (DB.Teachers.Where(c1 => c1.IdTeacher == p.Id).FirstOrDefault() != null)
                    return 3;
                else
                    return 0;
               
            }
        }

        public static int checkIdToDelete(string id)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                Person p = DB.People.Where(c1 => c1.Id == id).FirstOrDefault();
                if (p == null)
                    return -1;
                Customer c = DB.Customers.Where(c1 => c1.CustomerId == p.Id).FirstOrDefault();
                Teacher t = DB.Teachers.Where(p1 => p1.IdTeacher == p.Id).FirstOrDefault();
                if (t == null)
                    if (c.SpecialSport != null)
                        //ספורט טיפולי
                        return 1;
                    //ספורט רגיל
                    else
                        return 2;
                //מורה
                else if (DB.Teachers.Where(c1 => c1.IdTeacher == p.Id).FirstOrDefault() != null)
                    return 3;
                else
                    return 0;

            }
        }

        public static int Card(string id)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                DAL.Customer c = DB.Customers.Where(c1 => c1.CustomerId == id).FirstOrDefault();
                if (c == null||c.DoRegular==false)
                    return -1;

                if (c.AmountOfLesson == 0)
                {
                    c.GivePrescription = true;
                    c.AmountOfLesson = 10;
                    DB.SaveChanges();
                }
                
                return (int)DB.Customers.First(c1 => c1.CustomerId == id).AmountOfLesson;
            }
        }

        public static int toResetLessonsToSend(string id)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                DAL.Teacher t = DB.Teachers.Where(c1 => c1.IdTeacher == id).FirstOrDefault();
                if (t == null)
                    return -1;
                t.AmountOfLessonTeacher = 0;
                DB.SaveChanges();
                return 1;

            }
        }
        public static Customer GetDataCustomer(string id)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                return DB.Customers.Include("Person").Where(c => c.CustomerId == id).FirstOrDefault();
            }
        }
        public static Teacher getGetDataTeacher(string id)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                return DB.Teachers.Include("Person").Include("NormalSport1").Where(c => c.IdTeacher == id).FirstOrDefault();
            }
        }
        public static Customer GetDataCustomerSpecial(string id)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                return DB.Customers.Include("Person").Include("TherapeuticSport").Where(c => c.CustomerId == id).FirstOrDefault();
            }
        }
        public static int updateTeacher(Teacher teacher)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                Teacher t= DB.Teachers.Where(c1 => c1.IdTeacher == teacher.IdTeacher).FirstOrDefault();
                if (t != null) {
                t.Person.LastName = teacher.Person.LastName;
                t.Person.Addres = teacher.Person.Addres;
                t.Person.Phone = teacher.Person.Phone;
                DB.SaveChanges();
                    return 1;
                }
                return -1;
            }
        }

        public static int updateCustomerSpecial(Customer cs)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                Customer c = DB.Customers.Where(c1 => c1.CustomerId == cs.CustomerId).FirstOrDefault();
                if (c != null) { 
                c.Person.LastName = cs.Person.LastName;
                c.Person.Addres = cs.Person.Addres;
                c.Person.Phone = cs.Person.Phone;
                c.Pharm = cs.Pharm;
                TherapeuticSport sport= DB.TherapeuticSports.Where(t => t.IdCourseT == c.SpecialSport).FirstOrDefault();
                sport.AreaOfDisability = cs.TherapeuticSport.AreaOfDisability;
                sport.ThereIsReference = cs.TherapeuticSport.ThereIsReference;
                sport.TypeOfDisability = cs.TherapeuticSport.TypeOfDisability;
                DB.SaveChanges();
                    return 1;
                }
                return -1;
            }
        }
        public static int updateCustomer(Customer customer)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                Customer c = DB.Customers.Where(c1 => c1.CustomerId == customer.CustomerId).FirstOrDefault();
                if (c != null) { 
                c.Person.LastName = customer.Person.LastName;
                c.Person.Addres = customer.Person.Addres;
                c.Person.Phone = customer.Person.Phone;
                c.Pharm = customer.Pharm;
                DB.SaveChanges();
                return 1;
                }
                return -1;
            }
        }

        public static int deleteCustomer(string id)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                Customer exist = DB.Customers.Where(c2 => c2.CustomerId == id).FirstOrDefault();
                if (exist != null)
                {
                    DB.Customers.Remove(DB.Customers.First(c1 => c1.CustomerId == id));
                    DB.People.Remove(DB.People.First(c1 => c1.Id == id));
                    DB.SaveChanges();
                    Customer c = DB.Customers.Where(c1 => c1.CustomerId == id).FirstOrDefault();
                    Person p = DB.People.Where(c1 => c1.Id == id).FirstOrDefault();
                    if (p == null && c == null)
                        return 1;
                    return 0;
                }

                return -1;
            }
        }

        public static int deleteTeacher(string id)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                Teacher exist = DB.Teachers.Where(c2 => c2.IdTeacher == id).FirstOrDefault();
                if (exist != null)
                {
                    DB.Courses.Remove(DB.Courses.First(c2 => c2.Id == exist.NormalSport));
                    DB.NormalSports.Remove(DB.NormalSports.First(c => c.IdCourseN == exist.NormalSport));
                    DB.Teachers.Remove(DB.Teachers.First(c1 => c1.IdTeacher == id));
                    DB.People.Remove(DB.People.First(c1 => c1.Id == id));
                    DB.SaveChanges();
                    Person p = DB.People.Where(c1 => c1.Id == id).FirstOrDefault();
                    Teacher t = DB.Teachers.Where(c1 => c1.IdTeacher == id).FirstOrDefault();
                    if (p == null && t == null)
                        return 1;
                    return 0;
                }
                return -1;
            }
        }

        public static int deleteCustomerT(string id)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                Customer exist = DB.Customers.Where(c2 => c2.CustomerId == id).FirstOrDefault();
                if (exist != null)
                {
                    Customer customer= DB.Customers.Where(c1 => c1.CustomerId == id).FirstOrDefault();
                    DB.Courses.Remove(DB.Courses.First(c3 => c3.Id == customer.SpecialSport));
                    DB.TherapeuticSports.Remove(DB.TherapeuticSports.First(c4 => c4.IdCourseT == customer.SpecialSport));
                    DB.Customers.Remove(DB.Customers.First(c1 => c1.CustomerId == id));
                    DB.People.Remove(DB.People.First(c1 => c1.Id == id));
                    DB.SaveChanges();
                    Customer c = DB.Customers.Where(c1 => c1.CustomerId == id).FirstOrDefault();
                    Person p = DB.People.Where(c1 => c1.Id == id).FirstOrDefault();
                    TherapeuticSport t = DB.TherapeuticSports.Where(c1 => c1.IdCourseT == customer.SpecialSport).FirstOrDefault();
                    if (p == null && c == null && t==null)
                        return 1;
                    return 0;
                }
                return -1;
            }
        }



        public static List<DAL.Customer> showCustomersR()
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                List<Customer> listCustomers = DB.Customers.Include("Person").Where(C => C.DoRegular == true).ToList();
                return listCustomers;
            }
        }

        public static List<DAL.Customer> showCustomersT()
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                List<Customer> listCustomers = DB.Customers
                    .Include("Person").Include("TherapeuticSport")
                    .Where(C => C.DoRegular == false).ToList();
                return listCustomers;
            }
        }
        public static List<Teacher> showTeachers()
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                List<Teacher> listTeachers = DB.Teachers.Include("Person").Include("NormalSport1").ToList();
                return listTeachers;
            }
        }
        

        public static int ChangePasswordC(string id,string password)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                //האם קיים במערכת הסיסמא הזאת
                Customer exist = DB.Customers.Where(c2 => c2.Password == password).FirstOrDefault();
                //האם קיים במערכת הלקוח הזה
                Customer c = DB.Customers.Where(c1 => c1.CustomerId == id).FirstOrDefault();
                if (c == null)
                    return 0;
                //האם זו הסיסמא הקודמת שלו
                else if (c.Password == password)
                    return -1;
               else if (exist == null)
                {
                    //מעדכן
                    DB.Customers.First(c1 => c1.CustomerId == id).Password = password;
                    DB.SaveChanges();
                    return 1;
                }
                else 
                    return -2;
            }
        }

        public static int ChangePasswordT(string id, string password)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                Teacher t = DB.Teachers.Where(c1 => c1.IdTeacher == id).FirstOrDefault();
                Teacher exist = DB.Teachers.Where(c2 => c2.password == password).FirstOrDefault();
                if (t == null)
                    return 0;
                else if (t.password == password)
                    return -1;
                else if (exist == null)
                {
                    DB.Teachers.First(c1 => c1.IdTeacher == id).password = password;
                    DB.SaveChanges();
                    return 1;
                }
                else
                return -2;
            }
        }

        public static int ChangePasswordM(string id, string password)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                
                    Manager m = DB.Managers.Where(c2 => c2.ManagerId == id).FirstOrDefault();
                    if (m == null)
                        return 0;
                    if (m.Password == password)
                        return -1;

                    DB.Managers.First(c1 => c1.ManagerId == id).Password = password;
                    DB.SaveChanges();
                    return 1;
               
            }
        }

        public static int GetAddLesson(Lesson lesson)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                if (lesson != null) { 
                    if(DB.Lessons.Where(l1 => l1.day == lesson.day && l1.hour == lesson.hour && l1.nameOfCourse == lesson.nameOfCourse).FirstOrDefault() == null){ 
                         DB.Lessons.Add(lesson);
                         DB.SaveChanges();
                         return 1;
                    }
                    else
                        return 0;
                }
                return -1;
            }
        }

        public static int GetDeleteLesson(Lesson lesson)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                Lesson less = DB.Lessons.Where(l1 => l1.day == lesson.day && l1.hour == lesson.hour && l1.nameOfCourse == lesson.nameOfCourse).FirstOrDefault();
                if (lesson != null)
                {
                    if (less != null)
                    {
                        DB.Lessons.Remove(less);
                        DB.SaveChanges();
                        return 1;
                    }
                    else
                        return 0;
                }
                else
                    return -1;
            }
        }

        public static DAL.Lesson GetIdUpdateLesson(Lesson lesson)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                return DB.Lessons.Where(l1 => l1.day == lesson.day && l1.hour == lesson.hour && l1.nameOfCourse == lesson.nameOfCourse).FirstOrDefault();
            }
        }

        public static int GetUpdateLesson(Lesson lesson)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                Lesson l = DB.Lessons.Where(l1 =>l1.IdLesson== lesson.IdLesson).FirstOrDefault();
                if (l != null)
                {
                    l.day = lesson.day;
                    l.hour = lesson.hour;
                    l.nameOfCourse = lesson.nameOfCourse;
                    DB.SaveChanges();
                    return 1;
                }
                else
                    return -1;
            }
        }

        public static List<DAL.Lesson> showLesson()
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                List<Lesson> listLesson = DB.Lessons.ToList();
                return listLesson;
            }
        }


    }
}
