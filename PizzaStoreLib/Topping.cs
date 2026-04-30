using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreLib
{
    public class Topping
    {
        private string _navn;
        private double _pris;

        public Topping(string navn, double pris)
        {
            _navn = navn;
            _pris = pris;
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        public override string ToString()
        {
            return $"{Navn} ({Pris} kr)";
        }
    }
}
