//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RASolarSecurity.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserLocationMapping
    {
        public string UserID { get; set; }
        public string LocationCode { get; set; }
        public byte Status { get; set; }
        public string EntryUserID { get; set; }
        public System.DateTime EntryTime { get; set; }
    
        public virtual LocationInformation LocationInformation { get; set; }
        public virtual UserInformation UserInformation { get; set; }
        public virtual UserInformation UserInformation1 { get; set; }
    }
}
