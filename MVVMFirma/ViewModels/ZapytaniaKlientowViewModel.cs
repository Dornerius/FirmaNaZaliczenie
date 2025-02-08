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
    public class ZapytaniaKlientowViewModel : WszystkieViewModel<ZapytaniaKlientowForAllView>
    {

        #region Constructor

        public ZapytaniaKlientowViewModel()
            : base("Zapytania Klientów")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<ZapytaniaKlientowForAllView>
                (
                    from zapytaniaKlientow in bazaCRMEntities.ZapytaniaKlientow
                    select new ZapytaniaKlientowForAllView
                    {
                        IdZapytania = zapytaniaKlientow.IdZapytania,
                        KlienciNazwaFirmy = zapytaniaKlientow.Klienci.NazwaFirmy,                        
                        DataZapytania = zapytaniaKlientow.DataZapytania,
                        TrescZapytania = zapytaniaKlientow.TrescZapytania,
                        StatusyNazwaStatusu= zapytaniaKlientow.Statusy.NazwaStatusu
                    }
                );
        }

        #endregion

    }
}