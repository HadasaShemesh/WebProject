using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Manager : Person
    {
     
        public string Password { get; set; }

        public Manager(string id, string firstName, string lastName, string password,
            string address, string phone) : base(id, firstName, lastName, address, phone)
        {
            Password = password;
        }


        public Manager():base()
        {
            Password = "123456789";
        }
    }
}
