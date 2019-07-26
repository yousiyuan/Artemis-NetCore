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
/// 开课计划表
///</summary>
    [ApiController]
    [Route("erscp/[controller]/[action]")]
    public class CoursePlanController : Controller
    {
    public CoursePlanService CoursePlanService { get; }
    public ICoursePlanRepository CoursePlanRepository { get; }
    public CoursePlanController(CoursePlanService coursePlanService,ICoursePlanRepository coursePlanRepository)
    {
    CoursePlanService = coursePlanService;
    CoursePlanRepository = coursePlanRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]CoursePlan coursePlan)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanService.Insert(coursePlan)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]CoursePlan coursePlan)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanService.Update(coursePlan)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<CoursePlan> GetById(long id)
    {
    var coursePlan = CoursePlanRepository.GetById(id);
    return new ResponseMessageWrap<CoursePlan>
    {
    Body = coursePlan
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<CoursePlan>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = CoursePlanRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<CoursePlan>>
    {
    Body = new QueryResponse<CoursePlan>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<CoursePlan>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = CoursePlanRepository.GetRecord(reqMsg);
    var list = CoursePlanRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<CoursePlan>>
    {
    Body = new QueryByPageResponse<CoursePlan>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

