using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    class RoutesToTowns
    {
        private int id_route;

        public virtual int ID_route
        {
            get { return id_route; }
            set { id_route = value; }
        }
        private int id_town;

        public virtual int ID_town
        {
            get { return id_town; }
            set { id_town = value; }
        }
    }
}
