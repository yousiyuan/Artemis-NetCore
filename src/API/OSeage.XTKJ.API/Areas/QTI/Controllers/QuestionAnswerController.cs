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
/// 答题记录表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class QuestionAnswerController : Controller
    {
    public QuestionAnswerService QuestionAnswerService { get; }
    public IQuestionAnswerRepository QuestionAnswerRepository { get; }
    public QuestionAnswerController(QuestionAnswerService questionAnswerService,IQuestionAnswerRepository questionAnswerRepository)
    {
    QuestionAnswerService = questionAnswerService;
    QuestionAnswerRepository = questionAnswerRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]QuestionAnswer questionAnswer)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionAnswerService.Insert(questionAnswer)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionAnswerService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]QuestionAnswer questionAnswer)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionAnswerService.Update(questionAnswer)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<QuestionAnswer> GetById(long id)
    {
    var questionAnswer = QuestionAnswerRepository.GetById(id);
    return new ResponseMessageWrap<QuestionAnswer>
    {
    Body = questionAnswer
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<QuestionAnswer>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = QuestionAnswerRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<QuestionAnswer>>
    {
    Body = new QueryResponse<QuestionAnswer>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<QuestionAnswer>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = QuestionAnswerRepository.GetRecord(reqMsg);
    var list = QuestionAnswerRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<QuestionAnswer>>
    {
    Body = new QueryByPageResponse<QuestionAnswer>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

