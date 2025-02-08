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
    public class ZamowieniaViewModel : WszystkieViewModel<ZamowieniaForAllView>
    {

        #region Constructor

        public ZamowieniaViewModel()
            : base("Zamowienia")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<ZamowieniaForAllView>
                (
                    from zamowienia in bazaCRMEntities.Zamowienia
                    select new ZamowieniaForAllView
                    {
                        IdZamowienia = zamowienia.IdZamowienia,
                        StatusNazwaStatusu = zamowienia.Statusy.NazwaStatusu,
                        DataZamowienia = zamowienia.DataZamowienia,
                        Kwota = zamowienia.Kwota,
                        PorduktyUslugiNazwa = zamowienia.ProduktyUslugi.Nazwa,
                        IloscSztuk = zamowienia.IloscSztuk
                    }
                );
        }

        #endregion

    }
}
