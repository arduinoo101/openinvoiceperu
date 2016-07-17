﻿using System;

namespace OpenInvoicePeru.FirmadoSunat.Estructuras
{
    [Serializable]
    public class AccountingSupplierParty
    {
        public string CustomerAssignedAccountID { get; set; }
        public string AdditionalAccountID { get; set; }
        public Party Party { get; set; }

    }
}