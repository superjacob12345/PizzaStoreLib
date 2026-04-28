using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreLib
{
    public class Betaling
    {
        // instans felt
        private int _betalingID;
        private int _ordreID;
        private double _beløb;
        private string _betalingsmetode;
        private string _status;
        private string _metode;
        public Betaling(int betalingID, int ordreID, double beløb, string betalingsmetode, string status, string metode)
        {
            _betalingID = betalingID;
            _ordreID = ordreID;
            _beløb = beløb;
            _betalingsmetode = betalingsmetode;
            _status = status;
            _metode = metode;
        }
        // properties
         public Betaling()
        {
            BetalingID=0;
            OrdreID=0;
            Beløb=0.0;
            Betalingsmetode="";
                _status = "";
                _metode = "";
        }   
        public int BetalingID
        {
            get { return _betalingID; }
            set { _betalingID = value; }
        }
        public int OrdreID
        {
            get { return _ordreID; }
            set { _ordreID = value; }
        }
        public double Beløb
        {
            get { return _beløb; }
            set { _beløb = value; }
        }
        public string Betalingsmetode
        {
            get { return _betalingsmetode; }
            set { _betalingsmetode = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string Metode
        {
            get { return _metode; }
            set { _metode = value; }
        }
        public override string ToString()
        {
            return $"Betaling ID: {BetalingID}, Ordre ID: {OrdreID}, Beløb: {Beløb}, Betalingsmetode: {Betalingsmetode}, Status: {Status}, Metode: {Metode}";
        }
        
    }
}
