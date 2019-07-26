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
/// 考试答案记录表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class PaperAnswerController : Controller
    {
    public PaperAnswerService PaperAnswerService { get; }
    public IPaperAnswerRepository PaperAnswerRepository { get; }
    public PaperAnswerController(PaperAnswerService paperAnswerService,IPaperAnswerRepository paperAnswerRepository)
    {
    PaperAnswerService = paperAnswerService;
    PaperAnswerRepository = paperAnswerRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]PaperAnswer paperAnswer)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperAnswerService.Insert(paperAnswer)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperAnswerService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]PaperAnswer paperAnswer)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperAnswerService.Update(paperAnswer)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<PaperAnswer> GetById(long id)
    {
    var paperAnswer = PaperAnswerRepository.GetById(id);
    return new ResponseMessageWrap<PaperAnswer>
    {
    Body = paperAnswer
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<PaperAnswer>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = PaperAnswerRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<PaperAnswer>>
    {
    Body = new QueryResponse<PaperAnswer>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<PaperAnswer>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = PaperAnswerRepository.GetRecord(reqMsg);
    var list = PaperAnswerRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<PaperAnswer>>
    {
    Body = new QueryByPageResponse<PaperAnswer>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

