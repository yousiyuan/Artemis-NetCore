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
/// 课程信息表
///</summary>
    public class CourseInfo
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 课程Id
///</summary>
public long? BaseCourseKey { get; set; }
///<summary>
/// 培养方案Id
///</summary>
public long? SchemeKey { get; set; }
///<summary>
/// 课程体系Id
///</summary>
public long? CourseManageKey { get; set; }
///<summary>
/// 课程组Id
///</summary>
public long? CourseGroupKey { get; set; }
///<summary>
/// 学分
///</summary>
public int? CourseScore { get; set; }
///<summary>
/// 课程总学时
///</summary>
public int? CourseTime { get; set; }
///<summary>
/// 课程周学时
///</summary>
public int? CourseWeekTime { get; set; }
///<summary>
/// 开课单位
///</summary>
public long? CollegeKey { get; set; }
///<summary>
/// 课程类型（0：未知，1：必修，2：选修）
///</summary>
public string CourseType { get; set; }
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

