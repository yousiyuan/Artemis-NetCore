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
/// 题库表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class QuestionBankController : Controller
    {
    public QuestionBankService QuestionBankService { get; }
    public IQuestionBankRepository QuestionBankRepository { get; }
    public QuestionBankController(QuestionBankService questionBankService,IQuestionBankRepository questionBankRepository)
    {
    QuestionBankService = questionBankService;
    QuestionBankRepository = questionBankRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]QuestionBank questionBank)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionBankService.Insert(questionBank)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionBankService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]QuestionBank questionBank)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionBankService.Update(questionBank)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<QuestionBank> GetById(long id)
    {
    var questionBank = QuestionBankRepository.GetById(id);
    return new ResponseMessageWrap<QuestionBank>
    {
    Body = questionBank
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<QuestionBank>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = QuestionBankRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<QuestionBank>>
    {
    Body = new QueryResponse<QuestionBank>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<QuestionBank>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = QuestionBankRepository.GetRecord(reqMsg);
    var list = QuestionBankRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<QuestionBank>>
    {
    Body = new QueryByPageResponse<QuestionBank>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

