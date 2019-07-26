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
/// Table, tbl_course_group_info
///</summary>
    public class CourseGroupInfo
    {
///<summary>
/// row_key, bigint
///</summary>
public long RowKey { get; set; }
///<summary>
/// 课程体系id
///</summary>
public long? CourseManageKey { get; set; }
///<summary>
/// 课程组名称
///</summary>
public string CoursGroupName { get; set; }
///<summary>
/// 所属学科
///</summary>
public long? SubjectKey { get; set; }
///<summary>
/// 备注
///</summary>
public string Remark { get; set; }
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

