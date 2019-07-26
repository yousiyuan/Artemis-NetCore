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
/// 开课计划班级表
///</summary>
    [ApiController]
    [Route("erscp/[controller]/[action]")]
    public class CoursePlanClassController : Controller
    {
    public CoursePlanClassService CoursePlanClassService { get; }
    public ICoursePlanClassRepository CoursePlanClassRepository { get; }
    public CoursePlanClassController(CoursePlanClassService coursePlanClassService,ICoursePlanClassRepository coursePlanClassRepository)
    {
    CoursePlanClassService = coursePlanClassService;
    CoursePlanClassRepository = coursePlanClassRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]CoursePlanClass coursePlanClass)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanClassService.Insert(coursePlanClass)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanClassService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]CoursePlanClass coursePlanClass)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanClassService.Update(coursePlanClass)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<CoursePlanClass> GetById(long id)
    {
    var coursePlanClass = CoursePlanClassRepository.GetById(id);
    return new ResponseMessageWrap<CoursePlanClass>
    {
    Body = coursePlanClass
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<CoursePlanClass>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = CoursePlanClassRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<CoursePlanClass>>
    {
    Body = new QueryResponse<CoursePlanClass>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<CoursePlanClass>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = CoursePlanClassRepository.GetRecord(reqMsg);
    var list = CoursePlanClassRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<CoursePlanClass>>
    {
    Body = new QueryByPageResponse<CoursePlanClass>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

