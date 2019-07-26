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
/// 专业表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class SpecialtyController : Controller
    {
    public SpecialtyService SpecialtyService { get; }
    public ISpecialtyRepository SpecialtyRepository { get; }
    public SpecialtyController(SpecialtyService specialtyService,ISpecialtyRepository specialtyRepository)
    {
    SpecialtyService = specialtyService;
    SpecialtyRepository = specialtyRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]Specialty specialty)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SpecialtyService.Insert(specialty)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SpecialtyService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]Specialty specialty)
    {
    return new ResponseMessageWrap<int>
    {
    Body = SpecialtyService.Update(specialty)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<Specialty> GetById(long id)
    {
    var specialty = SpecialtyRepository.GetById(id);
    return new ResponseMessageWrap<Specialty>
    {
    Body = specialty
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<Specialty>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = SpecialtyRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<Specialty>>
    {
    Body = new QueryResponse<Specialty>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<Specialty>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = SpecialtyRepository.GetRecord(reqMsg);
    var list = SpecialtyRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<Specialty>>
    {
    Body = new QueryByPageResponse<Specialty>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

