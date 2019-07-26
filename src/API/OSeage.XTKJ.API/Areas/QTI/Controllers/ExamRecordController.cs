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
/// 答卷记录表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class ExamRecordController : Controller
    {
    public ExamRecordService ExamRecordService { get; }
    public IExamRecordRepository ExamRecordRepository { get; }
    public ExamRecordController(ExamRecordService examRecordService,IExamRecordRepository examRecordRepository)
    {
    ExamRecordService = examRecordService;
    ExamRecordRepository = examRecordRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]ExamRecord examRecord)
    {
    return new ResponseMessageWrap<int>
    {
    Body = ExamRecordService.Insert(examRecord)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = ExamRecordService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]ExamRecord examRecord)
    {
    return new ResponseMessageWrap<int>
    {
    Body = ExamRecordService.Update(examRecord)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<ExamRecord> GetById(long id)
    {
    var examRecord = ExamRecordRepository.GetById(id);
    return new ResponseMessageWrap<ExamRecord>
    {
    Body = examRecord
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<ExamRecord>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = ExamRecordRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<ExamRecord>>
    {
    Body = new QueryResponse<ExamRecord>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<ExamRecord>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = ExamRecordRepository.GetRecord(reqMsg);
    var list = ExamRecordRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<ExamRecord>>
    {
    Body = new QueryByPageResponse<ExamRecord>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

