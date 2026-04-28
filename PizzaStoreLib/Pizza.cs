using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreLib
{
    public class Pizza
    {
        // instans felt
        private int _pizzaID;
        private string _navn;
        private string _størrelse;
        private double _pris;
        public Pizza(int pizzaID, string navn, string størrelse, double pris)
        {
            _pizzaID = pizzaID;
            _navn = navn;
            _størrelse = størrelse;
            _pris = pris;
        }
        // properties
         public Pizza()
        {
            PizzaID=0;
            Navn="";
            Størrelse="";
            Pris=0.0;
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
        public string Størrelse
        {
            get { return _størrelse; }
            set { _størrelse = value; }
        }
        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }
        public override string ToString()
        {
            return $"Pizza ID: {PizzaID}, Navn: {Navn}, Beskrivelse: {Størrelse}, Pris: {Pris}";
        }
    }
}
