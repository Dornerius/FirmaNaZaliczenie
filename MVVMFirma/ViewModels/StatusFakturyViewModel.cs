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
    public class StatusFakturyViewModel : WszystkieViewModel<StatusFaktury>
    {

        #region Constructor

        public StatusFakturyViewModel()
            : base("Status Faktury")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<StatusFaktury>
                (
                    bazaCRMEntities.StatusFaktury.ToList()
                );
        }

        #endregion

    }
}
