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
/// 考试题
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class QuestionController : Controller
    {
    public QuestionService QuestionService { get; }
    public IQuestionRepository QuestionRepository { get; }
    public QuestionController(QuestionService questionService,IQuestionRepository questionRepository)
    {
    QuestionService = questionService;
    QuestionRepository = questionRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]Question question)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionService.Insert(question)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]Question question)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionService.Update(question)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<Question> GetById(long id)
    {
    var question = QuestionRepository.GetById(id);
    return new ResponseMessageWrap<Question>
    {
    Body = question
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<Question>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = QuestionRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<Question>>
    {
    Body = new QueryResponse<Question>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<Question>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = QuestionRepository.GetRecord(reqMsg);
    var list = QuestionRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<Question>>
    {
    Body = new QueryByPageResponse<Question>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

