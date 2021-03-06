//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManagement.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeletedVoucher
    {
        public decimal VoucherId { get; set; }
        public decimal FSessId { get; set; }
        public decimal VoucherNo { get; set; }
        public System.DateTime VoucherDate { get; set; }
        public string DepoCode { get; set; }
        public string DrTo { get; set; }
        public string CrTo { get; set; }
        public decimal Amount { get; set; }
        public string Narration { get; set; }
        public string RefNo { get; set; }
        public string BType { get; set; }
        public decimal AccDocNo { get; set; }
        public string AccDocType { get; set; }
        public System.DateTime AccDocDate { get; set; }
        public string AccRemark { get; set; }
        public string AccParentKey { get; set; }
        public string AccCompany { get; set; }
        public string AccTransKey { get; set; }
        public string ActiveStatus { get; set; }
        public System.DateTime RecTimeStamp { get; set; }
        public decimal UserId { get; set; }
        public string UserName { get; set; }
        public string Version { get; set; }
        public string PayMode { get; set; }
        public int BankCode { get; set; }
        public string BankName { get; set; }
        public string ChqNo { get; set; }
        public Nullable<System.DateTime> ChqDate { get; set; }
        public string VType { get; set; }
        public int SessID { get; set; }
        public System.DateTime DRecTimeStamp { get; set; }
        public string DReason { get; set; }
        public decimal DUserId { get; set; }
    }
}
