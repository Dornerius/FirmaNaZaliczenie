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
    public class ProjektyViewModel: WszystkieViewModel<Projekty>
    {

        #region Constructor

        public ProjektyViewModel()
            : base("Projekty")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Projekty>
                (
                    bazaCRMEntities.Projekty.ToList()
                );
        }

        #endregion

    }
}