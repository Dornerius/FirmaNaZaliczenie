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
    public class ZapytaniaKlientowViewModel : WszystkieViewModel<ZapytaniaKlientow>
    {

        #region Constructor

        public ZapytaniaKlientowViewModel()
            : base("Zapytania Klientów")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<ZapytaniaKlientow>
                (
                    bazaCRMEntities.ZapytaniaKlientow.ToList()
                );
        }

        #endregion

    }
}