namespace Knihovna
{
    public class Polozka
    {
        private string nazev;
        private string autor;
        private int rok;
        private string zanr;
        private int isbn;
        private int kusy;
   

        public Polozka()
        {

        }
        public Polozka (string nazev, string autor, int rok, string zanr, int isbn, int kusy)
        {
            Nazev = nazev;
            Autor = autor;
            Rok = rok;
            Zanr = zanr;
            ISBN = isbn;
            Kusy = kusy;
        }
        public string Nazev { get => nazev; set => nazev = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Rok { get => rok; set => rok = value; }
        public string Zanr { get => zanr; set => zanr = value; }
        public int ISBN { get => isbn; set => isbn = value; }
        public int Kusy { get => kusy; set => kusy = value; }
    }
}
