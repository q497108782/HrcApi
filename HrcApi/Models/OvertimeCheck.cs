//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HrcApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OvertimeCheck
    {
        public int ApprovalID { get; set; }
        public Nullable<int> LeaveID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> ApprovalType { get; set; }
        public Nullable<int> DepartmentalAaudit { get; set; }
        public string DepartmentalAauditRemarks { get; set; }
        public Nullable<int> ManagerAuidt { get; set; }
        public string ManagerAuidtRemarks { get; set; }
        public Nullable<int> GeneralManagerAudit { get; set; }
        public string GeneralManagerAuditRemarks { get; set; }
    }
}