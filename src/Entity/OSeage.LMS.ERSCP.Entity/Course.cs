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
/// 课程
///</summary>
    public class Course
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 代码
///</summary>
public string Code { get; set; }
///<summary>
/// 名称
///</summary>
public string Name { get; set; }
///<summary>
/// 申请人
///</summary>
public string ApplyUserName { get; set; }
///<summary>
/// 申请人单位
///</summary>
public long? ApplyUserDepart { get; set; }
///<summary>
/// 开课单位
///</summary>
public long? DepartKey { get; set; }
///<summary>
/// 学科
///</summary>
public long? SubjectKey { get; set; }
///<summary>
/// 所属类别
///</summary>
public string CourseCategory { get; set; }
///<summary>
/// 学分
///</summary>
public double? Score { get; set; }
///<summary>
/// 周学时
///</summary>
public int? WeekTime { get; set; }
///<summary>
/// 总学时
///</summary>
public int? TotalTime { get; set; }
///<summary>
/// 课程类型
///</summary>
public string CourseType { get; set; }
///<summary>
/// 备注
///</summary>
public string Note { get; set; }
///<summary>
/// 状态
///</summary>
public string CourseStatus { get; set; }
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

