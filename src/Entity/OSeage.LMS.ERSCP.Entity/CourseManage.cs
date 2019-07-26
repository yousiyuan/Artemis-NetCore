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
/// 课程体系管理表
///</summary>
    public class CourseManage
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 课程体系名称
///</summary>
public string CourseSetupName { get; set; }
///<summary>
/// 培养方案Id
///</summary>
public long? SchemeKey { get; set; }
///<summary>
/// 学分要求
///</summary>
public int? Credit { get; set; }
///<summary>
/// 学分要求
///</summary>
public int? CourseSetupScore { get; set; }
///<summary>
/// 课程性质（0、未知 1、必修 2、选修）
///</summary>
public string CourseNature { get; set; }
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

