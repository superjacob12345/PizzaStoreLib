using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreLib
{
    public class Pizza
    {
        private int _pizzaID;
        private string _navn;
        private string _størrelse;
        private double _pris;
        private List<Topping> _toppings;

        public Pizza(int pizzaID, string navn, string størrelse, double pris)
        {
            _pizzaID = pizzaID;
            _navn = navn;
            _størrelse = størrelse;
            _pris = pris;
            _toppings = new List<Topping>();
        }

        public int PizzaID
        {
            get { return _pizzaID; }
            set { _pizzaID = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Stoerrelse
        {
            get { return _størrelse; }
            set { _størrelse = value; }
        }

        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        public List<Topping> Toppings
        {
            get { return _toppings; }
        }

        // metode til at tilføje topping
        public void AddTopping(Topping topping)
        {
            _toppings.Add(topping);
        }

        public double GetTotalPizzaPrice()
        {
            double total = _pris;

            foreach (var t in _toppings)
            {
                total += t.Pris;
            }

            return total;
        }

        public override string ToString()
        {
            string toppingsText = "";

            foreach (var t in _toppings)
            {
                toppingsText += t.Navn + " ";
            }

            return $"Pizza: {Navn}, Toppings: {toppingsText}, Pris: {GetTotalPizzaPrice()} kr";
        }
    }
}
