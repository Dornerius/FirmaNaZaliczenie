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
    public class TransakcjeViewModel : WszystkieViewModel<Transakcje>
    {

        #region Constructor

        public TransakcjeViewModel()
            : base("Transakcje")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Transakcje>
                (
                    bazaCRMEntities.Transakcje.ToList()
                );
        }

        #endregion

    }
}