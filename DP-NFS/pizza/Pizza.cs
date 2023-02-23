using DP_NFS.pizza.product.product;
using System;
using System.Collections.Generic;

namespace DP_NFS.pizza {
    internal abstract class Pizza : IPizza {
        private String _name;
        public String Name {
            get {
                String returnedValue = this._name;
                foreach (IProduct product in this.products) {
                    returnedValue += " " + product.Name;
                }
                return returnedValue;
            }
            set {
                this._name = value;
            }
        }
        public List<IProduct> products;

        public Pizza(string name) {
            this.products = new();
            Name = name;
        }

        public void AddProduct(IProduct product) {
            this.products.Add(product);
        }
    }
}
