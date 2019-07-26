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
/// 培养方案版本管理表
///</summary>
    public class Scheme
    {
///<summary>
/// row_key, bigint
///</summary>
public long RowKey { get; set; }
///<summary>
/// scheme_name, nvarchar
///</summary>
public string SchemeName { get; set; }
///<summary>
/// annual_version, varchar
///</summary>
public string AnnualVersion { get; set; }
///<summary>
/// probationyear_key, bigint
///</summary>
public long? ProbationyearKey { get; set; }
///<summary>
/// 方案状态
///</summary>
public string SchemeStatus { get; set; }
///<summary>
/// remark, varchar
///</summary>
public string Remark { get; set; }
///<summary>
/// using_count, int
///</summary>
public int? UsingCount { get; set; }
///<summary>
/// creator, bigint
///</summary>
public long? Creator { get; set; }
///<summary>
/// create_time, datetime
///</summary>
public DateTime? CreateTime { get; set; }
///<summary>
/// editor, bigint
///</summary>
public long? Editor { get; set; }
///<summary>
/// update_time, datetime
///</summary>
public DateTime? UpdateTime { get; set; }
///<summary>
/// status, bit
///</summary>
public bool? Status { get; set; }
    }
    }

