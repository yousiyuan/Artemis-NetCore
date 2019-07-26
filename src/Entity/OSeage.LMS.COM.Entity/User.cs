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
/// 用户表
///</summary>
    public class User
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 用户登录名
///</summary>
public string LoginName { get; set; }
///<summary>
/// 密码
///</summary>
public string Password { get; set; }
///<summary>
/// 邮箱
///</summary>
public string Email { get; set; }
///<summary>
/// 手机
///</summary>
public string Moblie { get; set; }
///<summary>
/// 有效期
///</summary>
public string ValidityDate { get; set; }
///<summary>
/// 是否已改过密码
///</summary>
public bool? ChangedPwd { get; set; }
///<summary>
/// 密码输入错误次数
///</summary>
public int? PwdErrNum { get; set; }
///<summary>
/// 是否被锁
///</summary>
public bool? Locked { get; set; }
///<summary>
/// 解锁时的防伪参数
///</summary>
public long? UnlockKey { get; set; }
///<summary>
/// 登陆状态
///</summary>
public string LoginStatus { get; set; }
///<summary>
/// 登录信息的token
///</summary>
public string Token { get; set; }
///<summary>
/// language, char
///</summary>
public string Language { get; set; }
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

