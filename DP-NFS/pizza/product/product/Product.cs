using System;


namespace DP_NFS.pizza.product.product {
    class Product : IProduct {
        public String Name { get; set; }

        public Product(String name) {
            this.Name = name;
        }
    }
}
