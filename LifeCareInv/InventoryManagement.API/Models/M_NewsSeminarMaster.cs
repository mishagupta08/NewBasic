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
    
    public partial class M_NewsSeminarMaster
    {
        public decimal NId { get; set; }
        public decimal NewsId { get; set; }
        public string NewsHdr { get; set; }
        public string NewsDtl { get; set; }
        public System.DateTime FrmDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public string NType { get; set; }
        public string Remarks { get; set; }
        public string ActiveStatus { get; set; }
        public System.DateTime RecTimeStamp { get; set; }
        public string LastModified { get; set; }
        public string UserCode { get; set; }
        public decimal UserId { get; set; }
    }
}
