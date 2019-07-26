//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:57
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OSeage.LMS.ERSCP.Entity;
using OSeage.LMS.ERSCP.Repository;
using OSeage.LMS.ERSCP.Service;
using OSeage.XTKJ.API.Message;

namespace OSeage.XTKJ.API.Areas.ERSCP.Controllers
{
    ///<summary>
/// 开课计划学生表
///</summary>
    [ApiController]
    [Route("erscp/[controller]/[action]")]
    public class CoursePlanStudentController : Controller
    {
    public CoursePlanStudentService CoursePlanStudentService { get; }
    public ICoursePlanStudentRepository CoursePlanStudentRepository { get; }
    public CoursePlanStudentController(CoursePlanStudentService coursePlanStudentService,ICoursePlanStudentRepository coursePlanStudentRepository)
    {
    CoursePlanStudentService = coursePlanStudentService;
    CoursePlanStudentRepository = coursePlanStudentRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]CoursePlanStudent coursePlanStudent)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanStudentService.Insert(coursePlanStudent)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanStudentService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]CoursePlanStudent coursePlanStudent)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanStudentService.Update(coursePlanStudent)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<CoursePlanStudent> GetById(long id)
    {
    var coursePlanStudent = CoursePlanStudentRepository.GetById(id);
    return new ResponseMessageWrap<CoursePlanStudent>
    {
    Body = coursePlanStudent
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<CoursePlanStudent>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = CoursePlanStudentRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<CoursePlanStudent>>
    {
    Body = new QueryResponse<CoursePlanStudent>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<CoursePlanStudent>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = CoursePlanStudentRepository.GetRecord(reqMsg);
    var list = CoursePlanStudentRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<CoursePlanStudent>>
    {
    Body = new QueryByPageResponse<CoursePlanStudent>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

