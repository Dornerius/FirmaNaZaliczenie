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
    public class InterakcjeKlientowViewModel : WszystkieViewModel<InterakcjeKlientow>
    {

        #region Constructor

        public InterakcjeKlientowViewModel()
            : base("Interakcje Klientów")
        { }

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<InterakcjeKlientow>
                (
                    bazaCRMEntities.InterakcjeKlientow.ToList()
                );
        }

        #endregion

    }
}