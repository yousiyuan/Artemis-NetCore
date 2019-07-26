//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:57
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************

using System;
namespace OSeage.LMS.ERSCP.Entity
{

    ///<summary>
/// 审核记录表
///</summary>
    public class AuditRecord
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 1课程key，2培养方案key
///</summary>
public string ObjType { get; set; }
///<summary>
/// 关联key
///</summary>
public long? ObjKey { get; set; }
///<summary>
/// 审核步骤，1提交，2院系审核，3教务审核
///</summary>
public string OpStep { get; set; }
///<summary>
/// 审核结果，1通过，2拒绝
///</summary>
public string Result { get; set; }
///<summary>
/// 说明
///</summary>
public string Note { get; set; }
///<summary>
/// 创建者
///</summary>
public long? Creator { get; set; }
///<summary>
/// 创建时间
///</summary>
public DateTime? CreateTime { get; set; }
///<summary>
/// 修改者
///</summary>
public long? Editor { get; set; }
///<summary>
/// 修改时间
///</summary>
public DateTime? UpdateTime { get; set; }
///<summary>
/// 逻辑状态：1正常；0逻辑删除
///</summary>
public bool? Status { get; set; }
    }
    }

