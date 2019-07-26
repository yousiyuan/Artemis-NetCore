//*******************************
// Create By 流年 公子
// Date 2019-07-03 14:02
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OSeage.LMS.COM.Entity;
using OSeage.LMS.COM.Repository;
using OSeage.LMS.COM.Service;
using OSeage.XTKJ.API.Message;

namespace OSeage.XTKJ.API.Areas.COM.Controllers
{
    ///<summary>
/// 操作记录表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class LogInfoController : Controller
    {
    public LogInfoService LogInfoService { get; }
    public ILogInfoRepository LogInfoRepository { get; }
    public LogInfoController(LogInfoService logInfoService,ILogInfoRepository logInfoRepository)
    {
    LogInfoService = logInfoService;
    LogInfoRepository = logInfoRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]LogInfo logInfo)
    {
    return new ResponseMessageWrap<int>
    {
    Body = LogInfoService.Insert(logInfo)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = LogInfoService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]LogInfo logInfo)
    {
    return new ResponseMessageWrap<int>
    {
    Body = LogInfoService.Update(logInfo)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<LogInfo> GetById(long id)
    {
    var logInfo = LogInfoRepository.GetById(id);
    return new ResponseMessageWrap<LogInfo>
    {
    Body = logInfo
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<LogInfo>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = LogInfoRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<LogInfo>>
    {
    Body = new QueryResponse<LogInfo>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<LogInfo>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = LogInfoRepository.GetRecord(reqMsg);
    var list = LogInfoRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<LogInfo>>
    {
    Body = new QueryByPageResponse<LogInfo>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

