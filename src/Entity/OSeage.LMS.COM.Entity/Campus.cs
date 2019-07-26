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
/// 校区表
///</summary>
    public class Campus
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 编号
///</summary>
public string CampusNumber { get; set; }
///<summary>
/// 学校名称
///</summary>
public string CampusName { get; set; }
///<summary>
/// 所属学校
///</summary>
public long? SchoolKey { get; set; }
///<summary>
/// 状态
///</summary>
public string CampusStatus { get; set; }
///<summary>
/// 负责人
///</summary>
public string CampusPrincipal { get; set; }
///<summary>
/// 地址
///</summary>
public string CampusAddress { get; set; }
///<summary>
/// 描述
///</summary>
public string CampusNote { get; set; }
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

