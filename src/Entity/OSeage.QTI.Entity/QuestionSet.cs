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
    public class QuestionSet
    {
///<summary>
/// 所属人
///</summary>
public long UserKey { get; set; }
///<summary>
/// 题目行为
///</summary>
public string Behavior { get; set; }
///<summary>
/// 是否正确
///</summary>
public string IsYes { get; set; }
///<summary>
/// 得分
///</summary>
public string ScoreDisplay { get; set; }
///<summary>
/// 成绩中小数点后位数
///</summary>
public string ScoreFraction { get; set; }
///<summary>
/// 特殊反馈
///</summary>
public string SpecialFeedback { get; set; }
///<summary>
/// 通用反馈
///</summary>
public string GeneralFeedback { get; set; }
///<summary>
/// 标准答案
///</summary>
public string IsAnswer { get; set; }
///<summary>
/// 答题历史
///</summary>
public string AnswerHistory { get; set; }
    }
    }

