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
/// 物理文件
///</summary>
    public class PhysicalFile
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// 名称
///</summary>
public string Name { get; set; }
///<summary>
/// 文件扩展名
///</summary>
public string Extension { get; set; }
///<summary>
/// 大小
///</summary>
public long? Size { get; set; }
///<summary>
/// 路径
///</summary>
public string Path { get; set; }
///<summary>
/// 转换状态
///</summary>
public string Conversion { get; set; }
///<summary>
/// 扩展字段
///</summary>
public string AttachData { get; set; }
///<summary>
/// 下载次数
///</summary>
public int? DownCount { get; set; }
///<summary>
/// 文件分类：0文档新闻、1新闻附件
///</summary>
public string Kind { get; set; }
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

