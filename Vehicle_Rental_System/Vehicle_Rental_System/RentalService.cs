using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    public class RentalService
    {
        public decimal CalculateRentalCost(Vehicle vehicle, int rentalDays, int actualDays)
        {
            if(actualDays < rentalDays)
            {
                return vehicle.GetDailyRentalCost(actualDays) * actualDays +
                    (vehicle.GetDailyRentalCost(rentalDays) * (rentalDays - actualDays)) / 2;
            }
            else
            {
                return vehicle.GetDailyRentalCost(actualDays) * actualDays;
            }
        }

        public decimal CalculateInsuranceCost(Vehicle vehicle, int rentalDays, int actualDays, Customer customer)
        {
            if(actualDays < rentalDays)
            {
                return vehicle.GetDailyInsuranceCost(customer) * actualDays;
            }
            else
            {
                return vehicle.GetDailyInsuranceCost(customer) * actualDays;
            }
        }

        public string GenerateInvoice(Vehicle vehicle, int reservedDays, int actualDays, Customer customer)
        {
            decimal rentalCost = CalculateRentalCost(vehicle, reservedDays, actualDays);
            decimal insuranceCost = CalculateInsuranceCost(vehicle, reservedDays, actualDays, customer);

            return $"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX: \n" +
                $"Invoice: \n" +
                $"Customer Name: {customer.Name}\n" +
                $"Rented Vehicle: {vehicle.Brand} {vehicle.Model}\n" +
                $"Reservation Start Date: {DateTime.Now.AddDays(-reservedDays).ToString("yyyy-MM-dd")}\n" +
                $"Reservation End Date: {DateTime.Now.ToString("yyyy-MM-dd")}\n" +
                $"Reservation Rental Days: {reservedDays}\n" +
                $"Actual Return Date: {DateTime.Now.ToString("yyyy-MM-dd")}\n" +
                $"Actual Rental Days: {actualDays}\n" +
                $"Rental Cost per day: {vehicle.GetDailyRentalCost(actualDays):C}\n" +
                $"Insurance per day: {vehicle.GetDailyInsuranceCost(customer):C}\n" +
                $"Total Rent: {rentalCost}\n" +
                $"Total Insurance: {insuranceCost}\n" +
                $"Total: {(rentalCost + insuranceCost):C}\n" +
                $"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX \n";
        }
    }
}
