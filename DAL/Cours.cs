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
    
    public partial class Cours
    {
        public int Id { get; set; }
        public string IdTeacher { get; set; }
    
        public virtual NormalSport NormalSport { get; set; }
        public virtual TherapeuticSport TherapeuticSport { get; set; }
    }
}
