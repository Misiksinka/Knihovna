using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace Knihovna.Pages
{
    public partial class Knihov
    {
        public Polozka Polozka { get; set; } = new Polozka();
        public List <Polozka> PolozkaList { get; set; }= new List<Polozka>();
        public List <Polozka> PolozkaFiltrList { get; set; }= new List<Polozka> ();

        public bool JeEditace { get; set; } = false;
        public bool JeFiltrace { get; set;} = false;

        public double FiltrHodnota { get; set; }

        private void Pridat (Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
            PolozkaList.Add(new Polozka(Polozka.Nazev, Polozka.Autor, Polozka.Rok, Polozka.Zanr, Polozka.ISBN, Polozka.Kusy));
        }

        private async Task SmazatZaznam(Polozka polozka)
        {
            string zprava = $"Chcete odebrat {polozka.Autor}{polozka.Nazev}{polozka.Rok}{polozka.Zanr}{polozka.ISBN}";
            if (!await JS.InvokeAsync<bool>("confirm", zprava))
            {

            }
            PolozkaList.Remove (polozka);
        }
        private Task <T> InvokeAsync<T>(string v, string zprava)
        {
            throw new NotImplementedException();
        }
        private void EditujZaznam(Polozka pol)
        {
            Polozka = pol;
            JeEditace = true;
        }

        private void UkonciEditaci()
        { 
            JeEditace = false;
            Polozka = new Polozka();
        }
        public void FiltrujPolozky()
        {
            PolozkaFiltrList = PolozkaList.Where(x=> x.ISBN==FiltrHodnota).ToList();
        }

    }
}
