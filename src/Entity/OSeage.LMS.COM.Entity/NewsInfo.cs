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
/// 新闻
///</summary>
    public class NewsInfo
    {
///<summary>
/// 表主键，时间戳
///</summary>
public long RowKey { get; set; }
///<summary>
/// title, nvarchar
///</summary>
public string Title { get; set; }
///<summary>
/// publish_time, datetime
///</summary>
public DateTime? PublishTime { get; set; }
///<summary>
/// news_kind, bigint
///</summary>
public long? NewsKind { get; set; }
///<summary>
/// news_type, char
///</summary>
public string NewsType { get; set; }
///<summary>
/// path, nvarchar
///</summary>
public string Path { get; set; }
///<summary>
/// attach_data, nvarchar
///</summary>
public string AttachData { get; set; }
///<summary>
/// flag, varchar
///</summary>
public string Flag { get; set; }
///<summary>
/// 学校名称
///</summary>
public string Content { get; set; }
///<summary>
/// view_count, int
///</summary>
public int? ViewCount { get; set; }
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

