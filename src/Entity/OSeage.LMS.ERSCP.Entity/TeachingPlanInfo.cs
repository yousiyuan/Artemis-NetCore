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
/// 教学计划表详情
///</summary>
    public class TeachingPlanInfo
    {
///<summary>
/// row_key, bigint
///</summary>
public long RowKey { get; set; }
///<summary>
/// 教学计划主表
///</summary>
public long? TeachingPlanKey { get; set; }
///<summary>
/// 上课院系id
///</summary>
public long? CollegeKey { get; set; }
///<summary>
/// 上课年级id
///</summary>
public long? YearSpecialtyKey { get; set; }
///<summary>
/// 上课专业id
///</summary>
public long? SpecialtyKey { get; set; }
///<summary>
/// 课程id
///</summary>
public long? CourseInfoKey { get; set; }
///<summary>
/// 类型：0默认，1追加，2覆盖
///</summary>
public string PlanType { get; set; }
///<summary>
/// 学时学期key
///</summary>
public long? CourseSemesterHoursKey { get; set; }
///<summary>
/// 开课学期
///</summary>
public string Semester { get; set; }
///<summary>
/// creator, bigint
///</summary>
public long? Creator { get; set; }
///<summary>
/// create_time, datetime
///</summary>
public DateTime? CreateTime { get; set; }
///<summary>
/// editor, bigint
///</summary>
public long? Editor { get; set; }
///<summary>
/// update_time, datetime
///</summary>
public DateTime? UpdateTime { get; set; }
///<summary>
/// status, bit
///</summary>
public bool? Status { get; set; }
    }
    }

