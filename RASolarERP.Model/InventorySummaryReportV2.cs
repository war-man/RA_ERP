//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RASolarERP.Model
{
    using System;
    
    public partial class InventorySummaryReportV2
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public string ItemModel { get; set; }
        public double A_OpeningBalance { get; set; }
        public double B_ReceivedByAuditAdjustment { get; set; }
        public double C_IssuedByAuditAdjustment { get; set; }
        public double D_TotalReceived { get; set; }
        public double E_TotalIssued { get; set; }
        public double F_ClosingBalance__A_B_C_D_E_ { get; set; }
    }
}