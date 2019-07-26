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
/// 题库表
///</summary>
    public class QuestionBank
    {
///<summary>
/// 主键，自增长，标识列
///</summary>
public long RowKey { get; set; }
///<summary>
/// 题库名称
///</summary>
public string QuestionBankName { get; set; }
///<summary>
/// 1-公共题库2-私有题库
///</summary>
public int QuestionBankType { get; set; }
///<summary>
/// 题库状态1-启用2-禁用3-删除
///</summary>
public string Status { get; set; }
///<summary>
/// 所属用户
///</summary>
public long UserKey { get; set; }
///<summary>
/// 创建时间
///</summary>
public DateTime CreateTime { get; set; }
///<summary>
/// 更新时间
///</summary>
public DateTime UpdateTime { get; set; }
///<summary>
/// 备注
///</summary>
public string Remark { get; set; }
    }
    }

