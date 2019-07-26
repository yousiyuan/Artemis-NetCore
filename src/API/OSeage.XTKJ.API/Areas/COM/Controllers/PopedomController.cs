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
/// 权限菜单表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class PopedomController : Controller
    {
    public PopedomService PopedomService { get; }
    public IPopedomRepository PopedomRepository { get; }
    public PopedomController(PopedomService popedomService,IPopedomRepository popedomRepository)
    {
    PopedomService = popedomService;
    PopedomRepository = popedomRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]Popedom popedom)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PopedomService.Insert(popedom)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PopedomService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]Popedom popedom)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PopedomService.Update(popedom)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<Popedom> GetById(long id)
    {
    var popedom = PopedomRepository.GetById(id);
    return new ResponseMessageWrap<Popedom>
    {
    Body = popedom
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<Popedom>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = PopedomRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<Popedom>>
    {
    Body = new QueryResponse<Popedom>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<Popedom>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = PopedomRepository.GetRecord(reqMsg);
    var list = PopedomRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<Popedom>>
    {
    Body = new QueryByPageResponse<Popedom>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

