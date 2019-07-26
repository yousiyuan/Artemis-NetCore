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
/// 题型表
///</summary>
    public class QuestionType
    {
///<summary>
/// 标识列
///</summary>
public long RowKey { get; set; }
///<summary>
/// 题型编号
///</summary>
public string TypeCode { get; set; }
///<summary>
/// 题型名称
///</summary>
public string TypeName { get; set; }
///<summary>
/// 题型英文名称
///</summary>
public string TypeNameEn { get; set; }
///<summary>
/// 排序
///</summary>
public int? Sort { get; set; }
///<summary>
/// 状态1-启用2-禁用3-删除
///</summary>
public string Status { get; set; }
///<summary>
/// 创建时间
///</summary>
public DateTime CreateTime { get; set; }
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

