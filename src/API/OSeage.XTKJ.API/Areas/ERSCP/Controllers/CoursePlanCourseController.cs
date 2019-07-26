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
/// 开课计划课程表
///</summary>
    [ApiController]
    [Route("erscp/[controller]/[action]")]
    public class CoursePlanCourseController : Controller
    {
    public CoursePlanCourseService CoursePlanCourseService { get; }
    public ICoursePlanCourseRepository CoursePlanCourseRepository { get; }
    public CoursePlanCourseController(CoursePlanCourseService coursePlanCourseService,ICoursePlanCourseRepository coursePlanCourseRepository)
    {
    CoursePlanCourseService = coursePlanCourseService;
    CoursePlanCourseRepository = coursePlanCourseRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]CoursePlanCourse coursePlanCourse)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanCourseService.Insert(coursePlanCourse)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanCourseService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]CoursePlanCourse coursePlanCourse)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanCourseService.Update(coursePlanCourse)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<CoursePlanCourse> GetById(long id)
    {
    var coursePlanCourse = CoursePlanCourseRepository.GetById(id);
    return new ResponseMessageWrap<CoursePlanCourse>
    {
    Body = coursePlanCourse
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<CoursePlanCourse>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = CoursePlanCourseRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<CoursePlanCourse>>
    {
    Body = new QueryResponse<CoursePlanCourse>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<CoursePlanCourse>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = CoursePlanCourseRepository.GetRecord(reqMsg);
    var list = CoursePlanCourseRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<CoursePlanCourse>>
    {
    Body = new QueryByPageResponse<CoursePlanCourse>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

