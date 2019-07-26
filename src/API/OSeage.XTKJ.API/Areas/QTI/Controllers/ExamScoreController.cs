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
/// 考试成绩表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class ExamScoreController : Controller
    {
    public ExamScoreService ExamScoreService { get; }
    public IExamScoreRepository ExamScoreRepository { get; }
    public ExamScoreController(ExamScoreService examScoreService,IExamScoreRepository examScoreRepository)
    {
    ExamScoreService = examScoreService;
    ExamScoreRepository = examScoreRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]ExamScore examScore)
    {
    return new ResponseMessageWrap<int>
    {
    Body = ExamScoreService.Insert(examScore)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = ExamScoreService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]ExamScore examScore)
    {
    return new ResponseMessageWrap<int>
    {
    Body = ExamScoreService.Update(examScore)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<ExamScore> GetById(long id)
    {
    var examScore = ExamScoreRepository.GetById(id);
    return new ResponseMessageWrap<ExamScore>
    {
    Body = examScore
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<ExamScore>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = ExamScoreRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<ExamScore>>
    {
    Body = new QueryResponse<ExamScore>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<ExamScore>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = ExamScoreRepository.GetRecord(reqMsg);
    var list = ExamScoreRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<ExamScore>>
    {
    Body = new QueryByPageResponse<ExamScore>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

