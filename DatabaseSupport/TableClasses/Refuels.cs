using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    public class Refuels
    {
        private int id_refuel;

        public virtual int ID_refuel
        {
            get { return id_refuel; }
            set { id_refuel = value; }
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
        private Cars cars;

        public virtual Cars Cars
        {
            get { return cars; }
            set { cars = value; }
        }
    }
}
