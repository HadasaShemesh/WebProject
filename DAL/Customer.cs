//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public string CustomerId { get; set; }
        public string Password { get; set; }
        public Nullable<int> Age { get; set; }
        public string Pharm { get; set; }
        public Nullable<bool> GivePrescription { get; set; }
        public Nullable<int> NormalSport { get; set; }
        public Nullable<int> SpecialSport { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> AmountOfLesson { get; set; }
        public Nullable<bool> DoRegular { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual TherapeuticSport TherapeuticSport { get; set; }
    }
}