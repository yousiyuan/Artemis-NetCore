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
/// 校区表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class CampusController : Controller
    {
    public CampusService CampusService { get; }
    public ICampusRepository CampusRepository { get; }
    public CampusController(CampusService campusService,ICampusRepository campusRepository)
    {
    CampusService = campusService;
    CampusRepository = campusRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]Campus campus)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CampusService.Insert(campus)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CampusService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]Campus campus)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CampusService.Update(campus)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<Campus> GetById(long id)
    {
    var campus = CampusRepository.GetById(id);
    return new ResponseMessageWrap<Campus>
    {
    Body = campus
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<Campus>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = CampusRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<Campus>>
    {
    Body = new QueryResponse<Campus>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<Campus>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = CampusRepository.GetRecord(reqMsg);
    var list = CampusRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<Campus>>
    {
    Body = new QueryByPageResponse<Campus>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

