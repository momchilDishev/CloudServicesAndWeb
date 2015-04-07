using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftUniWebApiSelfHost
{
    public class Product
    {
        public Product(string name)
        {
            this.Id = 0;
            this.Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        
    }
}