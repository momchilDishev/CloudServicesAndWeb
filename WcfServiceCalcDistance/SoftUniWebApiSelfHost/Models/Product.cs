using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftUniWebApiSelfHost
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string name)
        {
            // TODO: Complete member initialization
            this.Name = name;
        }
    }
}