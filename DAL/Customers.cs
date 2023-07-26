using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;




namespace DAL
{
   

  public  class Customers:Person
    {

        private string password;

        public string Password
        {
            get { return password; }
            set { if (value.Length == 5)
                    password = value; }
        }
        public double Age { get; set; }

        public string Pharm { get; set; }

        public bool GivePrescription { get; set; }//הביא התחיבות
        public Normal_sport NormalSport { get; set; }

        public TherapeuticSports SpecialSport { get; set; }
        public DateTime Date { get; set; }

        public int AmountOfLesson { get; set; }

        //בנאי מלא
        public Customers(string id, string firstName, string lastName, string address, 
            string phone, string pharm, string password,double age, Normal_sport normalsport, DateTime date, int amountOfLesson, bool giveprescription) : base(id, firstName, lastName, address, phone)
        {
            Pharm= pharm;
            Password = password;
            Age = age;
            NormalSport= normalsport;
            Date = date;
            GivePrescription = giveprescription;
            AmountOfLesson = amountOfLesson;
        }


        public Customers(string id, string firstName, string lastName, string address,
          string phone, string pharm, string password, double age, TherapeuticSports specialSport, DateTime date) : base(id, firstName, lastName, address, phone)
        {
            Pharm = pharm;
            Password = password;
            Age = age;
            SpecialSport = specialSport;
            Date = date;

        }
        public Customers(string id, string firstName, string lastName, string address,
          string phone, string pharm, string password, double age, DateTime date) : base(id, firstName, lastName, address, phone)
        {
            Pharm = pharm;
            Password = password;
            Age = age;
            Date = date;
        }


        //בנאי ריק- ברירת מחדל
        public Customers():base()
        {
            password = "12345";
        }
        //בנאי חלקי
        public Customers(string firstName, string lastName,bool giveprescription) : base(firstName, lastName)
        {
            GivePrescription = giveprescription;
        }
        public Customers(string id, string firstName, string lastName, string address,
           string phone, string pharm, string password, double age, int amountOfLesson) : base(id, firstName, lastName, address, phone)
        {
            Pharm = pharm;
            Password = password;
            Age = age;
            AmountOfLesson = amountOfLesson;
            
        }
       

        public Customers(string id, string firstName, string lastName, string address,
          string phone, string pharm, string password, double age,DateTime date, Normal_sport normalsport, bool givePrescription) : base(id, firstName, lastName, address, phone)
        {
            Pharm = pharm;
            Password = password;
            Age = age;
            Date = date;
            NormalSport = normalsport;
            GivePrescription = givePrescription;

        }



        public Customers(string id, string firstName, string lastName, string address,
            string phone, string pharm, string password, double age, int amountOfLesson, DateTime date, Normal_sport normalsport) : base(id, firstName, lastName, address, phone)
        {
            Pharm = pharm;
            Password = password;
            Age = age;
            AmountOfLesson = amountOfLesson;
            Date = date;
            NormalSport = normalsport;

        }

        public Customers(string id, string firstName, string lastName, string address,
         string phone, string pharm, string password, double age, DateTime date, Normal_sport normalsport) : base(id, firstName, lastName, address, phone)
        {
            Pharm = pharm;
            Password = password;
            Age = age;
            Date = date;
            NormalSport = normalsport;

        }

        public Customers(string id, string firstName, string lastName, string address,
          string phone, string pharm, double age) : base(id, firstName, lastName, address, phone)
        {
            Pharm = pharm;
            Age = age;

        }
        
        public override string ToString()
        {
            return base.ToString() + " " + this.NormalSport;
        }





    }
}
