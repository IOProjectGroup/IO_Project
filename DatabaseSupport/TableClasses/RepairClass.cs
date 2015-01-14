using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    class RepairClass
    {
        double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        DateTime dateOfRepair;

        public DateTime DateOfRepair
        {
            get { return dateOfRepair; }
            set { dateOfRepair = value; }
        }
        String specification;

        public String Specification
        {
            get { return specification; }
            set { specification = value; }
        }
    }
}
