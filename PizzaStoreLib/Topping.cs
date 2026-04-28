using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreLib
{
    public class Topping
    {
        // instans felt
        private int _toppingID;
        private string _navn;
        private double _pris;
        public Topping(int toppingID, string navn, double pris)
        {
            _toppingID = toppingID;
            _navn = navn;
            _pris = pris;
        }
        // properties
         public Topping()
        {
            ToppingID=0;
            Navn="";
            Pris=0.0;
        }
        public int ToppingID
        {
            get { return _toppingID; }
            set { _toppingID = value; }
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
            return $"Topping ID: {ToppingID}, Navn: {Navn}, Pris: {Pris}";
        }
    }
}
