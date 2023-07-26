using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TherapeuticSports:Courses
    {

        public bool ThereIsReference { get; set; }
        public string TypeOfDisability { get; set; }
        public string AreaOfDisability { get; set; }
        public string DoThereIsImprovement { get; set; }
        public int HowPrescription { get; set; }

        public TherapeuticSports(string id, bool thereIsReference,string typeOfDisability, string areaOfDisability,
            string doThereIsImprovement):base(id)
        {
            ThereIsReference = thereIsReference;
            TypeOfDisability = typeOfDisability;
            AreaOfDisability = areaOfDisability;
            DoThereIsImprovement = doThereIsImprovement;
        }

        public TherapeuticSports(string id, bool thereIsReference, string typeOfDisability, string areaOfDisability
            ) : base(id)
        {
            ThereIsReference = thereIsReference;
            TypeOfDisability = typeOfDisability;
            AreaOfDisability = areaOfDisability;
           
        }

        public TherapeuticSports(int howPrescription, string thereisimprove) : base()
        {
            HowPrescription = howPrescription;
            DoThereIsImprovement = thereisimprove;
        }

        public TherapeuticSports(bool thereIsReference, string typeOfDisability, string areaOfDisability):base()
        {
            ThereIsReference = thereIsReference;
            TypeOfDisability = typeOfDisability;
            AreaOfDisability = areaOfDisability;
        }

        public TherapeuticSports():base()
        {

        }

        public static DTO.TherapeuticSports ConvertTherapeuticSportsToDTO(DAL.TherapeuticSport t)
        {
            
            return new TherapeuticSports()
            {
                TypeOfDisability = t.TypeOfDisability,
                ThereIsReference = t.ThereIsReference,
                AreaOfDisability = t.AreaOfDisability,
                HowPrescription=(int)t.HowPrescription,
                DoThereIsImprovement=t.ThereIsImprove
            };
        }


        public static DAL.TherapeuticSport ConvertTherapeuticSportsToDAL(DTO.TherapeuticSports t)
        {
            return new DAL.TherapeuticSport()
            {
                TypeOfDisability = t.TypeOfDisability,
                ThereIsReference = t.ThereIsReference,
                AreaOfDisability = t.AreaOfDisability,
                HowPrescription = (int)t.HowPrescription
            };
        }
    }
}
