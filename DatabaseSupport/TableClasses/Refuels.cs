using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    class Refuels
    {
        private int id_refuel;

        public virtual int ID_refuel
        {
            get { return id_refuel; }
            set { id_refuel = value; }
        }
        private int id_car;

        public virtual int ID_car
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
        private double fuel;

        public virtual double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
    }
}
