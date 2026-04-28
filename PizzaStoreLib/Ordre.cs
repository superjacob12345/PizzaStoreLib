using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreLib
{
    public class Ordre
    {
        // instans felt
        private int _ordreID;
        private DateTime _dato;
        private string _status;
        private double _totalPris;
        public Ordre(int ordreID, DateTime dato, string status, double totalPris)
        {
            _ordreID = ordreID;
            _dato = dato;
            _status = status;
            _totalPris = totalPris;
        }
        // properties
       public Ordre()
        {
            OrdreID=0;
            dato=DateTime.Now;
            status="";
            totalPris=0.0;
        }
        public int OrdreID
        {
            get { return _ordreID; }
            set { _ordreID = value; }
        }
        public DateTime dato
        {
            get { return _dato; }
            set { _dato = value; }
        }
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }
        public double totalPris
        {
            get { return _totalPris; }
            set { _totalPris = value; }
        }
        public override string ToString()
        {
            return $"Ordre ID: {OrdreID}, Dato: {dato}, Status: {status}, Total Pris: {totalPris}";
        }
    }
}
