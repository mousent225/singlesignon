//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SingleSignOn.Models
{
    using System;
    
    public partial class SP_APPLICATION_MASTER_GETALL_Result
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }
        public string DeptName { get; set; }
        public int DeptId { get; set; }
        public string ApprovalLineJson { get; set; }
        public string ApprovalLine { get; set; }
        public string ApprovalStatusName { get; set; }
        public System.Guid ApprovalStatus { get; set; }
        public string CreateUid { get; set; }
        public string CreateName { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.Guid ApprovalKind { get; set; }
        public string KindName { get; set; }
        public string Description { get; set; }
        public string ApplicationName { get; set; }
        public string NextApprover { get; set; }
        public string NextApproverName { get; set; }
        public int ApplicationId { get; set; }
        public string RequestDate { get; set; }
    }
}
