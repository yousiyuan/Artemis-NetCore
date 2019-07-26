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
/// 试卷内容表
///</summary>
    public class PaperContent
    {
///<summary>
/// 标识列
///</summary>
public long RowKey { get; set; }
///<summary>
/// 试卷内容(xml结构)
///</summary>
public string XmlContent { get; set; }
///<summary>
/// 状态1-有效2-无效3-删除
///</summary>
public string Status { get; set; }
    }
    }

