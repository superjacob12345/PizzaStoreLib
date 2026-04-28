using System;
using System.Collections.Generic;
using System.Data;
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
        private List<Pizza> _menuPizza;

        public Menu(int menuID, string navn, string beskrivelse, double pris)

        {
            _menuID = menuID;
            _navn = navn;
            _beskrivelse = beskrivelse;
            _pris = pris;
            _menuPizza = new List<Pizza>();
        }
       
         


        // properties
         public Menu()
        {
            MenuID=0;
            Navn="";
            Beskrivelse="";
            Pris=0.0;
            _menuPizza = new List<Pizza>();
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
            set { if (value < 0|| value>10000) 
                  throw new ArgumentOutOfRangeException("Pris skal være mellem 0 og 10000.");

                _pris = value; }
        }
        // CRUD metoder
         public Menu CreatePizza(int menuID, string navn, string beskrivelse, double pris)
        {
            Menu menu = new Menu(menuID, navn, beskrivelse, pris);
            return menu;
        }

        public Menu UpdatePizza(int menuID, string navn, string beskrivelse, double pris)
        {
            Menu menu = new Menu(menuID, navn, beskrivelse, pris);
            return menu;
        }
        public void DeletePizza()
        {
            MenuID = 0;
            Navn = "";
            Beskrivelse = "";
            Pris = 0.0;
        }
        public Menu ReadMenu(int menuID)
        {
            // Simulerer læsning af menu fra en datakilde baseret på menuID
            // I en rigtig applikation ville du hente data fra en database eller anden datakilde
            if (menuID == MenuID)
            {
                return this; // Returnerer den aktuelle menu, hvis ID matcher
            }
            else
            {
                throw new Exception("Menu ikke fundet.");
            }
        }



        public override string ToString()
        {
            return $"Menu ID: {MenuID}, Navn: {Navn}, Beskrivelse: {Beskrivelse}, Pris: {Pris}";
        }
    }
}
