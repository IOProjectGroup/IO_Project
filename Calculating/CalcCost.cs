using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSupport;
using DatabaseSupport.TableClasses;

namespace Calculating
{
    public class CalcCost
    {
        private Cars car;

        public Cars Car
        {
            get { return car; }
            set { car = value; }
        }
        private double totalCost;

        public double TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
        private int carAge;

        public int CarAge
        {
            get { return carAge; }
            set { carAge = value; }
        }

        private double mileage;

        public double Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        public CalcCost(Cars car)
        {
            this.car = car;
            this.totalCost = CalcTotalCost();
            this.carAge = DateTime.Now.Year - Convert.ToDateTime(car.DateOfProduction).Year;
            this.mileage = car.Routes.Max<Routes>(route => route.MileageCounterEnd);
        }

        public double CalcInsurance()
        {
            double totalCost = 0;
            if(Car.Insurance.Count > 0)
            {
                foreach (Insurance item in Car.Insurance)
                {
                    totalCost += item.Cost;
                }
            }

            return totalCost;
        }

        public double CalcRepairs()
        {
            double totalCost = 0;
            if (Car.Repairs.Count > 0)
            {
                foreach(Repairs item in Car.Repairs)
                {
                    totalCost += item.Cost;
                }
            }

           return totalCost;
        }

        public double CalcRefuels()
        {
            double totalCost = 0;
            if (Car.Refuels.Count > 0)
            {
                foreach (Refuels item in Car.Refuels)
                {
                    totalCost += item.Cost;
                }
            }

            return totalCost;
        }

        public double CalcAdditionalCosts()
        {
            double totalCost = 0;
            if (Car.AdditionalCosts.Count > 0)
            {
                foreach (AdditionalCosts item in Car.AdditionalCosts)
                {
                    totalCost += item.Cost;
                }
            }

            return totalCost;
        }

        public double CalcTotalCostWithoutCar(List<double> A_TotalCostList)
        {
            double totalCost = 0;
            if (A_TotalCostList.Count > 0)
            {
                foreach (double item in A_TotalCostList)
                {
                    totalCost += item;
                }
            }

            return totalCost;
        }

        public double CalcTotalCostWithCar(Cars car, List<double> A_TotalCostList)
        {
            double totalCost = 0;
            if (A_TotalCostList.Count > 0)
            {
                foreach (double item in A_TotalCostList)
                {
                    totalCost += item;
                }
            }

            totalCost += (double)car.Cost;

            return totalCost;
        }

        public double CalcTotalCost()
        {
            double totalCost = 0;

            totalCost += CalcInsurance();
            totalCost += CalcRefuels();
            totalCost += CalcRepairs();
            totalCost += CalcAdditionalCosts();

            totalCost += (double)Car.Cost;

            return totalCost;
        }
    }
}
