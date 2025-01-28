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
    public class RelacjeMiedzyKlientamiViewModel : WszystkieViewModel<RelacjeMiedzyKlientami>
    {

        #region Constructor

        public RelacjeMiedzyKlientamiViewModel()
            : base("Relacje Między Klientami")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<RelacjeMiedzyKlientami>
                (
                    bazaCRMEntities.RelacjeMiedzyKlientami.ToList()
                );
        }

        #endregion

    }
}