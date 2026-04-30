using System;
using System.Collections.Generic;
using System.Text;
using PizzaStoreLib;

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

public class Toppings
//properties
{
    public string Navn { get; set; }
    public double Pris { get; set; }
    
    //Liste (database)
    public static List<Topping> toppings = new List<Topping>();
     
    //Create
    public static void OpretTopping(string navn, double pris)

    {
        Topping x = new Topping();
        x.Navn = navn;
        x.Pris = pris;
        toppings.Add(x);
    }
    //Read 

    public Topping ReadOrdre(int toppingID, string navn, double pris)
    {
        Topping topping = new Topping(toppingID,navn, pris);
        return topping;

    }
    
    
    public Topping UpdateTopping(int toppingID, string navn, string status, double pris)
    {
        Topping topping = new Topping(toppingID, navn, pris);
        return topping;
    }
    
    
    public void DeleteTopping()
    { 
        int ToppingID = 0;
        string status = "";
        double pris = 0.0;
    }
}
