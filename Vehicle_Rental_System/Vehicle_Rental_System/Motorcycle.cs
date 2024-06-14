using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    public class Motorcycle : Vehicle
    {
        public override decimal GetDailyRentalCost(int rentalDays)
        {
            return rentalDays <= 7 ? 15 : 10;
        }

        public override decimal GetDailyInsuranceCost(Customer customer)
        {
            decimal cost = 0.0002m * Value;
            if(customer.Age < 25)
            {
                cost *= 1.2m;
            }
            return cost;
        }

    }
}
