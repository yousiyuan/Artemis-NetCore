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
/// 课程章节表
///</summary>
    public class CourseModel
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 所属课程key
///</summary>
public long? CourseKey { get; set; }
///<summary>
/// 章节名称
///</summary>
public string Name { get; set; }
///<summary>
/// 所属章
///</summary>
public long? ParentKey { get; set; }
///<summary>
/// 开始时间
///</summary>
public DateTime? BeginTime { get; set; }
///<summary>
/// 结束时间
///</summary>
public DateTime? EndTime { get; set; }
///<summary>
/// 视频key
///</summary>
public long? VideoKey { get; set; }
///<summary>
/// 文档key
///</summary>
public long? DocKey { get; set; }
///<summary>
/// 排序
///</summary>
public int? Sort { get; set; }
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

