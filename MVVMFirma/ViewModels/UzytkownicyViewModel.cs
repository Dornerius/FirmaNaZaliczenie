using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entities;
using MVVMFirma.Helper;
using System.Windows.Input;
using MVVMFirma.Models.Entities.EntitiesForView;

namespace MVVMFirma.ViewModels
{
    public class UzytkownicyViewModel : WszystkieViewModel<UzytkownicyAllForView>
    {

        #region Constructor

        public UzytkownicyViewModel()
            : base("Użytkownicy")
        { }

        public override void Load() => List = new ObservableCollection<UzytkownicyAllForView>
                (
                    from uzytkownicy in bazaCRMEntities.Uzytkownicy
                    select new UzytkownicyAllForView
                    {
                        Imie = uzytkownicy.Imie,
                        Nazwisko = uzytkownicy.Nazwisko,
                        Email = uzytkownicy.Email,
                        Telefon = uzytkownicy.Telefon,
                        Rola = uzytkownicy.Rola,
                        ZespolyNazwa = uzytkownicy.Zespoly.Nazwa,
                        ZadaniaNazwa = uzytkownicy.Zadania.NazwaZadania,
                        ProjektyNazwa = uzytkownicy.Projekty1.NazwaProjektu,
                        KlienciNazwaFirmy = uzytkownicy.Klienci1.NazwaFirmy,                        
                        SzkoleniaNazwa = uzytkownicy.Szkolenia.Nazwa
                    }
                );

        #endregion

    }
}
