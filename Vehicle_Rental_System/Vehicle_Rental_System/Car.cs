using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    public class Car : Vehicle
    {
        public int SafetyRating { get; set; }

        public override decimal GetDailyRentalCost(int rentalDays)
        {
            return rentalDays <= 7 ? 20 : 15;
        }
        public override decimal GetDeilyInsuranceCost(Customer customer)
        {
            decimal cost = 0.0001m * Value;
            if(SafetyRating >= 4)
            {
                cost *= 0.9m;
            }
            return cost;
        }
    }
}
