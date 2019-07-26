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
/// 答题答案表
///</summary>
    public class QuestionAnswerItem
    {
///<summary>
/// 标识列
///</summary>
public long RowKey { get; set; }
///<summary>
/// 预览记录Key
///</summary>
public long? PreviewKey { get; set; }
///<summary>
/// 试题标识列
///</summary>
public long? QuestionKey { get; set; }
///<summary>
/// 答题记录Key
///</summary>
public long? AnswerKey { get; set; }
///<summary>
/// 答题编号，如拖放题对应的盒子
///</summary>
public string Code { get; set; }
///<summary>
/// 答案
///</summary>
public string Answer { get; set; }
///<summary>
/// 是否正确
///</summary>
public bool? IsRight { get; set; }
///<summary>
/// 单位
///</summary>
public string Unit { get; set; }
///<summary>
/// 单位乘数
///</summary>
public decimal? UnitNultiplier { get; set; }
///<summary>
/// 得分
///</summary>
public decimal? Score { get; set; }
///<summary>
/// 错误被罚分
///</summary>
public decimal? Penalty { get; set; }
///<summary>
/// 答题者
///</summary>
public long? UserKey { get; set; }
    }
    }

