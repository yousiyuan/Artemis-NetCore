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
/// 专业培养方案表
///</summary>
    public class MajorTrainScheme
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 方案Id
///</summary>
public long? SchemeKey { get; set; }
///<summary>
/// year, varchar
///</summary>
public string Year { get; set; }
///<summary>
/// 单位Id（上课单位）
///</summary>
public long? CollegeKey { get; set; }
///<summary>
/// 专业Id
///</summary>
public long? SpecialtyKey { get; set; }
///<summary>
/// 课程总学分
///</summary>
public int? TotalSocre { get; set; }
///<summary>
/// 备注
///</summary>
public string Remark { get; set; }
///<summary>
/// 方案状态
///</summary>
public string SchemeStatus { get; set; }
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

