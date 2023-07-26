using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    public class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
       
        public Person(string id, string firstName, string lastName, string address, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
        }
         public Person(string id, string lastName, string address,string phone)
        {
            Id = id;
            LastName = lastName;
            Address = address;
            Phone = phone;
        }
        public Person()
        {
            //Id = "NULL";
            //FirstName = "guest";
        }


        public Person(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName)
        {
       
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual string ToString()
        {

            return this.Id + ": " + this.LastName + " " + this.FirstName;
        }

        public override bool Equals(object obj)
        {

            return base.Equals(obj);
        }

        public static Person ConvertPersonToDTO(DAL.Person p)
        {
            return new DTO.Person()
            { 
                FirstName=p.FirstName,
                LastName=p.LastName,
                Id=p.Id,
                Address=p.Addres,
                Phone=p.Phone
            };
        }

        public static DAL.Person ConvertPersonToDAL(DTO.Person p)
        {
            return new DAL.Person()
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                Id = p.Id,
                Addres = p.Address,
                Phone = p.Phone
            };
        }
    }
}
