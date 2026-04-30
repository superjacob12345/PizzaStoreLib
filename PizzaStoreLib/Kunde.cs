namespace PizzaStoreLib
{
    public class Kunde 
        {
            private int _kundeID;
            private string _navn;
            private string _telefon;
            private string _adresse;

            public Kunde(int kundeID, string navn, string telefon, string adresse)
            {
                _kundeID = kundeID;
                _navn = navn;
                _telefon = telefon;
                _adresse = adresse;
            }

            public int KundeID
            {
                get { return _kundeID; }
                set { _kundeID = value; }
            }

            public string Navn
            {
                get { return _navn; }
                set { _navn = value; }
            }

            public string Telefon
            {
                get { return _telefon; }
                set { _telefon = value; }
            }

            public string Adresse
            {
                get { return _adresse; }
                set { _adresse = value; }
            }

            public override string ToString()
            {
                return $"Kunde: {Navn}, Telefon: {Telefon}";
            }
        }
}
