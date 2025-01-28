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
    public class ZespolyViewModel : WszystkieViewModel<Zespoly>
    {

        #region Constructor

        public ZespolyViewModel()
            : base("Zespoly")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Zespoly>
                (
                    bazaCRMEntities.Zespoly.ToList()
                );
        }

        #endregion

    }
}