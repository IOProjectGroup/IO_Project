using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    class Insurance
    {
        private int id_insurance;

        public int ID_insurance
        {
            get { return id_insurance; }
            set { id_insurance = value; }
        }
        private int id_car;

        public int ID_car
        {
            get { return id_car; }
            set { id_car = value; }
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
    }
}
