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
/// 课程学时学期表
///</summary>
    public class CourseSemesterHours
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 课程Id
///</summary>
public long? CourseKey { get; set; }
///<summary>
/// semester_number, int
///</summary>
public int? SemesterNumber { get; set; }
///<summary>
/// 学期学时
///</summary>
public int? SemesterTime { get; set; }
///<summary>
/// 单位（学时、周）
///</summary>
public int? Unit { get; set; }
///<summary>
/// 是否开课
///</summary>
public string IsOpenCourse { get; set; }
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

