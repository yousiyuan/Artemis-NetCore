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
/// 试卷与考试题关系表
///</summary>
    public class PaperRefQuestion
    {
///<summary>
/// 考试题记录标识列
///</summary>
public long RowKey { get; set; }
///<summary>
/// 试卷标识列
///</summary>
public long PaperKey { get; set; }
///<summary>
/// 考试题标识列
///</summary>
public long QuestionKey { get; set; }
///<summary>
/// 考试题内容
///</summary>
public string QuestionContent { get; set; }
///<summary>
/// 考试题排序
///</summary>
public int? Sort { get; set; }
///<summary>
/// 状态1-显示2-隐藏3-删除
///</summary>
public string Status { get; set; }
    }
    }

