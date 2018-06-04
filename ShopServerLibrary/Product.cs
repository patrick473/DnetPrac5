﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ShopServerLibrary
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public int Amount { get; set; }

        public List<Product> Products { get; set; }


        //Hardcoded product list:
        //Will later be replaced by database.
        public List<Product> GenerateProducts() {
            Products = new List<Product>();
            this.Products.Add(
                new Product {
                    Name = "Carrot",
                    Amount = 20,
                    Price = 2.50,
                    Id = 1
                });
            this.Products.Add(
                new Product {
                    Name = "Apple",
                    Amount = 30,
                    Price = 1,
                    Id = 2
                });
            this.Products.Add(
                new Product {
                    Name = "Lettuce",
                    Amount = 50,
                    Price = 3,
                    Id = 3
                });
            return Products;
        }

        public override string ToString() {
            return "Product: " + Id + " " + Name + " " + Price + " " + Amount;
        }
    }
}
