using DP_NFS.pizza.product.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.pizza.product.factoryProduct{
    abstract class FactoryProduct {
        private static List<FactoryProduct> factoriesProduct = new();
        
        public static IProduct Make(String productName) {
            foreach (FactoryProduct factoryProduct in FactoryProduct.factoriesProduct) {
                if (factoryProduct.DoesItMake(productName)) {
                    return factoryProduct.Make();
                }
            }
            return FactoryProduct.Make("Produit manquant");
        }

        public string ProductName { get; }

        public FactoryProduct(String productName) {
            this.ProductName = productName;
            FactoryProduct.factoriesProduct.Add(this);
        }

        public abstract IProduct Make();

        public bool DoesItMake(String productName) {
            return this.ProductName == productName;
        }

    }
}
