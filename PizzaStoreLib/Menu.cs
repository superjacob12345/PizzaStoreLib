using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreLib
{
    public class Menu
    {
        // instans felt
        private int _menuID;
        private string _navn;
        private string _beskrivelse;
        private double _pris;
        public Menu(int menuID, string navn, string beskrivelse, double pris)
        {
            _menuID = menuID;
            _navn = navn;
            _beskrivelse = beskrivelse;
            _pris = pris;
        }
        // properties
         public Menu()
        {
            MenuID=0;
            Navn="";
            Beskrivelse="";
            Pris=0.0;
        }
        public int MenuID
        {
            get { return _menuID; }
            set { _menuID = value; }
        }
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }
        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }
        public override string ToString()
        {
            return $"Menu ID: {MenuID}, Navn: {Navn}, Beskrivelse: {Beskrivelse}, Pris: {Pris}";
        }
    }
}
