using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.pizza {
    abstract class FactoryPizza {
        public static List<FactoryPizza> factoriesPizza = new();

        public static void InitializeFactories() {
            FactoryPizza.factoriesPizza.Add(new FactoryCalzone());
            FactoryPizza.factoriesPizza.Add(new FactoryFourCheeses());
        }

        private static void AddFactory(FactoryPizza factory) {
            FactoryPizza.factoriesPizza.Add(factory);
        }

        public static List<String> GetMakings() {
            List<String> makings = new();
            foreach (FactoryPizza factoryPizza in FactoryPizza.factoriesPizza) {
                makings.Add(factoryPizza.PizzaName);
            }
            return makings;
        }

        public string PizzaName { get; }

        public FactoryPizza(String pizzaName) {
            this.PizzaName = pizzaName;
            FactoryPizza.AddFactory(this);
        }

        public bool DoesItMake(String pizzaName) {
            return this.PizzaName == pizzaName;
        }

        public static IDrink Make(String pizzaName) {
            foreach(FactoryPizza factoryPizza in FactoryPizza.factoriesPizza) {
                if (factoryPizza.DoesItMake(pizzaName)) {
                    return factoryPizza.Make();
                }
            }
            return null;
        }

        public abstract IDrink Make();
    }
}
