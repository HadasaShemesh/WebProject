using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;



  namespace DTO
{
   

  public  class Customers:Person
    {

        public string Password { get; set; }

        public double Age { get; set; }

        public string Pharm { get; set; }

        public bool GivePrescription { get; set; }//הביא התחיבות

        public Normal_sport NormalSport { get; set; }

        public TherapeuticSports SpecialSport { get; set; }

        public DateTime Date { get; set; }

        public int AmountOfLesson { get; set; }

        public bool DoRegular { get; set; }
        //בנאי מלא
        public Customers(string id, string firstName, string lastName, string address,
            string phone, string pharm, string password, double age, Normal_sport normalsport, DateTime date, int amountOfLesson, bool giveprescription) : base(id, firstName, lastName, address, phone)
        {
            Pharm = pharm;
            Password = password;
            Age = age;
            NormalSport = normalsport;
            Date = date;
            GivePrescription = giveprescription;
            AmountOfLesson = amountOfLesson;
        }

        public Customers(string id, string lastName, string address,
            string phone, string pharm) : base(id, lastName, address, phone)
        {
            
            Pharm = pharm;
            
        }

        public Customers(string id, string lastName, string address,
           string phone, string pharm,TherapeuticSports t) : base(id, lastName, address, phone)
        {

            Pharm = pharm;
            SpecialSport = t;
        }
        //public Customers(string id,string lastName, string address,
        //    string phone, string pharm, string password, TherapeuticSports specialSport) : base(lastName, address, phone)
        //{
        //    Id = id;
        //    Pharm = pharm;
        //    Password = password;
        //    SpecialSport = specialSport;
        //}
        public Customers(string id, string firstName, string lastName, string address,
            string phone, string pharm, string password, double age, Normal_sport normalsport) : base(id, firstName, lastName, address, phone)
        {
            Pharm = pharm;
            Password = password;
            Age = age;
            NormalSport = normalsport;
            
        }

        
        public Customers(string id, string firstName, string lastName, string address,
           string phone, string pharm, string password, double age, DateTime date , bool doRegular,TherapeuticSports specialSport) : base(id, firstName, lastName, address, phone)
        {
            Pharm = pharm;
            Password = password;
            Age = age;
            SpecialSport = specialSport;
            Date = date;
            DoRegular = doRegular;
        }

        public Customers(string id, string firstName, string lastName, string address,
          string phone, string pharm, string password, double age, TherapeuticSports specialSport) : base(id, firstName, lastName, address, phone)
        {
            Pharm = pharm;
            Password = password;
            Age = age;
            SpecialSport = specialSport;
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
            //password = "12345";
        }
        //בנאי חלקי
        
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
          string phone, string pharm, string password, double age, DateTime date, Normal_sport normalsport, bool givePrescription) : base(id, firstName, lastName, address, phone)
        {
            Pharm = pharm;
            Password = password;
            Age = age;
            Date = date;
            NormalSport = normalsport;
            GivePrescription = givePrescription;

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

        public Customers(string firstName, string lastName, bool giveprescription) : base(firstName, lastName)
        {
            GivePrescription = giveprescription;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.NormalSport;
        }

        //convert
        // dto==> dal

        public static DAL.Customer ConvertUserToDALT(Customers customers)
        {
            DAL.Person user = new DAL.Person()
            {
                Id = customers.Id,
                FirstName = customers.FirstName,
                LastName = customers.LastName,
                Addres = customers.Address,
                Phone = customers.Phone,
            };

            DAL.TherapeuticSport t = new DAL.TherapeuticSport()
            {
                Cours= new Cours(), 
                AreaOfDisability=customers.SpecialSport.AreaOfDisability,
                ThereIsImprove=customers.SpecialSport.DoThereIsImprovement,
                TypeOfDisability=customers.SpecialSport.TypeOfDisability,
                ThereIsReference=customers.SpecialSport.ThereIsReference,
                HowPrescription=customers.SpecialSport.HowPrescription,
            };

            DAL.Customer customer= new DAL.Customer()
            {
                Person=user,
                CustomerId = user.Id,
                Pharm = customers.Pharm,
                Password = customers.Password,
                Age = (int)(customers.Age),
                Date = customers.Date,     
                DoRegular=customers.DoRegular,
                TherapeuticSport=t,
            };
            return customer;
        }

        public static DAL.Customer ConvertUserToDALR(Customers customers)
        {
            DAL.Person user = new DAL.Person()
            {
                Id = customers.Id,
                FirstName = customers.FirstName,
                LastName = customers.LastName,
                Addres = customers.Address,
                Phone = customers.Phone,
            };

            //DAL.NormalSport t = new DAL.NormalSport()
            //{
            //    NameOfCourse = customers.NormalSport.NameOfCourse,
            //};
            //DAL.CustomerAndCours cours = new DAL.CustomerAndCours()
            //{
            //    IdCourse = t.IdCourseN,
            //    IdCustomer = user.Id
            //};

            DAL.Customer customer = new DAL.Customer()
            {
                //NormalSport = cours.IdCourse,
                CustomerId = user.Id,
                Pharm = customers.Pharm,
                Password = customers.Password,
                Age = (int)(customers.Age),
                AmountOfLesson = customers.AmountOfLesson,
                GivePrescription = customers.GivePrescription,
                Date = customers.Date,
                DoRegular=customers.DoRegular,
                Person = user,
            };
            return customer;
        }

        //convert dal ==>dto
        public static Customers ConvertUserToDTOT(DAL.Customer customers)
        {

            return new Customers()
            {
                Id = customers.Person.Id,
                FirstName = customers.Person.FirstName,
                LastName = customers.Person.LastName,
                Address = customers.Person.Addres,
                Phone = customers.Person.Phone,
                Pharm = customers.Pharm,
                Password = customers.Password,
                Age = (int)customers.Age,
                Date = (DateTime)customers.Date,
                DoRegular = (bool)customers.DoRegular,
                SpecialSport =DTO.TherapeuticSports.ConvertTherapeuticSportsToDTO(customers.TherapeuticSport),
            };
        }

        public static Customers ConvertUserToDTOR(DAL.Customer customers)
        {

            return new Customers()
            {
                Id = customers.Person.Id,
                FirstName = customers.Person.FirstName,
                LastName = customers.Person.LastName,
                Address = customers.Person.Addres,
                Phone = customers.Person.Phone,
                Pharm = customers.Pharm,
                Password = customers.Password,
                Age = (int)customers.Age,
                Date = (DateTime)customers.Date,
                DoRegular = (bool)customers.DoRegular,
                GivePrescription=(bool)customers.GivePrescription,
                AmountOfLesson=(int)customers.AmountOfLesson

            };
        }
    }
}
