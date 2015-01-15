using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    class Routes
    {
        private int id_route;

        public virtual int ID_route
        {
            get { return id_route; }
            set { id_route = value; }
        }
        private int id_driver;

        public virtual int ID_driver
        {
            get { return id_driver; }
            set { id_driver = value; }
        }
        private int id_car;

        public virtual int ID_car
        {
            get { return id_car; }
            set { id_car = value; }
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
    }
}
