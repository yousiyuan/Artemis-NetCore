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
/// 题型表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class QuestionTypeController : Controller
    {
    public QuestionTypeService QuestionTypeService { get; }
    public IQuestionTypeRepository QuestionTypeRepository { get; }
    public QuestionTypeController(QuestionTypeService questionTypeService,IQuestionTypeRepository questionTypeRepository)
    {
    QuestionTypeService = questionTypeService;
    QuestionTypeRepository = questionTypeRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]QuestionType questionType)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionTypeService.Insert(questionType)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionTypeService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]QuestionType questionType)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionTypeService.Update(questionType)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<QuestionType> GetById(long id)
    {
    var questionType = QuestionTypeRepository.GetById(id);
    return new ResponseMessageWrap<QuestionType>
    {
    Body = questionType
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<QuestionType>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = QuestionTypeRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<QuestionType>>
    {
    Body = new QueryResponse<QuestionType>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<QuestionType>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = QuestionTypeRepository.GetRecord(reqMsg);
    var list = QuestionTypeRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<QuestionType>>
    {
    Body = new QueryByPageResponse<QuestionType>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

