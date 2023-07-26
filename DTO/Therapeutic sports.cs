using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Therapeutic_sports:Courses
    {

        public bool ThereIsReference { get; set; }
        public string TypeOfDisability { get; set; }
        public string AreaOfDisability { get; set; }
        public bool DoThereIsImprovement { get; set; }

        public Therapeutic_sports(string id, DayOfWeek day, int hour, int minutes, Teachers teacher, 
            bool thereIsReference,string typeOfDisability, string areaOfDisability,
            bool doThereIsImprovement):base(id, day, hour, minutes, teacher)
        {
            ThereIsReference = thereIsReference;
            TypeOfDisability = typeOfDisability;
            AreaOfDisability = areaOfDisability;
            DoThereIsImprovement = doThereIsImprovement;
        }

        public Therapeutic_sports():base()
        {

        }
    }
}
