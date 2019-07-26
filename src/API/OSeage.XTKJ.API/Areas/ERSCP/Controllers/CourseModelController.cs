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
/// 课程章节表
///</summary>
    [ApiController]
    [Route("erscp/[controller]/[action]")]
    public class CourseModelController : Controller
    {
    public CourseModelService CourseModelService { get; }
    public ICourseModelRepository CourseModelRepository { get; }
    public CourseModelController(CourseModelService courseModelService,ICourseModelRepository courseModelRepository)
    {
    CourseModelService = courseModelService;
    CourseModelRepository = courseModelRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]CourseModel courseModel)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CourseModelService.Insert(courseModel)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CourseModelService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]CourseModel courseModel)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CourseModelService.Update(courseModel)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<CourseModel> GetById(long id)
    {
    var courseModel = CourseModelRepository.GetById(id);
    return new ResponseMessageWrap<CourseModel>
    {
    Body = courseModel
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<CourseModel>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = CourseModelRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<CourseModel>>
    {
    Body = new QueryResponse<CourseModel>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<CourseModel>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = CourseModelRepository.GetRecord(reqMsg);
    var list = CourseModelRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<CourseModel>>
    {
    Body = new QueryByPageResponse<CourseModel>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

