using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    class InsuranceClass
    {
        double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        DateTime dateOfPurchase;

        public DateTime DateOfPurchase
        {
            get { return dateOfPurchase; }
            set { dateOfPurchase = value; }
        }
        DateTime dateOfExpiry;

        public DateTime DateOfExpiry
        {
            get { return dateOfExpiry; }
            set { dateOfExpiry = value; }
        }
    }
}
