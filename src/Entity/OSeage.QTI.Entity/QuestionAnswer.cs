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
/// 答题记录表
///</summary>
    public class QuestionAnswer
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
/// 预览标识key
///</summary>
public long? PreviewKey { get; set; }
///<summary>
/// 正确答案
///</summary>
public string CorrectAnswer { get; set; }
///<summary>
/// 步骤
///</summary>
public int? Step { get; set; }
///<summary>
/// 答题时间
///</summary>
public DateTime? AnswerTime { get; set; }
///<summary>
/// 答题动作，1开始，2提交
///</summary>
public string AnswerAction { get; set; }
///<summary>
/// 答案内容
///</summary>
public string AnswerText { get; set; }
///<summary>
/// 状态，1未完成，2还可尝试，3完成
///</summary>
public string AnswerStatus { get; set; }
///<summary>
/// 结果：1正确，2部分正确，3错误
///</summary>
public string AnswerResult { get; set; }
///<summary>
/// 通用答案反馈提示
///</summary>
public string GeneralTip { get; set; }
///<summary>
/// 答案反馈提示
///</summary>
public string AnswerTip { get; set; }
///<summary>
/// 还可尝试次数
///</summary>
public int? TryCount { get; set; }
///<summary>
/// 得分
///</summary>
public decimal? Score { get; set; }
///<summary>
/// 答题者
///</summary>
public long? UserKey { get; set; }
    }
    }

