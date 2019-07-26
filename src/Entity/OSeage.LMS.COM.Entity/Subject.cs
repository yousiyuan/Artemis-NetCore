//*******************************
// Create By 流年 公子
// Date 2019-07-03 14:02
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************

using System;
namespace OSeage.LMS.COM.Entity
{

    ///<summary>
/// 学科表
///</summary>
    public class Subject
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 学科名称
///</summary>
public string SubjectName { get; set; }
///<summary>
/// 学科编码
///</summary>
public string SubjectCode { get; set; }
///<summary>
/// 描述
///</summary>
public string SubjectNote { get; set; }
///<summary>
/// 父学科Key
///</summary>
public long? ParentKey { get; set; }
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
///<summary>
/// 所属学校
///</summary>
public long? SchoolKey { get; set; }
    }
    }

