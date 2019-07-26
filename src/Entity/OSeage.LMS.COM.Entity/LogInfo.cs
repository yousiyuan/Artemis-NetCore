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
/// 操作记录表
///</summary>
    public class LogInfo
    {
///<summary>
/// 主键
///</summary>
public long RowKey { get; set; }
///<summary>
/// 是否是敏感操作
///</summary>
public bool? IsSensitive { get; set; }
///<summary>
/// 浏览器
///</summary>
public string Browser { get; set; }
///<summary>
/// 服务名称（对应的后台代码位置）
///</summary>
public string ServiceName { get; set; }
///<summary>
/// 模块名称
///</summary>
public string Modle { get; set; }
///<summary>
/// 操作
///</summary>
public string Operation { get; set; }
///<summary>
/// 持续时间
///</summary>
public string During { get; set; }
///<summary>
/// ip地址
///</summary>
public string Ip { get; set; }
///<summary>
/// 用户key
///</summary>
public long? UserKey { get; set; }
///<summary>
/// 客户端类型
///</summary>
public string Client { get; set; }
///<summary>
/// 描述
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

