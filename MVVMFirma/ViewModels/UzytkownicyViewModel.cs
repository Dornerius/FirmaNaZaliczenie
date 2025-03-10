﻿using System;
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
        #region Sort and find
        public override List<string> GetComboBoxSortList()
        {
            return new List<string> { "Imie", "Nazwisko", "Email", "Telefon", "Rola", "Zespół", "Zadanie", "Projekt", "Klient", "Szkolenie" };
        }

        public override void Sort()
        {
            if (SortField == "Imie")
                List = new ObservableCollection<UzytkownicyAllForView>(List.OrderBy(item => item.Imie));
            if (SortField == "Nazwisko")
                List = new ObservableCollection<UzytkownicyAllForView>(List.OrderBy(item => item.Nazwisko));
            if (SortField == "Email")
                List = new ObservableCollection<UzytkownicyAllForView>(List.OrderBy(item => item.Email));
            if (SortField == "Telefon")
                List = new ObservableCollection<UzytkownicyAllForView>(List.OrderBy(item => item.Telefon));
            if (SortField == "Rola")
                List = new ObservableCollection<UzytkownicyAllForView>(List.OrderBy(item => item.Rola));
            if (SortField == "Zespół")
                List = new ObservableCollection<UzytkownicyAllForView>(List.OrderBy(item => item.ZespolyNazwa));
            if (SortField == "Zadanie")
                List = new ObservableCollection<UzytkownicyAllForView>(List.OrderBy(item => item.ZadaniaNazwa));
            if (SortField == "Projekt")
                List = new ObservableCollection<UzytkownicyAllForView>(List.OrderBy(item => item.ProjektyNazwa));
            if (SortField == "Klient")
                List = new ObservableCollection<UzytkownicyAllForView>(List.OrderBy(item => item.KlienciNazwaFirmy));
            if (SortField == "Szkolenie")
                List = new ObservableCollection<UzytkownicyAllForView>(List.OrderBy(item => item.SzkoleniaNazwa));
        }

        public override List<string> GetComboBoxFindList()
        {
            return new List<string> { "Imie", "Nazwisko", "Email", "Telefon", "Rola", "Zespół", "Zadanie", "Projekt", "Klient", "Szkolenie" };
        }
        public override void Find()
        {
            if (FindField == "Imie")
                List = new ObservableCollection<UzytkownicyAllForView>(List.Where(item => item.Imie != null && item.Imie.StartsWith(FindTextBox)));
            if (FindField == "Nazwisko")
                List = new ObservableCollection<UzytkownicyAllForView>(List.Where(item => item.Nazwisko != null && item.Nazwisko.StartsWith(FindTextBox)));
            if (FindField == "Email")
                List = new ObservableCollection<UzytkownicyAllForView>(List.Where(item => item.Email != null && item.Email.StartsWith(FindTextBox)));
            if (FindField == "Telefon")
                List = new ObservableCollection<UzytkownicyAllForView>(List.Where(item => item.Telefon != null && item.Telefon.ToString().StartsWith(FindTextBox)));
            if (FindField == "Rola")
                List = new ObservableCollection<UzytkownicyAllForView>(List.Where(item => item.Rola != null && item.Rola.StartsWith(FindTextBox)));
            if (FindField == "Zespół")
                List = new ObservableCollection<UzytkownicyAllForView>(List.Where(item => item.ZespolyNazwa != null && item.ZespolyNazwa.StartsWith(FindTextBox)));
            if (FindField == "Zadanie")
                List = new ObservableCollection<UzytkownicyAllForView>(List.Where(item => item.ZadaniaNazwa != null && item.ZadaniaNazwa.StartsWith(FindTextBox)));
            if (FindField == "Projekt")
                List = new ObservableCollection<UzytkownicyAllForView>(List.Where(item => item.ProjektyNazwa != null && item.ProjektyNazwa.StartsWith(FindTextBox)));
            if (FindField == "Klient")
                List = new ObservableCollection<UzytkownicyAllForView>(List.Where(item => item.KlienciNazwaFirmy != null && item.KlienciNazwaFirmy.StartsWith(FindTextBox)));
            if (FindField == "Szkolenie")
                List = new ObservableCollection<UzytkownicyAllForView>(List.Where(item => item.SzkoleniaNazwa != null && item.SzkoleniaNazwa.StartsWith(FindTextBox)));
        }

        #endregion
    }
}
