using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseSupport;

namespace DatabaseSupport.TableClasses
{
    public class Drivers
    {
        private int id_driver;
        public virtual int ID_driver
        {
            get { return id_driver; }
            set { id_driver = value; }
        }
        private string firstName;
        public virtual string FirstName
        {
            get { return firstName; }
            set { firstName = value.FullyCapitalize(); }
        }
        private string lastName;
        public virtual string LastName
        {
            get { return lastName; }
            set { lastName = value.FullyCapitalize(); }
        }
        private string pesel;
        public virtual string Pesel
        {
            get { return pesel; }
            set { pesel = value; }
        }
        private IList<AdditionalCosts> additionalCosts = new List<AdditionalCosts>();

        public virtual IList<AdditionalCosts> AdditionalCosts
        {
            get { return additionalCosts; }
            set { additionalCosts = value; }
        }
        private IList<Routes> routes = new List<Routes>();

        public virtual IList<Routes> Routes
        {
            get { return routes; }
            set { routes = value; }
        }


        public override string ToString()
        {
            return String.Format("Imie: {0,5}, Nazwisko: {1,5}, Pesel: {2,5}",FirstName,LastName,Pesel);
        }
        public override bool Equals(object obj)
        {
            bool isEqual = false;
            try
            {
                Drivers driver = (Drivers)obj;
                isEqual = this.pesel.Equals(driver.pesel);
            }
            catch (Exception) { }
            return isEqual;
        }

        public override int GetHashCode()
        {
            return this.pesel.GetHashCode();
        }
    }
}
