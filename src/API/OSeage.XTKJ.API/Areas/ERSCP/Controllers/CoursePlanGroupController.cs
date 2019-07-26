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
/// 课程小组表
///</summary>
    [ApiController]
    [Route("erscp/[controller]/[action]")]
    public class CoursePlanGroupController : Controller
    {
    public CoursePlanGroupService CoursePlanGroupService { get; }
    public ICoursePlanGroupRepository CoursePlanGroupRepository { get; }
    public CoursePlanGroupController(CoursePlanGroupService coursePlanGroupService,ICoursePlanGroupRepository coursePlanGroupRepository)
    {
    CoursePlanGroupService = coursePlanGroupService;
    CoursePlanGroupRepository = coursePlanGroupRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]CoursePlanGroup coursePlanGroup)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanGroupService.Insert(coursePlanGroup)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanGroupService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]CoursePlanGroup coursePlanGroup)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CoursePlanGroupService.Update(coursePlanGroup)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<CoursePlanGroup> GetById(long id)
    {
    var coursePlanGroup = CoursePlanGroupRepository.GetById(id);
    return new ResponseMessageWrap<CoursePlanGroup>
    {
    Body = coursePlanGroup
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<CoursePlanGroup>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = CoursePlanGroupRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<CoursePlanGroup>>
    {
    Body = new QueryResponse<CoursePlanGroup>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<CoursePlanGroup>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = CoursePlanGroupRepository.GetRecord(reqMsg);
    var list = CoursePlanGroupRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<CoursePlanGroup>>
    {
    Body = new QueryByPageResponse<CoursePlanGroup>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

