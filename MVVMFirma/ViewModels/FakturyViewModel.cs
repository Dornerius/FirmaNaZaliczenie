using System.Linq;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entities.EntitiesForView;

namespace MVVMFirma.ViewModels
{
    public class FakturyViewModel : WszystkieViewModel<FakturaForAllView>
    {

        #region Constructor

        public FakturyViewModel()
            : base("Faktury")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<FakturaForAllView>
                (
                    from faktury in bazaCRMEntities.Faktury
                    select new FakturaForAllView
                    {
                        NrFaktury = faktury.NrFaktury,
                        DataWystawienia = faktury.DataWystawienia,
                        ProduktyUslugiNazwa = faktury.ProduktyUslugi.Nazwa,
                        ProduktyUslugiCena = faktury.ProduktyUslugi.Cena,
                        IloscSztuk = faktury.IloscSztuk,
                        KwotaNetto = faktury.KwotaNetto,
                        Podatek = faktury.Podatek,
                        KwotaBrutto = faktury.KwotaBrutto,
                        RodzajePlatnosciNazwaRodzajuPlatnosci = faktury.RodzajePlatnosci.NazwaRodzajuPlatnosci,
                        KlienciNazwaFirmy = faktury.Klienci.NazwaFirmy,
                        KlienciOsobowoscPrawna = faktury.Klienci.OsobowoscPrawna,
                        StatusFakturyNazwaStatusu = faktury.StatusFaktury.NazwaStatusu
                    }
                );
        }

        #endregion

    }
}
