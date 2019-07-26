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
/// 知识点
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class KnowledgePointsController : Controller
    {
    public KnowledgePointsService KnowledgePointsService { get; }
    public IKnowledgePointsRepository KnowledgePointsRepository { get; }
    public KnowledgePointsController(KnowledgePointsService knowledgePointsService,IKnowledgePointsRepository knowledgePointsRepository)
    {
    KnowledgePointsService = knowledgePointsService;
    KnowledgePointsRepository = knowledgePointsRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]KnowledgePoints knowledgePoints)
    {
    return new ResponseMessageWrap<int>
    {
    Body = KnowledgePointsService.Insert(knowledgePoints)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = KnowledgePointsService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]KnowledgePoints knowledgePoints)
    {
    return new ResponseMessageWrap<int>
    {
    Body = KnowledgePointsService.Update(knowledgePoints)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<KnowledgePoints> GetById(long id)
    {
    var knowledgePoints = KnowledgePointsRepository.GetById(id);
    return new ResponseMessageWrap<KnowledgePoints>
    {
    Body = knowledgePoints
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<KnowledgePoints>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = KnowledgePointsRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<KnowledgePoints>>
    {
    Body = new QueryResponse<KnowledgePoints>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<KnowledgePoints>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = KnowledgePointsRepository.GetRecord(reqMsg);
    var list = KnowledgePointsRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<KnowledgePoints>>
    {
    Body = new QueryByPageResponse<KnowledgePoints>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

