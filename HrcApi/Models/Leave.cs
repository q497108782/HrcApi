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
    using SqlSugar;
    using System;
    using System.Collections.Generic;

    [SugarTable("Leave")]//当和数据库名称不一样可以设置别名
    public partial class Leave
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]//通过特性设置主键和自增列 
        public int LeaveID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> LeaveState { get; set; }
        public Nullable<System.DateTime> LeaveTime { get; set; }
        public Nullable<System.DateTime> LeaveStartTime { get; set; }
        public Nullable<System.DateTime> LeaveEndTime { get; set; }
        public string LeaveHalfDay { get; set; }
        public string LeaveDays { get; set; }
        public string LeaveReason { get; set; }
        public Nullable<int> ApproverID { get; set; }
        public Nullable<System.DateTime> ApprovalTime { get; set; }
        public string ApproverReason { get; set; }
    }
}
