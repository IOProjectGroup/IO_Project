﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport.TableClasses
{
    class Towns
    {
        private int id_town;

        public virtual int ID_town
        {
            get { return id_town; }
            set { id_town = value; }
        }
        private string townName;

        public virtual string TownName
        {
            get { return townName; }
            set { townName = value; }
        }
    }
}
