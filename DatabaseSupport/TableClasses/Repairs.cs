using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    public class Repairs
    {
        private int id_repair;

        public virtual int ID_repair
        {
            get { return id_repair; }
            set { id_repair = value; }
        }
        private double cost;

        public virtual double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private DateTime dateOfRepair;

        public virtual DateTime DateOfRepair
        {
            get { return dateOfRepair; }
            set { dateOfRepair = value; }
        }
        private String specification;

        public virtual String Specification
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
    }
}
