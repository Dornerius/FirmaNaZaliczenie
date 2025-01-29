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
            : base("Faktura")
        {
            DisplayName = "Faktura";
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
                item.NrFaktury = value;
                OnPropertyChanged(() => NrFaktury);                
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
                item.DataWystawienia = value;
                OnPropertyChanged(() => DataWystawienia);
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
                item.KwotaNetto = value;
                OnPropertyChanged(() => KwotaNetto);
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
                item.KwotaBrutto = value;
                OnPropertyChanged(() => KwotaBrutto);

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
                item.Podatek = value; 
                OnPropertyChanged(() => Podatek);
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
                item.IloscSztuk = value;
                OnPropertyChanged(() => IloscSztuk);
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
    } }