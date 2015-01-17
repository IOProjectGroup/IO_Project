using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    public class Insurance
    {
        private int id_insurance;

        public virtual int ID_insurance
        {
            get { return id_insurance; }
            set { id_insurance = value; }
        }
        private double cost;

        public virtual double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private DateTime dateOfPurchase;

        public virtual DateTime DateOfPurchase
        {
            get { return dateOfPurchase; }
            set { dateOfPurchase = value; }
        }
        private DateTime dateOfExpiry;

        public virtual DateTime DateOfExpiry
        {
            get { return dateOfExpiry; }
            set { dateOfExpiry = value; }
        }
        private Cars cars;

        public virtual Cars Cars
        {
            get { return cars; }
            set { cars = value; }
        }
    }
}
