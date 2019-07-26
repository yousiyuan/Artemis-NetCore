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
/// 学年学期表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class SchoolYearController : Controller
    {
    public SchoolYearService SchoolYearService { get; }
    public ISchoolYearRepository SchoolYearRepository { get; }
    public SchoolYearController(SchoolYearService schoolYearService,ISchoolYearRepository schoolYearRepository)
    {
    SchoolYearService = schoolYearService;
    SchoolYearRepository = schoolYearRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]SchoolYear schoolYear)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SchoolYearService.Insert(schoolYear)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SchoolYearService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]SchoolYear schoolYear)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SchoolYearService.Update(schoolYear)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<SchoolYear> GetById(long id)
    {
    var schoolYear = SchoolYearRepository.GetById(id);
    return new ResponseMessageWrap<SchoolYear>
    {
    Body = schoolYear
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<SchoolYear>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = SchoolYearRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<SchoolYear>>
    {
    Body = new QueryResponse<SchoolYear>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<SchoolYear>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = SchoolYearRepository.GetRecord(reqMsg);
    var list = SchoolYearRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<SchoolYear>>
    {
    Body = new QueryByPageResponse<SchoolYear>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

