using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    class AdditionalCosts
    {
        private int id_cost;

        public virtual int ID_cost
        {
            get { return id_cost; }
            set { id_cost = value; }
        }

        private int id_driver;

        public int ID_driver
        {
            get { return id_driver; }
            set { id_driver = value; }
        }
        private int id_car;

        public int ID_car
        {
            get { return id_car; }
            set { id_car = value; }
        }
        private double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private string specification;

        public string Specification
        {
            get { return specification; }
            set { specification = value; }
        }
    }
}
