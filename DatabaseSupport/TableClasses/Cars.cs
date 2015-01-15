using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseSupport.TableClasses
{
    public class Cars : TableClass
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

        public override string ToString()
        {
            return String.Format("Marka: {0,5}, Model: {1,5}, Numer rejestracyjny: {2,5}",Brand,Model,RegistrationNumber);
        }
    }
}
