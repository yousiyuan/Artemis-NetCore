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
/// 标签表
///</summary>
    public class Tag
    {
///<summary>
/// 主键，自增长，标识列
///</summary>
public long RowKey { get; set; }
///<summary>
/// 标签名
///</summary>
public string TagName { get; set; }
///<summary>
/// 标签值
///</summary>
public string TagValue { get; set; }
///<summary>
/// 标签颜色
///</summary>
public string TagColor { get; set; }
///<summary>
/// 创建人
///</summary>
public long? UserKey { get; set; }
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

