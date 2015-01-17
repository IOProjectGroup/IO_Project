using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    public class Routes
    {
        private int id_route;

        public virtual int ID_route
        {
            get { return id_route; }
            set { id_route = value; }
        }
        private double mileageCounterStart;

        public virtual double MileageCounterStart
        {
            get { return mileageCounterStart; }
            set { mileageCounterStart = value; }
        }
        private double mileageCounterEnd;

        public virtual double MileageCounterEnd
        {
            get { return mileageCounterEnd; }
            set { mileageCounterEnd = value; }
        }

        private Cars cars;

        public virtual Cars Cars
        {
            get { return cars; }
            set { cars = value; }
        }
        private Drivers drivers;

        public virtual Drivers Drivers
        {
            get { return drivers; }
            set { drivers = value; }
        }

        private IList<Towns> towns = new List<Towns>();

        public virtual IList<Towns> Towns
        {
            get { return towns; }
            set { towns = value; }
        }
    }
}
