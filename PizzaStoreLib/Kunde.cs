namespace PizzaStoreLib
{
    public class Kunde
    {
        // instans felt
        private string _navn;
        private int _kundeID;
        private string _adresse;
        private string _telefonnummer;
        public Kunde(string navn, int kundeID, string adresse, string telefonnummer)
        {
            _navn = navn;
            _kundeID = kundeID;
            _adresse = adresse;
            _telefonnummer = telefonnummer;
        }
        // properties


        public Kunde()
        {
            Navn="";
            KundeID=0;
            Adresse="";
            Telefonnummer="";

        }
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public int KundeID
        {
            get { return _kundeID; }
            set { _kundeID = value; }
        }
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        public string Telefonnummer
        {
            get { return _telefonnummer; }
            set {_telefonnummer = value; }
        }
        public override string ToString()
        {
            return $"Kunde: {Navn}, ID: {KundeID}, Adresse: {Adresse}, Telefonnummer: {Telefonnummer}";
        }


    }

}
