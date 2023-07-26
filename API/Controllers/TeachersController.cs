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
    [RoutePrefix("API/Teachers")]
    public class TeachersController : ApiController
    {
        //הכנסת מורה חדשה
        [Route("GetNewTeacher/{FirstName}/{LastName}/{Id}/{Address}/{Phone}/{Course}/{Password}")]
        public int GetNewTeacher(string FirstName, string LastName, string Id, string Address,
            string Phone,string Course, string Password)
        {
            DTO.Normal_sport normalsport = new DTO.Normal_sport(Course);
            return TeachersBl.AddTeacher(new Teachers(Id, FirstName, LastName, Address, Phone, Password, normalsport));
        }
        //הוספת שיעורים למורה
        [Route("GetAddLesson/{Password}") ]
        public int GetAddLesson(string password)
        {
            return BL.TeachersBl.AddLessonToTeacher(password);
        }


    }
}
