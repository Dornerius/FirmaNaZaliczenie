using System.Linq;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entities;

namespace MVVMFirma.ViewModels
{
    public class ProduktyUslugiViewModel : WszystkieViewModel <ProduktyUslugi> 
    {

        #region Constructor

        public ProduktyUslugiViewModel()
            :base("Produkty i uslugi")
        {}

        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<ProduktyUslugi>
                (
                    bazaCRMEntities.ProduktyUslugi.ToList() 
                );
        }

        #endregion

    }
}