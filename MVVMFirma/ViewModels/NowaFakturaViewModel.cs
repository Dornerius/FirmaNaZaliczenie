using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class NowaFakturaViewModel : JedenViewModel<Faktury>
    {
        #region Constructor
        public NowaFakturaViewModel()
            : base("Nowa faktura")
        {
            DisplayName = "Nowa faktura";
            item = new Faktury();

        }
        #endregion
        #region Properties
        public string NrFaktury
        {
            get 
            { 
                return item.NrFaktury; 
            }
            set
            {                
                {
                    item.NrFaktury = value;
                    OnPropertyChanged(() => NrFaktury);
                }
            }
        }
        public int? IdProduktuUslugi
        {
            get
            {
                return item.IdProduktuUslugi;
            }
            set
            {
                {
                    item.IdProduktuUslugi = value;
                    OnPropertyChanged(() => IdProduktuUslugi);
                }
            }
        }
        public int? IdRodzajuPlatnosci
        {
            get
            {
                return item.IdRodzajuPlatnosci;
            }
            set
            {
                {
                    item.IdRodzajuPlatnosci = value;
                    OnPropertyChanged(() => IdRodzajuPlatnosci);
                }
            }
        }
        public DateTime? DataWystawienia
        {
            get
            {
                return item.DataWystawienia;
            }
            set
            {
                {
                    item.DataWystawienia = value;
                    OnPropertyChanged(() => DataWystawienia);
                }
            }
        }
        public int? IdKlienta
        {
            get
            {
                return item.IdKlienta;
            }
            set
            {
                {
                    item.IdKlienta = value;
                    OnPropertyChanged(() => IdKlienta);
                }
            }
        }
        public decimal? KwotaNetto
        {
            get
            {
                return item.KwotaNetto;
            }
            set
            {
                {
                    item.KwotaNetto = value;
                    OnPropertyChanged(() => KwotaNetto);
                }
            }
        }
        public decimal? KwotaBrutto
        {
            get
            {
                return item.KwotaBrutto;
            }
            set
            {
                {
                    item.KwotaBrutto = value;
                    OnPropertyChanged(() => KwotaBrutto);
                }
            }
        }
        public int? Podatek
        {
            get
            {
                return item.Podatek;
            }
            set
            {
                {
                    item.Podatek = value;
                    OnPropertyChanged(() => Podatek);
                }
            }
        }
        public int? IloscSztuk
        {
            get
            {
                return item.IloscSztuk;
            }
            set
            {
                {
                    item.IloscSztuk = value;
                    OnPropertyChanged(() => IloscSztuk);
                }
            }
        }
        public int? IdStatusuFaktury
        {
            get
            {
                return item.IdStatusuFaktury;
            }
            set
            {
                {
                    item.IdStatusuFaktury = value;
                    OnPropertyChanged(() => IdStatusuFaktury);
                }
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            bazaCRMEntities.Faktury.Add(item);
            bazaCRMEntities.SaveChanges();
        }
        #endregion
    }


}
