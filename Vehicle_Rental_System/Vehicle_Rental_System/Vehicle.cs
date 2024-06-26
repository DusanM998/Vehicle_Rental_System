﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Value { get; set; }
        public string Type { get; set; }

        public abstract decimal GetDailyRentalCost(int rentalDays);
        public abstract decimal GetDailyInsuranceCost(Customer customer);
    }
}
