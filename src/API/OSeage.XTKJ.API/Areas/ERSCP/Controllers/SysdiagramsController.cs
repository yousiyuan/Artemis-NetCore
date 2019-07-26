//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:57
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OSeage.LMS.ERSCP.Entity;
using OSeage.LMS.ERSCP.Repository;
using OSeage.LMS.ERSCP.Service;
using OSeage.XTKJ.API.Message;

namespace OSeage.XTKJ.API.Areas.ERSCP.Controllers
{
    ///<summary>
/// Table, sysdiagrams
///</summary>
    [ApiController]
    [Route("erscp/[controller]/[action]")]
    public class SysdiagramsController : Controller
    {
    public SysdiagramsService SysdiagramsService { get; }
    public ISysdiagramsRepository SysdiagramsRepository { get; }
    public SysdiagramsController(SysdiagramsService sysdiagramsService,ISysdiagramsRepository sysdiagramsRepository)
    {
    SysdiagramsService = sysdiagramsService;
    SysdiagramsRepository = sysdiagramsRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<string> Insert([FromBody]Sysdiagrams sysdiagrams)
    {
    return new ResponseMessageWrap<string>
    {
    Body = SysdiagramsService.Insert(sysdiagrams)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(string id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SysdiagramsService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]Sysdiagrams sysdiagrams)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SysdiagramsService.Update(sysdiagrams)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<Sysdiagrams> GetById(string id)
    {
    var sysdiagrams = SysdiagramsRepository.GetById(id);
    return new ResponseMessageWrap<Sysdiagrams>
    {
    Body = sysdiagrams
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<Sysdiagrams>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = SysdiagramsRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<Sysdiagrams>>
    {
    Body = new QueryResponse<Sysdiagrams>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<Sysdiagrams>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = SysdiagramsRepository.GetRecord(reqMsg);
    var list = SysdiagramsRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<Sysdiagrams>>
    {
    Body = new QueryByPageResponse<Sysdiagrams>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

