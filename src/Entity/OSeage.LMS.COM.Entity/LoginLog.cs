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
/// 登录记录表
///</summary>
    public class LoginLog
    {
///<summary>
/// 主键
///</summary>
public long RowKey { get; set; }
///<summary>
/// 登录方式
///</summary>
public string LoginType { get; set; }
///<summary>
/// 登录人key
///</summary>
public long? UserKey { get; set; }
///<summary>
/// 登录名
///</summary>
public string LoginName { get; set; }
///<summary>
/// 登录人角色
///</summary>
public string Role { get; set; }
///<summary>
/// 登录平台
///</summary>
public string Platform { get; set; }
///<summary>
/// 客户端类型
///</summary>
public string Client { get; set; }
///<summary>
/// 浏览器
///</summary>
public string Browser { get; set; }
///<summary>
/// 登录时间
///</summary>
public DateTime? LoginTime { get; set; }
///<summary>
/// 登出时间
///</summary>
public DateTime? LogoutTime { get; set; }
///<summary>
/// ip地址
///</summary>
public string Ip { get; set; }
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

