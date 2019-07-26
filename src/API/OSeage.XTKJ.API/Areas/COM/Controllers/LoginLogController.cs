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
/// 登录记录表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class LoginLogController : Controller
    {
    public LoginLogService LoginLogService { get; }
    public ILoginLogRepository LoginLogRepository { get; }
    public LoginLogController(LoginLogService loginLogService,ILoginLogRepository loginLogRepository)
    {
    LoginLogService = loginLogService;
    LoginLogRepository = loginLogRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]LoginLog loginLog)
    {
    return new ResponseMessageWrap<int>
    {
    Body = LoginLogService.Insert(loginLog)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = LoginLogService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]LoginLog loginLog)
    {
    return new ResponseMessageWrap<int>
    {
    Body = LoginLogService.Update(loginLog)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<LoginLog> GetById(long id)
    {
    var loginLog = LoginLogRepository.GetById(id);
    return new ResponseMessageWrap<LoginLog>
    {
    Body = loginLog
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<LoginLog>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = LoginLogRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<LoginLog>>
    {
    Body = new QueryResponse<LoginLog>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<LoginLog>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = LoginLogRepository.GetRecord(reqMsg);
    var list = LoginLogRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<LoginLog>>
    {
    Body = new QueryByPageResponse<LoginLog>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

