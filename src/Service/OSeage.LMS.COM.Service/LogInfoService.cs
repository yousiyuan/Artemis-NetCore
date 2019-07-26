//*******************************
// Create By 流年 公子
// Date 2019-07-03 14:02
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Linq;
using OSeage.LMS.COM.Entity;
using OSeage.LMS.COM.Repository;

namespace OSeage.LMS.COM.Service
{
    ///<summary>
/// 操作记录表
///</summary>
    public class LogInfoService
    {
    public ILogInfoRepository LogInfoRepository { get; }

    public LogInfoService (ILogInfoRepository logInfoRepository)
    {
    LogInfoRepository = logInfoRepository;
    }

    public int Insert(LogInfo logInfo)
    {
    return LogInfoRepository.Insert(logInfo);
    }

    public int DeleteById(long id)
    {
    return  LogInfoRepository.DeleteById(id);
    }

    public int Update(LogInfo logInfo)
    {
    return  LogInfoRepository.Update(logInfo);
    }

    }
    }

