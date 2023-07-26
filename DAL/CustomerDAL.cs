using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
  public  class CustomerDAL
    {

        public static int AddCustomer(Customer c)
        {
            using(StusioSportDBEntities DB =new StusioSportDBEntities())
            {
                Customer existP = DB.Customers.Where(c2 => c2.Password == c.Password).FirstOrDefault();
                if (existP == null)
                {
                    Person existID= DB.People.Where(c2 => c2.Id == c.CustomerId).FirstOrDefault();
                    if (existID != null)
                        return -3;
                    else { 
                    DB.People.Add(c.Person);
                    c.CustomerId = c.Person.Id;
                    DB.Customers.Add(c);
                    DB.SaveChanges();
                    return DB.Customers.ToList().Count;
                    }
                }
                return -2;                              
            }
        }

        ////public static int Single(Customer c)
        ////{
        ////    using (StusioSportDBEntities DB = new StusioSportDBEntities())
        ////    {
        ////        DB.Customers.Add(c);
        ////        DB.SaveChanges();
        ////        return DB.Customers.ToList().Count;
        ////    }
        ////}
        public static int enter(string password)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                DAL.Customer c = DB.Customers.Where(c1 => c1.Password == password).FirstOrDefault();
                if (c == null)
                    return 0;
                if (c.AmountOfLesson == 0)
                    return -1;
                DB.Customers.First(c1 => c1.Password == password).AmountOfLesson -= 1;
                DB.SaveChanges();
                return (int)DB.Customers.First(c1 => c1.Password == password).AmountOfLesson;
            }
        }


        public static int enterSpecial(string password)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                DAL.Customer c = DB.Customers.Where(c1 => c1.Password == password).FirstOrDefault();
                if (c == null)
                    return 0;
                if(c.DoRegular==false)
                   return 1;
                return -1;
            }
        }
        public static int addSpecial(Customer c)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                Customer exist = DB.Customers.Where(c2 => c2.Password == c.Password).FirstOrDefault();
                if (exist == null)
                {
                    Person existID = DB.People.Where(c2 => c2.Id == c.CustomerId).FirstOrDefault();
                    if (existID != null)
                        return -3;
                    DB.People.Add(c.Person);
                    //c.SpecialSport = c.TherapeuticSport.IdCourseT;
                    DB.TherapeuticSports.Add(c.TherapeuticSport);
                    c.CustomerId = c.Person.Id;
                    DB.Customers.Add(c);
                    DB.SaveChanges();
                    return DB.Customers.ToList().Count;
                }
                return -2;
            }
        }

        public static int GivePrescription(string password, int amount)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                DAL.Customer c= DB.Customers.Where(c1 => c1.Password == password).FirstOrDefault();
                if (c == null)
                    return -1;
                else
                {
                    c.TherapeuticSport.HowPrescription += amount;
                    DB.SaveChanges();
                   return (int)c.TherapeuticSport.HowPrescription;
                    
                }
            }
        }

        public static int ToLessLesson(string password, int amount)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                Customer c = DB.Customers.Where(c1 => c1.Password == password).FirstOrDefault();
               
                if (c == null)
                    return -1;
                else
                {
                    if (c.TherapeuticSport.HowPrescription <= 0)
                        return 0;
                    c.TherapeuticSport.HowPrescription -= amount;
                    DB.SaveChanges();
                    return (int)c.TherapeuticSport.HowPrescription;
                }
            }
        }

        public static int ThereIsImprove(string password, string text)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                DAL.Customer c = DB.Customers.Where(c1 => c1.Password == password).FirstOrDefault();
                if (c == null)
                    return -1;
                else
                {
                    c.TherapeuticSport.ThereIsImprove = text;
                    DB.SaveChanges();
                    return 1;
                }
            }
        }

  }
}


