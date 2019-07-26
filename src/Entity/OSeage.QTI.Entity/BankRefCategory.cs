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
/// 题库与类别关系表
///</summary>
    public class BankRefCategory
    {
///<summary>
/// 主键,自增长,标识列
///</summary>
public long CategoryKey { get; set; }
///<summary>
/// 主键，自增长，标识列
///</summary>
public long QuestionBankKey { get; set; }
///<summary>
/// 状态1-启用2-禁用3-删除
///</summary>
public string Status { get; set; }
    }
    }

