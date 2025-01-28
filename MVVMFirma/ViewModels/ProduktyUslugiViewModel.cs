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
    public class ProduktyUslugiViewModel : WszystkieViewModel <ProduktyUslugi>
    {

        #region Constructor

        public ProduktyUslugiViewModel()
            : base("Produkty i Usługi")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<ProduktyUslugi>
                (
                    bazaCRMEntities.ProduktyUslugi.ToList()
                );
        }

        #endregion

    }
}