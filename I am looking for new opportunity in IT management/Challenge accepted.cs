using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_am_looking_for_new_opportunity_in_IT_management
{
    class Challenge_accepted : Wide_IT_overview
    {
        private DateTime I_Am_Available = new DateTime (2017,04,01);
        
        private bool Working_Location_Accepted = false;

        public bool Location(string Working_Location)
            {
            if (Working_Location == "Ostrava" || Working_Location == "Brno" || Working_Location == "Prague")
                Working_Location_Accepted = true;
                return this.Working_Location_Accepted;
            }

        
    }
}










