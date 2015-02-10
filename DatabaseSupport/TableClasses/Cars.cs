using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseSupport.TableClasses
{
    public class Cars
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
            set { brand = value.FullyCapitalize(); }
        }
        private string model;

        public virtual string Model
        {
            get { return model; }
            set { model = value.FullyCapitalize(); }
        }
        private decimal cost;

        public virtual decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private DateTime dateOfProduction;

        public virtual DateTime DateOfProduction
        {
            get { return dateOfProduction; }
            set { dateOfProduction = value; }
        }
        private DateTime dateOfPurchase;

        public virtual DateTime DateOfPurchase
        {
            get { return dateOfPurchase; }
            set { dateOfPurchase = value; }
        }
        private string registrationNumber;

        public virtual string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value.ToUpper(); }
        }

        private IList<Insurance> insurance = new List<Insurance>();

        public virtual IList<Insurance> Insurance
        {
            get { return insurance; }
            set { insurance = value; }
        }

        private IList<Refuels> refuels = new List<Refuels>();

        public virtual IList<Refuels> Refuels
        {
            get { return refuels; }
            set { refuels = value; }
        }

        private IList<Repairs> repairs = new List<Repairs>();

        public virtual IList<Repairs> Repairs
        {
            get { return repairs; }
            set { repairs = value; }
        }

        private IList<AdditionalCosts> additionalCosts = new List<AdditionalCosts>();

        public virtual IList<AdditionalCosts> AdditionalCosts
        {
            get { return additionalCosts; }
            set { additionalCosts = value; }
        }
        private IList<Routes> routes = new List<Routes>();

        public virtual IList<Routes> Routes
        {
            get { return routes; }
            set { routes = value; }
        }

        public override string ToString()
        {
            return String.Format("Marka: {0,5}, Model: {1,5}, Numer rejestracyjny: {2,5}",Brand,Model,RegistrationNumber);
        }

        public override bool Equals(object obj)
        {
            bool isEqual = false;
            try
            {
                Cars car = (Cars)obj;
                isEqual = this.registrationNumber.Equals(car.registrationNumber);
            }
            catch (Exception) { }
            return isEqual;  
        }

        public override int GetHashCode()
        {
            return this.registrationNumber.GetHashCode();
        }
    }
}
