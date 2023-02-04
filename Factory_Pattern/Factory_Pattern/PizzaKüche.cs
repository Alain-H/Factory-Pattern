using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class PizzaKüche                                   //KoordinationsKlasse!
    {
        public IPizza erzeugePizza(string Pizzasorte)           //eine Methode die ein Objekt des IPizza Interface zurückgibt.
        {
            switch (Pizzasorte)
            {
                case "Margherita":
                    return new Margherita();
                    break;
                case "Rustica":
                    return new Rustica();
                    break;
                default: return null;
            }           

        }
    }
}
