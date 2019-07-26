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
/// 类别表
///</summary>
    public class Category
    {
///<summary>
/// 主键,自增长,标识列
///</summary>
public long RowKey { get; set; }
///<summary>
/// 当前分类下所有的子分类标识
///</summary>
public string CategoryKeyNodes { get; set; }
///<summary>
/// 类别名称
///</summary>
public string CategoryName { get; set; }
///<summary>
/// 类别名称路径
///</summary>
public string CategoryNamePath { get; set; }
///<summary>
/// 类别层级
///</summary>
public int? CategoryLevel { get; set; }
///<summary>
/// 上级类别标识
///</summary>
public long ParentKey { get; set; }
///<summary>
/// 状态1-启用2-禁用3-删除
///</summary>
public string Status { get; set; }
///<summary>
/// 所属人
///</summary>
public long UserKey { get; set; }
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

