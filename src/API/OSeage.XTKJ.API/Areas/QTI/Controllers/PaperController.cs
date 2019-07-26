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
/// 试卷表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class PaperController : Controller
    {
    public PaperService PaperService { get; }
    public IPaperRepository PaperRepository { get; }
    public PaperController(PaperService paperService,IPaperRepository paperRepository)
    {
    PaperService = paperService;
    PaperRepository = paperRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]Paper paper)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperService.Insert(paper)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]Paper paper)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperService.Update(paper)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<Paper> GetById(long id)
    {
    var paper = PaperRepository.GetById(id);
    return new ResponseMessageWrap<Paper>
    {
    Body = paper
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<Paper>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = PaperRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<Paper>>
    {
    Body = new QueryResponse<Paper>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<Paper>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = PaperRepository.GetRecord(reqMsg);
    var list = PaperRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<Paper>>
    {
    Body = new QueryByPageResponse<Paper>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

