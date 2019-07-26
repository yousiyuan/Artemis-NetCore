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
/// 考试答案记录表
///</summary>
    public class PaperAnswer
    {
///<summary>
/// 标识列
///</summary>
public long RowKey { get; set; }
///<summary>
/// 作答批次号
///</summary>
public long? AnswerSn { get; set; }
///<summary>
/// 答卷人标识
///</summary>
public long UserKey { get; set; }
///<summary>
/// 试卷标识
///</summary>
public long? PaperKey { get; set; }
///<summary>
/// 试题标识
///</summary>
public long QuestionKey { get; set; }
///<summary>
/// 题型
///</summary>
public string QuestionType { get; set; }
///<summary>
/// 试题答案
///</summary>
public string AnswerConent { get; set; }
///<summary>
/// 试题总分
///</summary>
public decimal? QuestionScore { get; set; }
///<summary>
/// 试题评分
///</summary>
public decimal RealScore { get; set; }
///<summary>
/// 老师阅卷时的评语
///</summary>
public string Critique { get; set; }
///<summary>
/// 答题状态1-已回答2-未回答
///</summary>
public string AnswerStatus { get; set; }
///<summary>
/// 试题标记状态1-已标记2-未标记
///</summary>
public string MarkStatus { get; set; }
///<summary>
/// 提交时间
///</summary>
public DateTime? CreateTime { get; set; }
///<summary>
/// 修改时间
///</summary>
public DateTime? UpdateTime { get; set; }
///<summary>
/// 状态1-启用2-禁用3-删除
///</summary>
public string Status { get; set; }
///<summary>
/// 备注
///</summary>
public string Remark { get; set; }
    }
    }

