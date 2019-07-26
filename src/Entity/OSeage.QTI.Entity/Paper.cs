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
/// 试卷表
///</summary>
    public class Paper
    {
///<summary>
/// 标识列
///</summary>
public long RowKey { get; set; }
///<summary>
/// 考试标题
///</summary>
public string Title { get; set; }
///<summary>
/// 套卷标识A-A卷B-B卷
///</summary>
public string SuitTitle { get; set; }
///<summary>
/// 组卷批次号，自动组卷的两套试卷具有相同的值
///</summary>
public string ComposeSn { get; set; }
///<summary>
/// 试卷类型1-模拟考试2-测试考试3-期末考试
///</summary>
public string TestType { get; set; }
///<summary>
/// 课程标识
///</summary>
public long? CourseKey { get; set; }
///<summary>
/// 课程名称
///</summary>
public string CourseName { get; set; }
///<summary>
/// 试卷内容标识
///</summary>
public long? PaperContentKey { get; set; }
///<summary>
/// 答卷须知
///</summary>
public string Notice { get; set; }
///<summary>
/// 试卷描述
///</summary>
public string Description { get; set; }
///<summary>
/// 考试时间选项1-固定时间2-不限时间
///</summary>
public string ExamTimeType { get; set; }
///<summary>
/// 考试时长(单位:分钟)
///</summary>
public int? ExamTimeSpan { get; set; }
///<summary>
/// 迟到时长(单位:分钟)
///</summary>
public int? LateTimeLimit { get; set; }
///<summary>
/// 考试开始时间
///</summary>
public DateTime? StartTime { get; set; }
///<summary>
/// 考试结束时间
///</summary>
public DateTime? EndTime { get; set; }
///<summary>
/// 试题随机排序1-支持2-不支持
///</summary>
public string HasSortRandom { get; set; }
///<summary>
/// 是否允许重复考试1-是2-否
///</summary>
public int? IsRepeat { get; set; }
///<summary>
/// 允许重复考试次数
///</summary>
public int? RepeatNum { get; set; }
///<summary>
/// 是否允许考试切屏1-是2-否
///</summary>
public int? IsSwitch { get; set; }
///<summary>
/// 切屏次数
///</summary>
public int? SwitchNum { get; set; }
///<summary>
/// 是否自动组卷1-是2-否
///</summary>
public string AutoCompose { get; set; }
///<summary>
/// 是否允许多次尝试1-是2-否
///</summary>
public int? IsTry { get; set; }
///<summary>
/// 尝试次数
///</summary>
public int? TryNum { get; set; }
///<summary>
/// 每页显示试题数量
///</summary>
public int? DisplayNum { get; set; }
///<summary>
/// 封面图片路径
///</summary>
public string CoverImgSrc { get; set; }
///<summary>
/// 试卷总分数
///</summary>
public int? PaperTotalScore { get; set; }
///<summary>
/// 及格分数
///</summary>
public int? PassScore { get; set; }
///<summary>
/// 是否设置答卷口令1-是2-否
///</summary>
public int? IsSetToken { get; set; }
///<summary>
/// 是否显示正确答案1-是2-否
///</summary>
public int? IsShowAnswer { get; set; }
///<summary>
/// 审批状态1-未审批2-审批通过3-审批不通过
///</summary>
public string ApproveStatus { get; set; }
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
///<summary>
/// 备注
///</summary>
public string Remark { get; set; }
    }
    }

