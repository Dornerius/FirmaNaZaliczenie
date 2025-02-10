using System.Linq;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entities.EntitiesForView;

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