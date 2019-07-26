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
/// 试题与标签关系表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class QuestionRefTagController : Controller
    {
    public QuestionRefTagService QuestionRefTagService { get; }
    public IQuestionRefTagRepository QuestionRefTagRepository { get; }
    public QuestionRefTagController(QuestionRefTagService questionRefTagService,IQuestionRefTagRepository questionRefTagRepository)
    {
    QuestionRefTagService = questionRefTagService;
    QuestionRefTagRepository = questionRefTagRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]QuestionRefTag questionRefTag)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionRefTagService.Insert(questionRefTag)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionRefTagService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]QuestionRefTag questionRefTag)
    {
    return new ResponseMessageWrap<int>
    {
    Body = QuestionRefTagService.Update(questionRefTag)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<QuestionRefTag> GetById(long id)
    {
    var questionRefTag = QuestionRefTagRepository.GetById(id);
    return new ResponseMessageWrap<QuestionRefTag>
    {
    Body = questionRefTag
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<QuestionRefTag>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = QuestionRefTagRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<QuestionRefTag>>
    {
    Body = new QueryResponse<QuestionRefTag>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<QuestionRefTag>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = QuestionRefTagRepository.GetRecord(reqMsg);
    var list = QuestionRefTagRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<QuestionRefTag>>
    {
    Body = new QueryByPageResponse<QuestionRefTag>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

