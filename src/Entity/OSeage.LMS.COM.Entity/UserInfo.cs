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
/// 用户信息表
///</summary>
    public class UserInfo
    {
///<summary>
/// 用户Key
///</summary>
public long? UserKey { get; set; }
///<summary>
/// 学号
///</summary>
public string IdNumber { get; set; }
///<summary>
/// 所属学院
///</summary>
public long? CollegeKey { get; set; }
///<summary>
/// 所属专业
///</summary>
public long? SpecialtyKey { get; set; }
///<summary>
/// 所属班级
///</summary>
public long? ClassKey { get; set; }
///<summary>
/// 入学年份
///</summary>
public string SchoolYear { get; set; }
///<summary>
/// 讲师类别
///</summary>
public string LecturerType { get; set; }
///<summary>
/// 电话
///</summary>
public string Phone { get; set; }
///<summary>
/// 用户头像
///</summary>
public string UserIcon { get; set; }
///<summary>
/// 姓
///</summary>
public string Surname { get; set; }
///<summary>
/// 中间名字
///</summary>
public string MiddleName { get; set; }
///<summary>
/// 名
///</summary>
public string FirstName { get; set; }
///<summary>
/// 显示名
///</summary>
public string DisplayName { get; set; }
///<summary>
/// 性别
///</summary>
public string Gender { get; set; }
///<summary>
/// 生日
///</summary>
public string Birthday { get; set; }
///<summary>
/// 城镇
///    
///</summary>
public string Town { get; set; }
///<summary>
/// 区域
///</summary>
public string District { get; set; }
///<summary>
/// 自述
///</summary>
public string Abstract { get; set; }
///<summary>
/// 扩展字段1
///</summary>
public string Column1 { get; set; }
///<summary>
/// 扩展字段2
///</summary>
public string Column2 { get; set; }
///<summary>
/// 扩展字段3
///</summary>
public string Column3 { get; set; }
///<summary>
/// 扩展字段4
///</summary>
public string Column4 { get; set; }
///<summary>
/// 扩展字段5
///</summary>
public string Column5 { get; set; }
///<summary>
/// 扩展字段6
///</summary>
public string Column6 { get; set; }
///<summary>
/// 扩展字段7
///</summary>
public string Column7 { get; set; }
///<summary>
/// 扩展字段8
///</summary>
public string Column8 { get; set; }
///<summary>
/// 扩展字段9
///</summary>
public string Column9 { get; set; }
///<summary>
/// 扩展字段10
///</summary>
public string Column10 { get; set; }
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

