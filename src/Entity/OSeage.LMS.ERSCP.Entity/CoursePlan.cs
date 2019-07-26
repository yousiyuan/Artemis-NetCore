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
/// 开课计划表
///</summary>
    public class CoursePlan
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 上课学院key
///</summary>
public long? CollegeKey { get; set; }
///<summary>
/// 上课年级
///</summary>
public string Year { get; set; }
///<summary>
/// 上课专业key
///</summary>
public long? SpecialtyKey { get; set; }
///<summary>
/// 计划类型（1必修课，2选修课）
///</summary>
public string PlanType { get; set; }
///<summary>
/// 生成类型（1按班生成，2按组生成）
///</summary>
public string BuildType { get; set; }
///<summary>
/// 计划状态(1未生成，2已生成)
///</summary>
public string PlanStatus { get; set; }
///<summary>
/// is_joint, bit
///</summary>
public bool? IsJoint { get; set; }
///<summary>
/// class_name, nvarchar
///</summary>
public string ClassName { get; set; }
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

