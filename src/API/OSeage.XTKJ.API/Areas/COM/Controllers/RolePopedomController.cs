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
/// 角色权限表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class RolePopedomController : Controller
    {
    public RolePopedomService RolePopedomService { get; }
    public IRolePopedomRepository RolePopedomRepository { get; }
    public RolePopedomController(RolePopedomService rolePopedomService,IRolePopedomRepository rolePopedomRepository)
    {
    RolePopedomService = rolePopedomService;
    RolePopedomRepository = rolePopedomRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]RolePopedom rolePopedom)
    {
    return new ResponseMessageWrap<int>
    {
    Body = RolePopedomService.Insert(rolePopedom)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = RolePopedomService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]RolePopedom rolePopedom)
    {
    return new ResponseMessageWrap<int>
    {
    Body = RolePopedomService.Update(rolePopedom)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<RolePopedom> GetById(long id)
    {
    var rolePopedom = RolePopedomRepository.GetById(id);
    return new ResponseMessageWrap<RolePopedom>
    {
    Body = rolePopedom
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<RolePopedom>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = RolePopedomRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<RolePopedom>>
    {
    Body = new QueryResponse<RolePopedom>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<RolePopedom>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = RolePopedomRepository.GetRecord(reqMsg);
    var list = RolePopedomRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<RolePopedom>>
    {
    Body = new QueryByPageResponse<RolePopedom>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

