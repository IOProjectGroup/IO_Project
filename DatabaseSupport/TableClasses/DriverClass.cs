using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    public class DriverClass : TableClasses
    {
        String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        String surname;

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        String pesel;

        public String Pesel
        {
            get { return pesel; }
            set { pesel = value; }
        }

        public override string AddToDatabase()
        {
            DatabaseWriter writer = new DatabaseWriter();
            return writer.AddDriverToDatabase(this.name,this.surname,this.pesel);
        }

        public override string ToString()
        {
            return string.Format("Imie: {0}, Nazwisko: {1}, Pesel: {2}", Name, Surname, Pesel);
        }
    }
}
