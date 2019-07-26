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
/// 试卷与用户关系表
///</summary>
    public class PaperRefUser
    {
///<summary>
/// 标识列
///</summary>
public long RowKey { get; set; }
///<summary>
/// 试卷标识列
///</summary>
public long PaperKey { get; set; }
///<summary>
/// 用户标识列
///</summary>
public long UserKey { get; set; }
///<summary>
/// 用户类型1-参与考试2-参与组卷3-参与批卷4-参与修订5-参与审核
///</summary>
public string UserType { get; set; }
///<summary>
/// 状态1-有效2-无效3-删除
///</summary>
public string Status { get; set; }
    }
    }

