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
    public class ZadaniaViewModel : WszystkieViewModel<ZadaniaForAllView>
    {

        #region Constructor

        public ZadaniaViewModel()
            : base("Zadania")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<ZadaniaForAllView>
                (
                    from zadania in bazaCRMEntities.Zadania
                    select new ZadaniaForAllView
                    {
                        IdZadania = zadania.IdZadania,
                        NazwaZadania = zadania.NazwaZadania,
                        OpisZadania = zadania.OpicZadania,
                        ZespolyNazwa = zadania.Zespoly.Nazwa,
                        UzytkownicyImie = zadania.Uzytkownicy1.Imie,
                        UzytkownicyNazwisko = zadania.Uzytkownicy1.Nazwisko,
                        StatusyNazwaStatusu = zadania.Statusy.NazwaStatusu
                    }
                );
        }

        #endregion

    }
}