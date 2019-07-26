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
/// 课程小组用户表
///</summary>
    [ApiController]
    [Route("erscp/[controller]/[action]")]
    public class CourseGroupUserController : Controller
    {
    public CourseGroupUserService CourseGroupUserService { get; }
    public ICourseGroupUserRepository CourseGroupUserRepository { get; }
    public CourseGroupUserController(CourseGroupUserService courseGroupUserService,ICourseGroupUserRepository courseGroupUserRepository)
    {
    CourseGroupUserService = courseGroupUserService;
    CourseGroupUserRepository = courseGroupUserRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]CourseGroupUser courseGroupUser)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CourseGroupUserService.Insert(courseGroupUser)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CourseGroupUserService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]CourseGroupUser courseGroupUser)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CourseGroupUserService.Update(courseGroupUser)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<CourseGroupUser> GetById(long id)
    {
    var courseGroupUser = CourseGroupUserRepository.GetById(id);
    return new ResponseMessageWrap<CourseGroupUser>
    {
    Body = courseGroupUser
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<CourseGroupUser>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = CourseGroupUserRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<CourseGroupUser>>
    {
    Body = new QueryResponse<CourseGroupUser>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<CourseGroupUser>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = CourseGroupUserRepository.GetRecord(reqMsg);
    var list = CourseGroupUserRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<CourseGroupUser>>
    {
    Body = new QueryByPageResponse<CourseGroupUser>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

