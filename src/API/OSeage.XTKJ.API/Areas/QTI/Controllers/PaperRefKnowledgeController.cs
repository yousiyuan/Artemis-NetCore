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
/// 试卷与知识点关系表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class PaperRefKnowledgeController : Controller
    {
    public PaperRefKnowledgeService PaperRefKnowledgeService { get; }
    public IPaperRefKnowledgeRepository PaperRefKnowledgeRepository { get; }
    public PaperRefKnowledgeController(PaperRefKnowledgeService paperRefKnowledgeService,IPaperRefKnowledgeRepository paperRefKnowledgeRepository)
    {
    PaperRefKnowledgeService = paperRefKnowledgeService;
    PaperRefKnowledgeRepository = paperRefKnowledgeRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]PaperRefKnowledge paperRefKnowledge)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperRefKnowledgeService.Insert(paperRefKnowledge)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperRefKnowledgeService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]PaperRefKnowledge paperRefKnowledge)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperRefKnowledgeService.Update(paperRefKnowledge)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<PaperRefKnowledge> GetById(long id)
    {
    var paperRefKnowledge = PaperRefKnowledgeRepository.GetById(id);
    return new ResponseMessageWrap<PaperRefKnowledge>
    {
    Body = paperRefKnowledge
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<PaperRefKnowledge>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = PaperRefKnowledgeRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<PaperRefKnowledge>>
    {
    Body = new QueryResponse<PaperRefKnowledge>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<PaperRefKnowledge>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = PaperRefKnowledgeRepository.GetRecord(reqMsg);
    var list = PaperRefKnowledgeRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<PaperRefKnowledge>>
    {
    Body = new QueryByPageResponse<PaperRefKnowledge>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

