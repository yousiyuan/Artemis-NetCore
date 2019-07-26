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
/// 开课计划讲师表
///</summary>
    public class CoursePlanLecturer
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 开课计划key
///</summary>
public long? CoursePlanKey { get; set; }
///<summary>
/// 教学计划信息key
///</summary>
public long? TeachingInfoKey { get; set; }
///<summary>
/// 班级key
///</summary>
public long? ClassKey { get; set; }
///<summary>
/// 讲师key
///</summary>
public long? LecturerKey { get; set; }
///<summary>
/// 学年学期
///</summary>
public string Semester { get; set; }
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

