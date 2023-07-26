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
    [EnableCors("*", "*", "*")]
    [RoutePrefix("API/Manager")]
    public class ManagerController : ApiController
    {
       //כניסה לאזור המנהלת ע"י סיסמא
        [Route("GetManager/{Password}")]
        public bool GetManager(string Password)
        {
            int x =managerBL.checkPassword(Password);
            if (x == 1)
                return true;
            else
                return false;
        }
        //מלוי כרטיסייה חדשה ללקוחה
        [HttpGet]
        [Route("BuyNewCard/{id}")]
        public int BuyNewCard(string id)
        {
            return managerBL.BuyCard(id);
        }

        //מאפס שיעורים למורה
        [Route("GetToResetLessonsToSend/{Id}")]
        public int GetToResetLessonsToSend(string id)
        {
            return managerBL.toResetLessonsToSend(id);
        }
        //בדיקה איזה ת.ז של מורה או לקוחה או לקוחה טיפולית ולפי זה בהמשך יעדכן 
        [Route("GetSearchByIdForUpdate/{Id}")]
        public int GetSearchByIdForUpdate(string id)
        {
            return managerBL.checkId(id);
        }
        //בדיקה איזה ת.ז של מורה או לקוחה או לקוחה טיפולית ולפי זה בהמשך ימחק 
        [Route("GetSearchByIdForDelete/{Id}")]
        public int GetSearchByIdForDelete(string id)
        {
            return managerBL.checkIdToDelete(id);
        }
        //מביא את פרטי הלקוחה לעדכון
        [Route("GetDataCustomer/{Id}")]
        public Customers GetDataCustomer(string id)
        {
            return managerBL.GetDataCustomer(id);
        }
        //מביא את פרטי המורה לעדכון
        [Route("GetDataTeacher/{Id}")]
        public Teachers GetDataTeacher(string id)
        {
            return managerBL.GetDataTeacher(id);
        }
        //מביא את פרטי הלקוחה הטיפולית לעדכון
        [Route("GetDataCustomerSpecial/{Id}")]
        public Customers GetDataCustomerSpecial(string id)
        {
            return managerBL.GetDataCustomerSpecial(id);
        }
        //פרטים של לקוחה המעודכנים- שליחה לעדכון
        [Route("GetUpdateCustomer/{Id}/{LastName}/{Address}/{Phone}/{Pharm}")]
        public int GetUpdateCustomer(string id,string LastName, string Address,
           string Phone, string Pharm)
        {
            return managerBL.updateCustomer(new Customers(id, LastName, Address, Phone, Pharm));
        }
        //פרטים של לקוחה טיפולית המעודכנים- שליחה לעדכון
        [Route("GetUpdateCustomerSpecial/{Id}/{LastName}/{Address}/{Phone}/{Pharm}/{type}/{area}/{thereIsReference}")]
        public int GetNewSpecialCustomer(string id,string LastName, string Address,
           string Phone, string Pharm, string type, string area, string thereIsReference)
        {
            bool Give = bool.Parse(thereIsReference);
            return managerBL.UpdateSpecialUser(new Customers(id, LastName, Address, Phone, Pharm,new TherapeuticSports(Give, type, area)));
        }
        //פרטים של מורה המעודכנים- שליחה לעדכון
        [Route("GetUpdateTeacher/{Id}/{LastName}/{Address}/{Phone}")]
        public int GetUpdateTeacher(string id,string LastName, string Address,
          string Phone)
        {
            return managerBL.updateTeacher(new Teachers(id,LastName, Address, Phone));
        }
        //מחיקת לקוחה רגילה
        [Route("GetDeleteCustomersR/{Id}")]
        public int GetDeleteCustomersR(string id)
        {
            return managerBL.deleteCustomerR(id);
        }
        //מחיקת לקוחה טיפולית
        [Route("GetDeleteCustomersT/{Id}")]
        public int GetDeleteCustomersT(string id)
        {
            return managerBL.deleteCustomerT(id);
        }
        //מחיקת מורה
        [Route("GetDeleteTeacher/{Id}")]
        public int GetDeleteTeacher(string id)
        {
            return managerBL.deleteTeacher(id);
        }
        //הצגת כל הלקוחות הרגילות
        [Route("GetShowAllCustomersR")]
        public List<DTO.Customers> GetShowAllCustomersR()
        {
         return managerBL.showCustomersR();
        }
        //הצגת כל הלקוחות הטיפוליות
        [Route("GetShowAllCustomersT")]
        public List<DTO.Customers> GetShowAllCustomersT()
        {
            return managerBL.showCustomersT();
        }
        //הצגת כל המורות
        [Route("GetShowAllTeachers")]
        public List<DTO.Teachers> GetShowAllTeachers()
        {
            return managerBL.showTeachers();
        }
        //שנוי סיסמא ללקוחה
        [Route("GetChangePasswordCustomer/{Id}/{password}")]
        public int GetChangePasswordCustomer(string id,string password)
        {
            return managerBL.ChangeCP(id, password);
        }
        //שנוי סיסמא למורה
        [Route("GetChangePasswordTeacher/{Id}/{password}")]
        public int GetChangePasswordTeacher(string id, string password)
        {
            return managerBL.ChangeTP(id, password);
        }
        //שנוי סיסמא למנהלת
        [Route("GetChangePasswordManager/{Id}/{password}")]
        public int GetChangePasswordManager(string id, string password)
        {
            return managerBL.ChangeMP(id, password);
        }


        //הוספת שיעור
        [Route("GetAddLesson/{Day}/{Hour}/{NameOfCourse}")]
        public int GetAddLesson(string day, string hour,string nameOfCourse)
        {
            return managerBL.GetAddLesson(new Lessons( day, hour,nameOfCourse));
        }

        //מחיקת שיעור
        [Route("GetDeleteLesson/{Day}/{Hour}/{NameOfCourse}")]
        public int GetDeleteLesson(string day, string hour, string nameOfCourse)
        {
            return managerBL.GetDeleteLesson(new Lessons(day, hour, nameOfCourse));
        }

        //עדכון שיעור
        //מחזיר את האוביקט שמצא לפי הנתונים
        [Route("GetIdUpdateLesson/{Day}/{Hour}/{NameOfCourse}")]
        public DTO.Lessons GetIdUpdateLesson(string day, string hour, string nameOfCourse)
        {
            return managerBL.GetIdUpdateLesson(new Lessons(day, hour, nameOfCourse));
        }
        //מעדכן לפי ה-ID את הנתונים
        [Route("GetUpdateLesson/{Id}/{Day}/{Hour}/{NameOfCourse}")]
        public int GetUpdateLesson(int id, string day, string hour, string nameOfCourse)
        {
            return managerBL.GetUpdateLesson(new Lessons(id,day, hour, nameOfCourse));
        }

        //הצגת מערכת שיעורים 
        [Route("GetShowAllLesson")]
        public List<DTO.Lessons> GetShowAllLesson()
        {
            return managerBL.GetShowAllLesson();
        }

    }
}
