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
/// 答卷记录表
///</summary>
    public class ExamRecord
    {
///<summary>
/// 作答批次号
///</summary>
public long RowKey { get; set; }
///<summary>
/// 试卷标识
///</summary>
public long? PaperKey { get; set; }
///<summary>
/// 答卷人标识
///</summary>
public long UserKey { get; set; }
///<summary>
/// 答卷人名称
///</summary>
public string UserName { get; set; }
///<summary>
/// 第几次答卷
///</summary>
public int ExamIndex { get; set; }
///<summary>
/// 验证码
///</summary>
public string VerifyCode { get; set; }
///<summary>
/// 是否迟到1-未迟到2-迟到3-旷考
///</summary>
public string HasLate { get; set; }
///<summary>
/// 迟到时长(单位：秒)
///</summary>
public long? LateTime { get; set; }
///<summary>
/// 考试已用时长(单位：秒)
///</summary>
public long? UsedTime { get; set; }
///<summary>
/// 考试剩余时长(单位：秒)
///</summary>
public long? RestTime { get; set; }
///<summary>
/// 是否中断考试1-未中断2-中断
///</summary>
public string HasBreakOff { get; set; }
///<summary>
/// 中断考试的时间
///</summary>
public DateTime? BreakTime { get; set; }
///<summary>
/// 剩余切屏次数
///</summary>
public int? RestSwitchNum { get; set; }
///<summary>
/// 考试状态1-未开始2-进行中3-已结束
///</summary>
public string ExamStatus { get; set; }
///<summary>
/// 是否有效1-有效2-无效3-删除
///</summary>
public string Status { get; set; }
///<summary>
/// 参加考试时间
///</summary>
public DateTime? CreateTime { get; set; }
///<summary>
/// 最后更新时间
///</summary>
public DateTime? UpdateTime { get; set; }
///<summary>
/// 备注
///</summary>
public string Remark { get; set; }
    }
    }

