using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entities;
using MVVMFirma.Helper;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class UzytkownicyViewModel : WszystkieViewModel<Uzytkownicy>
    {

        #region Constructor

        public UzytkownicyViewModel()
            : base("Użytkownicy")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Uzytkownicy>
                (
                    bazaCRMEntities.Uzytkownicy.ToList()
                );
        }

        #endregion

    }
}
