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
/// 学校表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class SchoolController : Controller
    {
    public SchoolService SchoolService { get; }
    public ISchoolRepository SchoolRepository { get; }
    public SchoolController(SchoolService schoolService,ISchoolRepository schoolRepository)
    {
    SchoolService = schoolService;
    SchoolRepository = schoolRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]School school)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SchoolService.Insert(school)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SchoolService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]School school)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SchoolService.Update(school)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<School> GetById(long id)
    {
    var school = SchoolRepository.GetById(id);
    return new ResponseMessageWrap<School>
    {
    Body = school
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<School>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = SchoolRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<School>>
    {
    Body = new QueryResponse<School>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<School>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = SchoolRepository.GetRecord(reqMsg);
    var list = SchoolRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<School>>
    {
    Body = new QueryByPageResponse<School>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

