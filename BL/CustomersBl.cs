using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DAL;
using DTO;

namespace BL

{
    public class CustomersBl
    {
        //לעשות לקוחה חדשה
        //public static int AddUser(DTO.Customers customer)
        //{
        //    DAL.Customer CDAL = DTO.Customers.ConvertUserToDALR(customer);
        //    if (CDAL.GivePrescription == true)
        //    {
        //        CDAL.AmountOfLesson = 10;
        //        CDAL.DoRegular = true;
        //        return CustomerDAL.AddCustomer(CDAL);
        //    }
        //    else
        //        return -1;
        //}

        public static int AddUser(DTO.Customers customer)
        {
             DAL.Customer CDAL = DTO.Customers.ConvertUserToDALR(customer);
             CDAL.DoRegular = true;
             return CustomerDAL.AddCustomer(CDAL);
        }
        ////להכניס לקוחה שבאה לשיעור בודד
        ////public static int AddSingleCustomer(DTO.Customers customer)
        ////{
        ////    DAL.Customer CDAL = DTO.Customers.ConvertUserToDAL1(customer);
        ////    return CustomerDAL.Single(CDAL);
        ////}

        public static int EnterByPassword(string password)
        {
           return CustomerDAL.enter(password);
        }

        //הוספת לקוח טיפולי חדש
        public static int AddSpecialUser(DTO.Customers customer)
        {
            DAL.Customer CDAL = DTO.Customers.ConvertUserToDALT(customer);
            CDAL.AmountOfLesson = 0;                                                                                                              
            CDAL.DoRegular = false;
            //CDAL.TherapeuticSport.TypeOfDisability = customer.SpecialSport.TypeOfDisability;
            return CustomerDAL.addSpecial(CDAL);

        }


        //כניסה של לקוח טיפולי קיים
        public static int specialCustomer(string password)
        {
            return CustomerDAL.enterSpecial(password);
        }
        public static int GivePrescription(string password, int amount)
        {
            return CustomerDAL.GivePrescription(password, amount);
        }
        public static int ToLessLesson(string password, int amount)
        {
            return CustomerDAL.ToLessLesson(password, amount);
        }
        public static int ThereIsImprove(string password, string text)
        {
            return CustomerDAL.ThereIsImprove(password, text);
        }
       
        //לקריאה
        //public static void DeserilazeFromXML()
        //{
        //    const string PATH = "G:\\c#\\פרויקט c#\\Project\\DAL\\xmlfiles\\customers.xml";

        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DAL.Customer>));

        //    List<DAL.Customer> newListOfUsers = new List<DAL.Customer>();
        //    using (StreamReader reader = new StreamReader(PATH))
        //    {
        //        newListOfUsers = (List<DAL.Customer>)xmlSerializer.Deserialize(reader);

        //    }
        //}
        //לכתיבה
        //public static void GetSerilazeToXML()
        //{
        //    GetSerilazeToXML(DAL.DB.Customers);
        //}

        //public static void GetSerilazeToXML(List<DAL.Customer> allusers)
        //{
        //    //const string PATH = "E:\\c#\\פרויקט c#\\Project\\DAL\\xmlfiles\\customers.xml";
        //    const string PATH = "G:\\c#\\פרויקט c#\\Project\\DAL\\xmlfiles\\customers.xml";

        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DAL.Customer>));

        //    using (StreamWriter writer = File.AppendText(PATH))
        //    {
        //        xmlSerializer.Serialize(writer, allusers);
        //    }
        //}



        //משושי
        //public class ClientsBL
        //{
        //    DbConnection dbCon;
        //    public List<Customer> listOfCusomers;
        //    public ClientsBL()
        //    {
        //        dbCon = new DBConection();
        //        listOfCusomers = dbCon.GetDbSet<Customer>().ToList();
        //    }
        //    public List<Customer> GetAllClients()
        //    {
        //        return listOfCusomers;
        //    }
        //    //הוספת לקוח
        //    public string InsertClient(Customer customer)
        //    {
        //        if (listOfCusomers.Find(c => c.CustomerId == customer.CustomerId) == null)
        //            try
        //            {
        //                dbCon.Execute<Customers>(new Customers() { codeCli = listOfCusomers.Max(c => c.Password) + 1, idC = customer.CustomerId, fullNameC = customer.firstName.ToString(), pel1 = customer.phone, pel2 = clients.pel2 }, DBConection.ExecuteActions.Insert);
        //                listOfCusomers = dbCon.GetDbSet<Customers>().ToList();
        //                return listOfCusomers.First(c => c.CustomerId == customer.CustomerId).Password;
        //            }
        //            catch (Exception ex)
        //            {
        //                return "none";
        //            }

        //        return listOfCusomers.First(c => c.CustomerId == customer.CustomerId).Password;

        //    }

        //}
    }

   
}






