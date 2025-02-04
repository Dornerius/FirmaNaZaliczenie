using System.Linq;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entities.EntitiesForView;
using MVVMFirma.Models.Entities;

namespace MVVMFirma.ViewModels
{
    public class ProjektyViewModel: WszystkieViewModel<ProjektyForAllView>
    {

        #region Constructor

        public ProjektyViewModel()
            : base("Projekty")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<ProjektyForAllView>
                (
                    from projekty in bazaCRMEntities.Projekty
                    select new ProjektyForAllView
                    {
                        UzytkownicyImie = projekty.Uzytkownicy.Imie,
                        UzytkownicyNazwisko = projekty.Uzytkownicy.Nazwisko,
                        KlienciNazwaFirmy = projekty.Klienci1.NazwaFirmy,                        
                        ZespolyNazwa = projekty.Zespoly.Nazwa,
                        NazwaProjektu = projekty.NazwaProjektu,
                        DataRozpoczecia = projekty.DataRozpoczecia,
                        DataZakonczenia = projekty.DataZakonczenia,
                        StatusyNazwaStatusu = projekty.Statusy.NazwaStatusu
                    }
                );
        }

        #endregion

    }
}