using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class TimeFull
    {
        public int hour { get; set; }
        public int minutes { get; set; }

        public TimeFull(int hour, int minutes)
        {
            this.hour = hour;
            this.minutes = minutes;
        }

        public TimeFull()
        {

        }
    }
}
