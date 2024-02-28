using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaTicketSystem
{
    public class User
    {  
        public object UserRegistration 
        {
            get { return userregistration }; 
            
            set{ if(SuperAdmin.Run())
                {
                   SuperAdmin.UserStartRegistration = "Qeydiyyat apara bilersiniz"

                   Console.WriteLine(SuperAdmin.UserStartRegistration);
                }
            } 

        public object UserOrderTicket(string country,string city,DateTime hour)
        {
            this.Country=country;
            this.city=city; 
            this.hour=hour;
             return  this;
        }
        public string country
        public string city
        public DateTime hour


         public object TicketBack(int balanse)

        {
            this.balanse = balanse;
        }
        public int balanse
    }
}
