using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class NowaFakturaViewModel : JedenViewModel<NowaFaktura>
    {
        #region Constructor
        public NowaFakturaViewModel()
            : base("Faktura")
        {
            DisplayName = "Faktura";
            item = new Faktura();

        }
        #endregion
        #region Properties
        public decimal NumerFaktury
        {
            get 
            { 
                return item.NumerFaktury; 
            }
            set
            {                
                {
                    item.NumerFaktury = value;
                    OnPropertyChanged(() => NrFaktury);
                }
            }
        }
        #region Helpers
        public override void Save()
        {
            bazaCRMEntities.Faktura.Add(item);
            bazaCRMEntities.SaveChanges();
        }
        #endregion
    }


}
