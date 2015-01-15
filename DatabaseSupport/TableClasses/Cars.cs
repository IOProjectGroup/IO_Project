using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    class Cars
    {
        private int id_car;

        public virtual int ID_car
        {
            get { return id_car; }
            set { id_car = value; }
        }
        private string brand;

        public virtual string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        private string model;

        public virtual string Model
        {
            get { return model; }
            set { model = value; }
        }
        private double cost;

        public virtual double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private string registrationNumber;

        public virtual string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
        private DateTime dateOfProduction;

        public DateTime DateOfProduction
        {
            get { return dateOfProduction; }
            set { dateOfProduction = value; }
        }
        private DateTime dateOfPurchase;

        public DateTime DateOfPurchase
        {
            get { return dateOfPurchase; }
            set { dateOfPurchase = value; }
        }
    }
}
