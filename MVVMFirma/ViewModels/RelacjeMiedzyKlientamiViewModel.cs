using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entities;
using MVVMFirma.Helper;
using System.Windows.Input;
using MVVMFirma.Models.Entities.EntitiesForView;
using System.Data.Entity;

namespace MVVMFirma.ViewModels
{
    public class RelacjeMiedzyKlientamiViewModel : WszystkieViewModel<RelacjeMiedzyKlientamiForAllView>
    {

        #region Constructor

        public RelacjeMiedzyKlientamiViewModel()
            : base("Relacje Między Klientami")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<RelacjeMiedzyKlientamiForAllView>
                (
                    from relacjeMiedzyKlientami in bazaCRMEntities.RelacjeMiedzyKlientami
                        .Include("Klienci")
                        .Include("Klienci1")
                    select new RelacjeMiedzyKlientamiForAllView
                    {
                        KlienciNazwaFirmy = relacjeMiedzyKlientami.Klienci.NazwaFirmy,
                        Klienci1NazwaFirmy = relacjeMiedzyKlientami.Klienci1.NazwaFirmy,
                        OpisRelacji = relacjeMiedzyKlientami.OpisRelacji
                    }
                );
        }

        #endregion

    }
}