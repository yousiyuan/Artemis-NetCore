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
/// 试题预览记录表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class QuestionSetController : Controller
    {
    public QuestionSetService QuestionSetService { get; }
    public IQuestionSetRepository QuestionSetRepository { get; }
    public QuestionSetController(QuestionSetService questionSetService,IQuestionSetRepository questionSetRepository)
    {
    QuestionSetService = questionSetService;
    QuestionSetRepository = questionSetRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]QuestionSet questionSet)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionSetService.Insert(questionSet)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionSetService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]QuestionSet questionSet)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionSetService.Update(questionSet)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<QuestionSet> GetById(long id)
    {
    var questionSet = QuestionSetRepository.GetById(id);
    return new ResponseMessageWrap<QuestionSet>
    {
    Body = questionSet
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<QuestionSet>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = QuestionSetRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<QuestionSet>>
    {
    Body = new QueryResponse<QuestionSet>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<QuestionSet>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = QuestionSetRepository.GetRecord(reqMsg);
    var list = QuestionSetRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<QuestionSet>>
    {
    Body = new QueryByPageResponse<QuestionSet>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

