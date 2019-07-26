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
/// 试题与知识点关系表
///</summary>
    public class QuestionRefKnowledge
    {
///<summary>
/// 考试题标识列
///</summary>
public long QuestionKey { get; set; }
///<summary>
/// 知识点标识列
///</summary>
public long? KnowledgeKey { get; set; }
///<summary>
/// 排序
///</summary>
public int Sort { get; set; }
///<summary>
/// 状态:1-有效2-无效3-删除
///</summary>
public string Status { get; set; }
    }
    }

