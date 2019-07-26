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
/// 试题预览记录表
///</summary>
    public class QuestionPreview
    {
///<summary>
/// 标识列
///</summary>
public long RowKey { get; set; }
///<summary>
/// 试题标识列
///</summary>
public long? QuestionKey { get; set; }
///<summary>
/// 题目行为
///</summary>
public string Behavior { get; set; }
///<summary>
/// 满分
///</summary>
public decimal? TotalScore { get; set; }
///<summary>
/// 得分
///</summary>
public decimal? Score { get; set; }
///<summary>
/// 剩余尝试次数
///</summary>
public int? TryCount { get; set; }
///<summary>
/// 状态，1正确，2部分正确，3错误
///</summary>
public string AnswerStatus { get; set; }
///<summary>
/// 答题者
///</summary>
public long? UserKey { get; set; }
    }
    }

