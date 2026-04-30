using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreLib
{
    public class Ordre
    {
        private int _ordreID;
        private Pizza _pizza;
        private Kunde _kunde;

        public Ordre(int ordreID, Pizza pizza, Kunde kunde)
        {
            _ordreID = ordreID;
            _pizza = pizza;
            _kunde = kunde;
        }

        public int OrdreID
        {
            get { return _ordreID; }
            set { _ordreID = value; }
        }

        public Pizza Pizza
        {
            get { return _pizza; }
            set { _pizza = value; }
        }

        public Kunde Kunde
        {
            get { return _kunde; }
            set { _kunde = value; }
        }

        public double CalculateTotalPrice()
        {
            double pris = _pizza.Pris;
            double moms = pris * 0.25;

            return pris + moms + 40; // levering
        }

        public override string ToString()
        {
            return $"{Kunde.Navn} har bestilt {Pizza.Navn} - Total: {CalculateTotalPrice()} kr";
        }
    }
}
