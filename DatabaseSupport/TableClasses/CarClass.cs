using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    class CarClass
    {
        String brand;

        public String Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        String model;

        public String Model
        {
            get { return model; }
            set { model = value; }
        }
        double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        DateTime dateOfProduction;

        public DateTime DateOfProduction
        {
            get { return dateOfProduction; }
            set { dateOfProduction = value; }
        }
        DateTime dateOfPurchase;

        public DateTime DateOfPurchase
        {
            get { return dateOfPurchase; }
            set { dateOfPurchase = value; }
        }
        String registrationNumber;

        public String RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        List<RepairClass> carRepair;
        List<RefuelClass> carRefuel;
        List<AdditionalCostsClass> carAdditionalCost;
        List<InsuranceClass> carInsurance;
        List<RouteClass> carRoutes;    
    }
}
