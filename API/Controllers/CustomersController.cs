using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BL;
using DTO;


namespace API.Controllers
{
    [EnableCors("*","*","*")]
    [RoutePrefix("API/Customers")]
    public class CustomersController : ApiController
    {
        [Route("GetSayHello/{name}")]
        public string GetSayHello(string name)
        {
            return "hello " + name;
        }
       
        //[Route("GetNewCustomer/{FirstName}/{LastName}/{Id}/{Address}/{Phone}/{Pharm}/{Password}/{Age}/{Date}/{NormalSport}/{GivePrescription}")]
        //public int GetNewCustomer(string FirstName, string LastName, string Id, string Address,
        //    string Phone, string Pharm, string Password, double Age, DateTime Date, string NormalSport,string GivePrescription)
        //{
        //    DTO.Normal_sport normalsport = new DTO.Normal_sport(NormalSport);
        //    bool Give = bool.Parse(GivePrescription);
        //    return CustomersBl.AddUser(new Customers(Id, FirstName, LastName, Address, Phone, Pharm,
        //        Password, Age, Date, normalsport, Give));
        //}

        ///הכנסת לקוחה חדשה
        [Route("GetNewCustomer/{FirstName}/{LastName}/{Id}/{Address}/{Phone}/{Pharm}/{Password}/{Age}/{Date}")]
        public int GetNewCustomer(string FirstName, string LastName, string Id, string Address,
            string Phone, string Pharm, string Password, double Age, DateTime Date)
        {
            return CustomersBl.AddUser(new Customers(Id, FirstName, LastName, Address, Phone, Pharm,
                Password, Age, Date));
        }

        //[Route("GetNewCustomer/{FirstName}/{LastName}/{Id}/{Address}/{Phone}/{Pharm}/{Password}/{Age}/{Date}/{NormalSport}")]
        //public int GetNewCustomer(string FirstName, string LastName, string Id, string Address,
        //    string Phone, string Pharm, string Password, double Age, DateTime Date, string NormalSport)
        //{
        //    DTO.Normal_sport normalsport = new DTO.Normal_sport(NormalSport);
        //    return CustomersBl.AddUser(new Customers(Id, FirstName, LastName, Address, Phone, Pharm,
        //        Password, Age, Date, normalsport));
        //}

        //כניסה להורדת שיעורים ללקוחה ע"י סיסמא
        //[HttpGet]
        [Route("GetEnterByPassword/{password}")]
        public int GetEnterByPassword(string password)
        {
            return CustomersBl.EnterByPassword(password);
        }

        //לקוחה טיפולית
        //כמה התחייבויות הביאה ועדכון
        [Route("GetGivePresCripTion/{Password}/{Amount}")]
        public int GetGivePresCripTion(string password, int amount)
        {
            return CustomersBl.GivePrescription(password, amount);
        }

        //בלקוחה טיפולית
        //כמה התחיבויות לפי שיעורים להוריד
        [Route("GetToLessLesson/{Password}/{Amount}")]
        public int GetToLessLesson(string password, int amount)
        {
            return CustomersBl.ToLessLesson(password, amount);
        }

        //בלקוחה טיפולית
        //האם יש שיפור 
        [Route("GetThereIsImprove/{Password}/{Text}")]
        public int GetThereIsImprove(string password, string Text)
        {
            return CustomersBl.ThereIsImprove(password, Text);
        }
        //כניסה לספורט הטיפולי לאזור האישי ע"י סיסמא
        [Route("GetSpecialCPassword/{password}")]
        public bool GetSpecialCPassword(string password)
        {

            int x = CustomersBl.specialCustomer(password);
            if (x == 1)
                return true;
            else
                return false;
        }
        //הכנסת לקוחה טיפולית חדשה
        [Route("GetNewSpecialCustomer/{FirstName}/{LastName}/{Id}/{Address}/{Phone}/{Pharm}/{Password}/{Age}/{Date}/{type}/{area}/{thereIsReference}")]
        public int GetNewSpecialCustomer(string FirstName, string LastName, string Id, string Address,
           string Phone, string Pharm, string Password, double Age, DateTime Date, string type, string area, string thereIsReference)
        {
            bool Give = bool.Parse(thereIsReference);
            return CustomersBl.AddSpecialUser(new Customers(Id, FirstName, LastName, Address, Phone, Pharm,
                Password, Age, new TherapeuticSports(Give, type, area), Date));
        }
       
        
        //[Route("GetSerilazeToXML")]

        //public void GetSerilazeToXML()
        //{
        //    CustomersBl.GetSerilazeToXML();
        //}



        //[Route ("GetDeserilazeFromXML")]

        //public void GetDeserilazeFromXML()
        //{
        //    CustomersBl.DeserilazeFromXML();
        //}
    }
}
