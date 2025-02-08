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
    public class TransakcjeViewModel : WszystkieViewModel<TransakcjeForAllView>
    {

        #region Constructor

        public TransakcjeViewModel()
            : base("Transakcje")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<TransakcjeForAllView>
                (
                    from transakcje in bazaCRMEntities.Transakcje
                    select new TransakcjeForAllView
                    {
                        IdTransakcji = transakcje.IdTransakcji,
                        StatusyNazwaStatusu = transakcje.Statusy.NazwaStatusu,
                        KlienciNazwaFirmy = transakcje.Klienci.NazwaFirmy,
                        RodzajTransakcji = transakcje.RodzajTransakcji,
                        DataTransakcji = transakcje.DataTransakcji,
                        KwotaTransakcji = transakcje.KwotaTransakcji,
                        DodatkoweInformacje = transakcje.DodatkoweInformacje
                    }

                );
        }

        #endregion

    }
}