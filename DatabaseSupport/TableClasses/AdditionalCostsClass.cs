using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    class AdditionalCostsClass
    {
        double additionalCost;

        public double AdditionalCost
        {
            get { return additionalCost; }
            set { additionalCost = value; }
        }
        String specification;

        public String Specification
        {
            get { return specification; }
            set { specification = value; }
        }
    }
}
