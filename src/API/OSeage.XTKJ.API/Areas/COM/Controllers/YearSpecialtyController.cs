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
/// 年度专业表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class YearSpecialtyController : Controller
    {
    public YearSpecialtyService YearSpecialtyService { get; }
    public IYearSpecialtyRepository YearSpecialtyRepository { get; }
    public YearSpecialtyController(YearSpecialtyService yearSpecialtyService,IYearSpecialtyRepository yearSpecialtyRepository)
    {
    YearSpecialtyService = yearSpecialtyService;
    YearSpecialtyRepository = yearSpecialtyRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]YearSpecialty yearSpecialty)
    {
    return new ResponseMessageWrap<int>
    {
    Body = YearSpecialtyService.Insert(yearSpecialty)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = YearSpecialtyService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]YearSpecialty yearSpecialty)
    {
    return new ResponseMessageWrap<int>
    {
    Body = YearSpecialtyService.Update(yearSpecialty)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<YearSpecialty> GetById(long id)
    {
    var yearSpecialty = YearSpecialtyRepository.GetById(id);
    return new ResponseMessageWrap<YearSpecialty>
    {
    Body = yearSpecialty
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<YearSpecialty>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = YearSpecialtyRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<YearSpecialty>>
    {
    Body = new QueryResponse<YearSpecialty>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<YearSpecialty>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = YearSpecialtyRepository.GetRecord(reqMsg);
    var list = YearSpecialtyRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<YearSpecialty>>
    {
    Body = new QueryByPageResponse<YearSpecialty>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

