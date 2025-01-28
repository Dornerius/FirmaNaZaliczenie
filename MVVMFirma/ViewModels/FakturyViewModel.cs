﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entities;
using MVVMFirma.Helper;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{
    public class FakturyViewModel : WszystkieViewModel<Faktury>
    {

        #region Constructor

        public FakturyViewModel()
            : base("Faktury")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Faktury>
                (
                    bazaCRMEntities.Faktury.ToList()
                );
        }

        #endregion

    }
}
