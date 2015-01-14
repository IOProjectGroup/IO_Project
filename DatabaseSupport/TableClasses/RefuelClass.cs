using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    class RefuelClass
    {
        double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        double fuel;

        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
    }
}
