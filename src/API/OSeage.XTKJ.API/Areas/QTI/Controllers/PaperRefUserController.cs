//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:49
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OSeage.QTI.Entity;
using OSeage.QTI.Repository;
using OSeage.QTI.Service;
using OSeage.XTKJ.API.Message;

namespace OSeage.XTKJ.API.Areas.QTI.Controllers
{
    ///<summary>
/// 试卷与用户关系表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class PaperRefUserController : Controller
    {
    public PaperRefUserService PaperRefUserService { get; }
    public IPaperRefUserRepository PaperRefUserRepository { get; }
    public PaperRefUserController(PaperRefUserService paperRefUserService,IPaperRefUserRepository paperRefUserRepository)
    {
    PaperRefUserService = paperRefUserService;
    PaperRefUserRepository = paperRefUserRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]PaperRefUser paperRefUser)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperRefUserService.Insert(paperRefUser)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperRefUserService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]PaperRefUser paperRefUser)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperRefUserService.Update(paperRefUser)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<PaperRefUser> GetById(long id)
    {
    var paperRefUser = PaperRefUserRepository.GetById(id);
    return new ResponseMessageWrap<PaperRefUser>
    {
    Body = paperRefUser
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<PaperRefUser>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = PaperRefUserRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<PaperRefUser>>
    {
    Body = new QueryResponse<PaperRefUser>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<PaperRefUser>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = PaperRefUserRepository.GetRecord(reqMsg);
    var list = PaperRefUserRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<PaperRefUser>>
    {
    Body = new QueryByPageResponse<PaperRefUser>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

