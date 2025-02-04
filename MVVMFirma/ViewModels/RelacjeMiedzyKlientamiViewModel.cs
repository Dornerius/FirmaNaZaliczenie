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
    public class RelacjeMiedzyKlientamiViewModel : WszystkieViewModel<RealcjeMiedzyKlientamiForAllView>
    {

        #region Constructor

        public RelacjeMiedzyKlientamiViewModel()
            : base("Relacje Między Klientami")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<RealcjeMiedzyKlientamiForAllView>
                (
                    from relacjeMiedzyKlientami in bazaCRMEntities.RelacjeMiedzyKlientami
                    select new RealcjeMiedzyKlientamiForAllView
                    {
                        KlienciNazwaKlienta = relacjeMiedzyKlientami.Klienci.NazwaFirmy,
                        Klienci1NazwaKlienta = relacjeMiedzyKlientami.Klienci1.NazwaFirmy,
                        OpisRelacji = relacjeMiedzyKlientami.OpisRelacji
                    }
                );
        }

        #endregion

    }
}