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
/// 学院表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class CollegeController : Controller
    {
    public CollegeService CollegeService { get; }
    public ICollegeRepository CollegeRepository { get; }
    public CollegeController(CollegeService collegeService,ICollegeRepository collegeRepository)
    {
    CollegeService = collegeService;
    CollegeRepository = collegeRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]College college)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CollegeService.Insert(college)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CollegeService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]College college)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CollegeService.Update(college)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<College> GetById(long id)
    {
    var college = CollegeRepository.GetById(id);
    return new ResponseMessageWrap<College>
    {
    Body = college
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<College>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = CollegeRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<College>>
    {
    Body = new QueryResponse<College>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<College>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = CollegeRepository.GetRecord(reqMsg);
    var list = CollegeRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<College>>
    {
    Body = new QueryByPageResponse<College>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

