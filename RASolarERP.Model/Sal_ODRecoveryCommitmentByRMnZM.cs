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
    using System.Collections.Generic;
    
    public partial class Sal_ODRecoveryCommitmentByRMnZM
    {
        public string YearMonth { get; set; }
        public string UnitCode { get; set; }
        public double LastMonthODCollectionEfficiency { get; set; }
        public decimal OverdueBalance { get; set; }
        public decimal ThisMonthRecoveryFromOD { get; set; }
        public decimal RemainingODBalance { get; set; }
        public double ThisMonthODCollectionEfficiency { get; set; }
        public string LastRMCommitmentToRecoverRemainingOD { get; set; }
        public Nullable<System.DateTime> LastRMRemarksOn { get; set; }
        public string LastZMCommitmentToRecoverRemainingOD { get; set; }
        public Nullable<System.DateTime> LastZMRemarksOn { get; set; }
    }
}
