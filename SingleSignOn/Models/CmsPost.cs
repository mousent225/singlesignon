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
    using System.Collections.Generic;
    
    public partial class CmsPost
    {
        public CmsPost()
        {
            this.CmsPosts1 = new HashSet<CmsPost>();
        }
    
        public int PostId { get; set; }
        public string Subject { get; set; }
        public System.Guid Category { get; set; }
        public string ApplyToPlant { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Content { get; set; }
        public Nullable<System.Guid> Kind { get; set; }
        public Nullable<int> ReplyToId { get; set; }
        public string CreateUid { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string UpdateUid { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string DeleteUid { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public bool IsAttachFile { get; set; }
    
        public virtual HrEmpMaster HrEmpMaster { get; set; }
        public virtual HrEmpMaster HrEmpMaster1 { get; set; }
        public virtual HrEmpMaster HrEmpMaster2 { get; set; }
        public virtual ICollection<CmsPost> CmsPosts1 { get; set; }
        public virtual CmsPost CmsPost1 { get; set; }
    }
}
