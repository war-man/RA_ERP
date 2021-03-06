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
    
    public partial class Sal_Customer
    {
        public Sal_Customer()
        {
            this.Inv_ChallanMaster = new HashSet<Inv_ChallanMaster>();
            this.Inv_ItemNItemCategoryWithSerialNoMaster = new HashSet<Inv_ItemNItemCategoryWithSerialNoMaster>();
            this.Inv_MRRMaster = new HashSet<Inv_MRRMaster>();
        }
    
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string FathersOrHusbandName { get; set; }
        public string RelationWithGuardian { get; set; }
        public string MothersName { get; set; }
        public string NationalIDCard { get; set; }
        public string Gender { get; set; }
        public string PhoneNo { get; set; }
        public Nullable<bool> IsMobileNoMandatory { get; set; }
        public string Village { get; set; }
        public string PostOffice { get; set; }
        public string UnionID { get; set; }
        public string ThanaID { get; set; }
        public string DistrictCode { get; set; }
        public string UnitCode { get; set; }
        public string CustomerType { get; set; }
        public string Occupation { get; set; }
        public string IncomeRange { get; set; }
        public Nullable<byte> TotalFamilyMember { get; set; }
        public Nullable<byte> WomenInTotalFamilyMember { get; set; }
        public Nullable<bool> IsConsultedWithWomenMemberForInstallationOfLamps { get; set; }
        public string FuelUsedBeforeSHS { get; set; }
        public Nullable<byte> FuelConsumptionPerMonth { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public byte Status { get; set; }
        public Nullable<System.DateTime> StatusChangedDate { get; set; }
    
        public virtual Common_DistrictInfo Common_DistrictInfo { get; set; }
        public virtual Common_UnionInfo Common_UnionInfo { get; set; }
        public virtual Common_UnitInfo Common_UnitInfo { get; set; }
        public virtual Common_UpazillaInfo Common_UpazillaInfo { get; set; }
        public virtual ICollection<Inv_ChallanMaster> Inv_ChallanMaster { get; set; }
        public virtual ICollection<Inv_ItemNItemCategoryWithSerialNoMaster> Inv_ItemNItemCategoryWithSerialNoMaster { get; set; }
        public virtual ICollection<Inv_MRRMaster> Inv_MRRMaster { get; set; }
        public virtual Sal_CustomerFuelUsed Sal_CustomerFuelUsed { get; set; }
        public virtual Sal_CustomerIncomeRange Sal_CustomerIncomeRange { get; set; }
        public virtual Sal_CustomerOccupations Sal_CustomerOccupations { get; set; }
        public virtual Sal_CustomerRelations Sal_CustomerRelations { get; set; }
        public virtual Sal_SalesAgreement Sal_SalesAgreement { get; set; }
        public virtual Sal_CustomerStatus Sal_CustomerStatus { get; set; }
    }
}
