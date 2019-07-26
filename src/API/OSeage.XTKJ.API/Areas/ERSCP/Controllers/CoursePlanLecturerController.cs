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
/// 开课计划讲师表
///</summary>
    [ApiController]
    [Route("erscp/[controller]/[action]")]
    public class CoursePlanLecturerController : Controller
    {
    public CoursePlanLecturerService CoursePlanLecturerService { get; }
    public ICoursePlanLecturerRepository CoursePlanLecturerRepository { get; }
    public CoursePlanLecturerController(CoursePlanLecturerService coursePlanLecturerService,ICoursePlanLecturerRepository coursePlanLecturerRepository)
    {
    CoursePlanLecturerService = coursePlanLecturerService;
    CoursePlanLecturerRepository = coursePlanLecturerRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]CoursePlanLecturer coursePlanLecturer)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanLecturerService.Insert(coursePlanLecturer)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanLecturerService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]CoursePlanLecturer coursePlanLecturer)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanLecturerService.Update(coursePlanLecturer)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<CoursePlanLecturer> GetById(long id)
    {
    var coursePlanLecturer = CoursePlanLecturerRepository.GetById(id);
    return new ResponseMessageWrap<CoursePlanLecturer>
    {
    Body = coursePlanLecturer
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<CoursePlanLecturer>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = CoursePlanLecturerRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<CoursePlanLecturer>>
    {
    Body = new QueryResponse<CoursePlanLecturer>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<CoursePlanLecturer>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = CoursePlanLecturerRepository.GetRecord(reqMsg);
    var list = CoursePlanLecturerRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<CoursePlanLecturer>>
    {
    Body = new QueryByPageResponse<CoursePlanLecturer>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

