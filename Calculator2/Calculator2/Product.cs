﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    public class Product
    {
        private int id;
        private int qty;

        private long price;


        private decimal vat;

        private string manufacturer;
        private string supplier;
        private string name;
        private string productGroup;

        private Boolean pricePerKg;
        private Boolean pricePerHg;

        public Product()
        {
        }

        public Product(int idy, long pricy, int qty1, string manufac, string supply, string productG, decimal vaty, Boolean ppkg, Boolean ppHg, string namey)
        {
            Id = idy;
            Price = pricy;
            Qty = qty1;
            Manufacturer = manufac;
            Supplier = supply;
            ProductGroup = productG;
            Vat = vaty;
            PricePerKG = ppkg;
            PricePerHG = ppHg;
            Name = namey;
        }


        public int Id { get; set; }
        public int Qty { get; set; }
        public long Price { get; set; }
        public string Manufacturer { get; set; }
        public string Supplier { get; set; }
        public string ProductGroup { get; set; }
        public decimal Vat { get; set; }
        public Boolean PricePerKG { get; set; }
        public Boolean PricePerHG { get; set; }
        public string Name { get; set; }

        
    }
}
