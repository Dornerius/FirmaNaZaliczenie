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
    public class ZadaniaViewModel : WszystkieViewModel<Zadania>
    {

        #region Constructor

        public ZadaniaViewModel()
            : base("Zadania")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Zadania>
                (
                    bazaCRMEntities.Zadania.ToList()
                );
        }

        #endregion

    }
}