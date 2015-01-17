using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    public class AdditionalCosts
    {
        private int id_cost;

        public virtual int ID_cost
        {
            get { return id_cost; }
            set { id_cost = value; }
        }

        private double cost;

        public virtual double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private string specification;

        public virtual string Specification
        {
            get { return specification; }
            set { specification = value; }
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
    }
}
