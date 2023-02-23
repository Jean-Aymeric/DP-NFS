using DP_NFS.pizza.product.product;
using System;


namespace DP_NFS.pizza {
    interface IPizza {
        public String Name { get; set; }
        public void AddProduct(IProduct product);
    }
}
