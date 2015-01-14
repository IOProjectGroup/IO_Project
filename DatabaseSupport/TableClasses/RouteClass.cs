using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    class RouteClass
    {
        double mileageCounterStart;

        public double MileageCounterStart
        {
            get { return mileageCounterStart; }
            set { mileageCounterStart = value; }
        }
        double mileageCounterEnd;

        public double MileageCounterEnd
        {
            get { return mileageCounterEnd; }
            set { mileageCounterEnd = value; }
        } 
        String startTown;
        String endTown;
    }
}
