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
    
    public partial class Inv_ChallanMaster
    {
        public Inv_ChallanMaster()
        {
            this.Aud_AuditAdjustmentRelatedChallanOrMRRForReference = new HashSet<Aud_AuditAdjustmentRelatedChallanOrMRRForReference>();
            this.Inv_ChallanDetails = new HashSet<Inv_ChallanDetails>();
            this.Inv_ChallanWithMultipleLocations = new HashSet<Inv_ChallanWithMultipleLocations>();
            this.Inv_MRRMaster = new HashSet<Inv_MRRMaster>();
            this.Sal_SparePartsSalesMaster = new HashSet<Sal_SparePartsSalesMaster>();
        }
    
        public string LocationCode { get; set; }
        public string ChallanSeqNo { get; set; }
        public System.DateTime ChallanDate { get; set; }
        public byte FromStoreLocation { get; set; }
        public string RefChallanNo { get; set; }
        public string ChallanToLocationCode { get; set; }
        public string ValidItemTransTypeForMRR { get; set; }
        public string RefCustomerCode { get; set; }
        public string ItemType { get; set; }
        public string ItemTransTypeID { get; set; }
        public bool IsItForMultipleLocations { get; set; }
        public Nullable<byte> RefLocationType { get; set; }
        public string RefUserRoleOrGroupID { get; set; }
        public string RefAELocationCode { get; set; }
        public Nullable<System.DateTime> RefAETransDate { get; set; }
        public string RefAEProjectCode { get; set; }
        public string RefAETransNo { get; set; }
        public string Particulars { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte Status { get; set; }
        public string RefVendorID { get; set; }
    
        public virtual ICollection<Aud_AuditAdjustmentRelatedChallanOrMRRForReference> Aud_AuditAdjustmentRelatedChallanOrMRRForReference { get; set; }
        public virtual Common_LocationInfo Common_LocationInfo { get; set; }
        public virtual ICollection<Inv_ChallanDetails> Inv_ChallanDetails { get; set; }
        public virtual Inv_ItemTransactionTypes Inv_ItemTransactionTypes { get; set; }
        public virtual Inv_Sys_ItemType Inv_Sys_ItemType { get; set; }
        public virtual ICollection<Inv_ChallanWithMultipleLocations> Inv_ChallanWithMultipleLocations { get; set; }
        public virtual ICollection<Inv_MRRMaster> Inv_MRRMaster { get; set; }
        public virtual ICollection<Sal_SparePartsSalesMaster> Sal_SparePartsSalesMaster { get; set; }
        public virtual Sal_Customer Sal_Customer { get; set; }
    }
}
