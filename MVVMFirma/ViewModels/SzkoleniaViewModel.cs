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
    public class SzkoleniaViewModel : WszystkieViewModel<Szkolenia>
    {

        #region Constructor

        public SzkoleniaViewModel()
            : base("Klienci")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Szkolenia>
                (
                    bazaCRMEntities.Szkolenia.ToList()
                );
        }

        #endregion

    }
}