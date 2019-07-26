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
/// 试题与知识点关系表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class QuestionRefKnowledgeController : Controller
    {
    public QuestionRefKnowledgeService QuestionRefKnowledgeService { get; }
    public IQuestionRefKnowledgeRepository QuestionRefKnowledgeRepository { get; }
    public QuestionRefKnowledgeController(QuestionRefKnowledgeService questionRefKnowledgeService,IQuestionRefKnowledgeRepository questionRefKnowledgeRepository)
    {
    QuestionRefKnowledgeService = questionRefKnowledgeService;
    QuestionRefKnowledgeRepository = questionRefKnowledgeRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]QuestionRefKnowledge questionRefKnowledge)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionRefKnowledgeService.Insert(questionRefKnowledge)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionRefKnowledgeService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]QuestionRefKnowledge questionRefKnowledge)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionRefKnowledgeService.Update(questionRefKnowledge)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<QuestionRefKnowledge> GetById(long id)
    {
    var questionRefKnowledge = QuestionRefKnowledgeRepository.GetById(id);
    return new ResponseMessageWrap<QuestionRefKnowledge>
    {
    Body = questionRefKnowledge
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<QuestionRefKnowledge>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = QuestionRefKnowledgeRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<QuestionRefKnowledge>>
    {
    Body = new QueryResponse<QuestionRefKnowledge>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<QuestionRefKnowledge>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = QuestionRefKnowledgeRepository.GetRecord(reqMsg);
    var list = QuestionRefKnowledgeRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<QuestionRefKnowledge>>
    {
    Body = new QueryByPageResponse<QuestionRefKnowledge>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

