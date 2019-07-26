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
/// 试卷与考试题关系表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class PaperRefQuestionController : Controller
    {
    public PaperRefQuestionService PaperRefQuestionService { get; }
    public IPaperRefQuestionRepository PaperRefQuestionRepository { get; }
    public PaperRefQuestionController(PaperRefQuestionService paperRefQuestionService,IPaperRefQuestionRepository paperRefQuestionRepository)
    {
    PaperRefQuestionService = paperRefQuestionService;
    PaperRefQuestionRepository = paperRefQuestionRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]PaperRefQuestion paperRefQuestion)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperRefQuestionService.Insert(paperRefQuestion)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperRefQuestionService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]PaperRefQuestion paperRefQuestion)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperRefQuestionService.Update(paperRefQuestion)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<PaperRefQuestion> GetById(long id)
    {
    var paperRefQuestion = PaperRefQuestionRepository.GetById(id);
    return new ResponseMessageWrap<PaperRefQuestion>
    {
    Body = paperRefQuestion
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<PaperRefQuestion>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = PaperRefQuestionRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<PaperRefQuestion>>
    {
    Body = new QueryResponse<PaperRefQuestion>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<PaperRefQuestion>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = PaperRefQuestionRepository.GetRecord(reqMsg);
    var list = PaperRefQuestionRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<PaperRefQuestion>>
    {
    Body = new QueryByPageResponse<PaperRefQuestion>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

