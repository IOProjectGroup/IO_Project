using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernateTutorialPart1.Model
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
            set { firstName = value; }
        }
        private string lastName;

        public virtual string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string pesel;

        public virtual string Pesel
        {
            get { return pesel; }
            set { pesel = value; }
        }
    }
}
