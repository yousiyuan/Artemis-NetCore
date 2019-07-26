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
/// 学年学期表
///</summary>
    public class SchoolYear
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 开始年度
///</summary>
public string BeginYear { get; set; }
///<summary>
/// 结束年度
///</summary>
public string EndYear { get; set; }
///<summary>
/// 年度学期
///</summary>
public string Semester { get; set; }
///<summary>
/// 学期名称
///</summary>
public string Name { get; set; }
///<summary>
/// 开始上课周
///</summary>
public int? BeginWeek { get; set; }
///<summary>
/// 终止上课周
///</summary>
public int? EndWeek { get; set; }
///<summary>
/// 学期开始时间
///</summary>
public string BeginTime { get; set; }
///<summary>
/// 学期终止时间
///</summary>
public string EndTime { get; set; }
///<summary>
/// 是否当前学期
///</summary>
public bool? IsNow { get; set; }
///<summary>
/// 备注
///</summary>
public string Note { get; set; }
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

