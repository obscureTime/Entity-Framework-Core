﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstates.Models
{
    public class PropertyTypes
    {
        public PropertyTypes()
        {
            Properties = new HashSet<Property>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
