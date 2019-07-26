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
/// 答题答案表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class QuestionAnswerItemController : Controller
    {
    public QuestionAnswerItemService QuestionAnswerItemService { get; }
    public IQuestionAnswerItemRepository QuestionAnswerItemRepository { get; }
    public QuestionAnswerItemController(QuestionAnswerItemService questionAnswerItemService,IQuestionAnswerItemRepository questionAnswerItemRepository)
    {
    QuestionAnswerItemService = questionAnswerItemService;
    QuestionAnswerItemRepository = questionAnswerItemRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]QuestionAnswerItem questionAnswerItem)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionAnswerItemService.Insert(questionAnswerItem)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionAnswerItemService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]QuestionAnswerItem questionAnswerItem)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionAnswerItemService.Update(questionAnswerItem)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<QuestionAnswerItem> GetById(long id)
    {
    var questionAnswerItem = QuestionAnswerItemRepository.GetById(id);
    return new ResponseMessageWrap<QuestionAnswerItem>
    {
    Body = questionAnswerItem
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<QuestionAnswerItem>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = QuestionAnswerItemRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<QuestionAnswerItem>>
    {
    Body = new QueryResponse<QuestionAnswerItem>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<QuestionAnswerItem>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = QuestionAnswerItemRepository.GetRecord(reqMsg);
    var list = QuestionAnswerItemRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<QuestionAnswerItem>>
    {
    Body = new QueryByPageResponse<QuestionAnswerItem>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

