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
    public class QuestionPreviewController : Controller
    {
    public QuestionPreviewService QuestionPreviewService { get; }
    public IQuestionPreviewRepository QuestionPreviewRepository { get; }
    public QuestionPreviewController(QuestionPreviewService questionPreviewService,IQuestionPreviewRepository questionPreviewRepository)
    {
    QuestionPreviewService = questionPreviewService;
    QuestionPreviewRepository = questionPreviewRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]QuestionPreview questionPreview)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionPreviewService.Insert(questionPreview)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionPreviewService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]QuestionPreview questionPreview)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionPreviewService.Update(questionPreview)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<QuestionPreview> GetById(long id)
    {
    var questionPreview = QuestionPreviewRepository.GetById(id);
    return new ResponseMessageWrap<QuestionPreview>
    {
    Body = questionPreview
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<QuestionPreview>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = QuestionPreviewRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<QuestionPreview>>
    {
    Body = new QueryResponse<QuestionPreview>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<QuestionPreview>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = QuestionPreviewRepository.GetRecord(reqMsg);
    var list = QuestionPreviewRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<QuestionPreview>>
    {
    Body = new QueryByPageResponse<QuestionPreview>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

