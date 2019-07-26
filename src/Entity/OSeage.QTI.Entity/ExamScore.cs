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
/// 考试成绩表
///</summary>
    public class ExamScore
    {
///<summary>
/// 考试成绩标识列
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
/// 学科标识
///</summary>
public long CourseKey { get; set; }
///<summary>
/// 考试时间
///</summary>
public DateTime ExamDate { get; set; }
///<summary>
/// 已知得分
///</summary>
public decimal? FloorScore { get; set; }
///<summary>
/// 保留分数
///</summary>
public decimal? UncertainScore { get; set; }
///<summary>
/// 考试成绩
///</summary>
public decimal TotalScore { get; set; }
///<summary>
/// 试卷编号
///</summary>
public long PaperKey { get; set; }
///<summary>
/// 状态1-有效2-无效3-删除
///</summary>
public string Status { get; set; }
///<summary>
/// 创建时间
///</summary>
public DateTime? CreateTime { get; set; }
///<summary>
/// 更新时间
///</summary>
public DateTime? UpdateTime { get; set; }
    }
    }

