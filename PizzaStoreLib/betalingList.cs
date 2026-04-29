using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStoreLib;

public class BetalingList : Betaling
{
    private List<Betaling> _betalinger;
    public BetalingList()
    {
        _betalinger = new List<Betaling>();
    }
    public void betalingId(int betalingID, int ordreID, double beløb, string betalingsmetode, string status, string metode)
    {
        Betaling betaling = new Betaling(betalingID, ordreID, beløb, betalingsmetode, status, metode);
        _betalinger.Add(betaling);
    }
    public Betaling GetBetalingById(int id)
    {
        return _betalinger.Find(b => b.BetalingID == id);
    }
    public Betaling GetBetalingByOrdreId(int ordreID)
    {
        return _betalinger.Find(b => b.OrdreID == ordreID);
    }
    public Betaling GetBetalingByBeløb(double beløb)
    {
        return _betalinger.Find(b => b.Beløb == beløb);


    }
    public Betaling GetBetalingByBetalingsmetode(string betalingsmetode)
    {
        return _betalinger.Find(b => b.Betalingsmetode == betalingsmetode);
    }
    public Betaling GetBetalingByStatus(string status)
    {
        return _betalinger.Find(b => b.Status == status);
    }
    public Betaling GetBetalingByMetode(string metode)
    {
        if (metode == "Kort")
        {
            return _betalinger.Find(b => b.Metode == metode);
        }
        else if (metode == "MobilePay")
        {
            return _betalinger.Find(b => b.Metode == metode);
        }
        else if (metode == "Kontant")
        {
            return _betalinger.Find(b => b.Metode == metode);
        }
        else
        {
            throw new ArgumentException("Gyldige metoder er: Kort, MobilePay, Kontant.");
        }
    }
    

}


