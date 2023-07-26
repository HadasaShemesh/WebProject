using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
//using Models;



namespace DAL
{
    public class CustomersDB
    {


        public static List<Customer> GetCustomers()
        {
            using (StusioSportDBEntities DB= new StusioSportDBEntities())
            {
                List<Customer> allCustomer = DB.Customers.Where(c => c.Pharm == "leumit").ToList();
                return allCustomer;
            }
        }


        public static int addCustomer(Customer c)
        {
            using (StusioSportDBEntities DB = new StusioSportDBEntities())
            {
                DB.Customers.Select(i => i.CustomerId==c.CustomerId);
                DB.Customers.Add(c);
                return DB.Customers.ToList().Count;
            }
        }

        //פונקציות שושי
        //public CustomersDB() { }
        //public List<T> GetDbSet<T>() where T : class
        //{
        //    using (StusioSportDBEntities1 DB = new StusioSportDBEntities1())
        //    {
        //        return DB.Customers<T>().ToList();
        //    }
        //}
        //public enum ExecuteActions
        //{
        //    Insert,
        //    Update,
        //    Delete
        //}


        //public void Execute<T>(T entity, ExecuteActions exAction) where T : class
        //{
        //    using (StusioSportDBEntities1 DB = new StusioSportDBEntities1())
        //    {
        //        var model = DB.Set<T>();
        //        switch (exAction)
        //        {
        //            case ExecuteActions.Insert:
        //                model.Add(entity);
        //                break;
        //            case ExecuteActions.Update:
        //                model.Attach(entity);
        //                DB.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        //                break;
        //            case ExecuteActions.Delete:
        //                model.Attach(entity);
        //                DB.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
        //                break;
        //            default:
        //                break;
        //        }
        //        DB.SaveChanges();

        //    }
        //}
    }
}

