//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:49
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************

using System;
namespace OSeage.QTI.Entity
{

    ///<summary>
/// View, v_question_tag_list
///</summary>
    public class QuestionTagList
    {
///<summary>
/// row_key, bigint
///</summary>
public long RowKey { get; set; }
///<summary>
/// tag_name, nvarchar
///</summary>
public string TagName { get; set; }
///<summary>
/// tag_value, nvarchar
///</summary>
public string TagValue { get; set; }
///<summary>
/// tag_color, nvarchar
///</summary>
public string TagColor { get; set; }
///<summary>
/// user_key, bigint
///</summary>
public long? UserKey { get; set; }
///<summary>
/// status, char
///</summary>
public string Status { get; set; }
///<summary>
/// create_time, datetime
///</summary>
public DateTime CreateTime { get; set; }
///<summary>
/// update_time, datetime
///</summary>
public DateTime UpdateTime { get; set; }
///<summary>
/// remark, nvarchar
///</summary>
public string Remark { get; set; }
///<summary>
/// question_count, int
///</summary>
public int? QuestionCount { get; set; }
    }
    }

