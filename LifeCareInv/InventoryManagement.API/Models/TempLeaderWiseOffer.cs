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
    
    public partial class TempLeaderWiseOffer
    {
        public int MId { get; set; }
        public int AId { get; set; }
        public int FSessId { get; set; }
        public int SNo { get; set; }
        public decimal UId { get; set; }
        public string ParentProdId { get; set; }
        public decimal FormNo { get; set; }
        public string IDNo { get; set; }
        public string Remarks { get; set; }
        public string ActiveStatus { get; set; }
        public int UserId { get; set; }
        public System.DateTime RTS { get; set; }
        public string DReason { get; set; }
        public int DUserId { get; set; }
        public System.DateTime DRTS { get; set; }
    }
}
