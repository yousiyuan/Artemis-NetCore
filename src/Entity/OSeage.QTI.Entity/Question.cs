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
/// 考试题
///</summary>
    public class Question
    {
///<summary>
/// 标识列
///</summary>
public long RowKey { get; set; }
///<summary>
/// 试题名称
///</summary>
public string Title { get; set; }
///<summary>
/// 题干
///</summary>
public string QuestionStem { get; set; }
///<summary>
/// 所属课程
///</summary>
public long CourseKey { get; set; }
///<summary>
/// 课程名称
///</summary>
public string CourseName { get; set; }
///<summary>
/// 所在题库
///</summary>
public long QuestionBankKey { get; set; }
///<summary>
/// 试题分类
///</summary>
public long? QuestionCategoryKey { get; set; }
///<summary>
/// 题型
///</summary>
public long? QuestionTypeKey { get; set; }
///<summary>
/// 选项随机排序1-支持2-不支持
///</summary>
public string HasSortRandom { get; set; }
///<summary>
/// 考试题内容
///</summary>
public long? ContentKey { get; set; }
///<summary>
/// 难度
///</summary>
public int DifficultyLevel { get; set; }
///<summary>
/// 状态1-启用2-禁用3-删除
///</summary>
public string Status { get; set; }
///<summary>
/// 创建人
///</summary>
public long? CreateBy { get; set; }
///<summary>
/// 创建人姓名
///</summary>
public string CreateName { get; set; }
///<summary>
/// 创建时间
///</summary>
public DateTime CreateTime { get; set; }
///<summary>
/// 所属人
///</summary>
public long OwnerId { get; set; }
///<summary>
/// 所属人姓名
///</summary>
public string OwnerName { get; set; }
///<summary>
/// 修改时间
///</summary>
public DateTime UpdateTime { get; set; }
///<summary>
/// 备注
///</summary>
public string Remark { get; set; }
    }
    }

