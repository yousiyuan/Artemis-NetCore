//*******************************
// Create By 流年 公子
// Date 2019-07-03 14:02
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OSeage.LMS.COM.Entity;
using OSeage.LMS.COM.Repository;
using OSeage.LMS.COM.Service;
using OSeage.XTKJ.API.Message;

namespace OSeage.XTKJ.API.Areas.COM.Controllers
{
    ///<summary>
/// 学科表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class SubjectController : Controller
    {
    public SubjectService SubjectService { get; }
    public ISubjectRepository SubjectRepository { get; }
    public SubjectController(SubjectService subjectService,ISubjectRepository subjectRepository)
    {
    SubjectService = subjectService;
    SubjectRepository = subjectRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]Subject subject)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SubjectService.Insert(subject)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SubjectService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]Subject subject)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SubjectService.Update(subject)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<Subject> GetById(long id)
    {
    var subject = SubjectRepository.GetById(id);
    return new ResponseMessageWrap<Subject>
    {
    Body = subject
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<Subject>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = SubjectRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<Subject>>
    {
    Body = new QueryResponse<Subject>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<Subject>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = SubjectRepository.GetRecord(reqMsg);
    var list = SubjectRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<Subject>>
    {
    Body = new QueryByPageResponse<Subject>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

