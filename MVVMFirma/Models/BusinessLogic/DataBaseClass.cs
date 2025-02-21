﻿using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.BusinessLogic
{
    public class DataBaseClass
    {
        #region DB
        public BazaCRMEntities bazaCRMEntities { get; set; }
        #endregion
        #region Constructor
        public DataBaseClass(BazaCRMEntities bazaCRMEntities)
        {
            this.bazaCRMEntities = bazaCRMEntities; 
        }
        #endregion
    }
}
