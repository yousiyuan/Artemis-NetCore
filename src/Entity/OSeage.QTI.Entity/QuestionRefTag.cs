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
/// 试题与标签关系表
///</summary>
    public class QuestionRefTag
    {
///<summary>
/// 标签标识列
///</summary>
public long TagKey { get; set; }
///<summary>
/// 试题标识列
///</summary>
public long QuestionKey { get; set; }
///<summary>
/// 状态1-启用2-禁用3-删除
///</summary>
public string Status { get; set; }
    }
    }

