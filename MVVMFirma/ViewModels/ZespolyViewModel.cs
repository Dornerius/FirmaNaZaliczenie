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
    public class ZespolyViewModel : WszystkieViewModel<ZespolyForAllView>
    {

        #region Constructor

        public ZespolyViewModel()
            : base("Zespoly")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<ZespolyForAllView>
                (
                    from zespoly in bazaCRMEntities.Zespoly
                    select new ZespolyForAllView
                    {
                        IdZespolu = zespoly.IdZespolu,
                        Nazwa = zespoly.Nazwa,
                        Opis = zespoly.Opis,
                        UzytkownicyImie = zespoly.Uzytkownicy.Imie,
                        UzytkownicyNazwisko = zespoly.Uzytkownicy.Nazwisko,
                        Uzytkownicy1Imie = zespoly.Uzytkownicy1.Imie,
                        Uzytkownicy1Nazwisko = zespoly.Uzytkownicy1.Nazwisko,
                        Uzytkownicy2Imie = zespoly.Uzytkownicy2.Imie,
                        Uzytkownicy2Nazwisko = zespoly.Uzytkownicy2.Nazwisko,
                        Uzytkownicy3Imie = zespoly.Uzytkownicy3.Imie,
                        Uzytkownicy3Nazwisko = zespoly.Uzytkownicy3.Nazwisko,
                        Uzytkownicy4Imie = zespoly.Uzytkownicy4.Imie,
                        Uzytkownicy4Nazwisko = zespoly.Uzytkownicy4.Nazwisko,
                        Uzytkownicy5Imie = zespoly.Uzytkownicy5.Imie,
                        Uzytkownicy5Nazwisko = zespoly.Uzytkownicy5.Nazwisko,
                        ProjektyNazwaProjektu = zespoly.Projekty.NazwaProjektu,
                        Projekty1NazwaProjektu = zespoly.Projekty1.NazwaProjektu,
                        KlienciNazwaFirmy = zespoly.Klienci.NazwaFirmy,
                        Klienci1NazwaFirmy = zespoly.Klienci1.NazwaFirmy,
                        ZadaniaNazwaZadania = zespoly.Zadania.NazwaZadania,
                        Zadania1NazwaZadania = zespoly.Zadania1.NazwaZadania
                    }
                );
        }

        #endregion

    }
}