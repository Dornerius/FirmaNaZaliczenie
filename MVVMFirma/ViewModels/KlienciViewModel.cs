using System.Linq;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entities.EntitiesForView;

namespace MVVMFirma.ViewModels
{
    public class KlienciViewModel : WszystkieViewModel<KlienciForAllView>
    { 
        #region Constructor

        public KlienciViewModel()
            :base("Klienci")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<KlienciForAllView>
                (
                    from klienci in bazaCRMEntities.Klienci
                    select new KlienciForAllView
                    {
                        NazwaFirmy = klienci.NazwaFirmy,
                        OsobowoscPrawna = klienci.OsobowoscPrawna,
                        Email = klienci.Email,
                        Telefon = klienci.telefon,
                        Wojewodztwo = klienci.Wojewodztwo,
                        KodPocztowy = klienci.KodPocztowy,
                        Powiat = klienci.Powiat,
                        Miejscowosc = klienci.Miejscowosc,
                        Ulica = klienci.Ulica,
                        NrBudynku = klienci.NrBudynku,
                        NrLokalu = klienci.NrLokalu,
                        Poczta = klienci.Poczta,
                        Regon = klienci.Regon,
                        Nip = klienci.Nip,
                        Krs = klienci.Krs,
                        MediaSpolecznosciowe = klienci.MediaSpolecznosciowe,
                        DodatkoweInformacje = klienci.DodatkoweInformacje,
                        UzytkownicyImie = klienci.Uzytkownicy.Imie,
                        UzytkownicyNazwisko = klienci.Uzytkownicy.Nazwisko,
                        UzytkownicyRola = klienci.Uzytkownicy.Rola,
                        ZespolyNazwa = klienci.Zespoly.Nazwa,
                        ProjektyNazwaProjektu = klienci.Projekty.NazwaProjektu
                    }


                );
        }

        #endregion

    }
}