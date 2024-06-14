using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal class CargoVan : Vehicle
    {
        public override decimal GetDailyRentalCost(int rentalDays)
        {
            return rentalDays <= 7 ? 50 : 40;
        }

        public override decimal GetDailyInsuranceCost(Customer customer)
        {
            decimal cost = 0.0003m * Value;
            if(customer.YearsOfExperience > 5) 
            {
                cost *= 0.85m;
            }
            return cost;
        }
    }
}
