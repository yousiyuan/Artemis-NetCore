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
/// 角色表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class RoleController : Controller
    {
    public RoleService RoleService { get; }
    public IRoleRepository RoleRepository { get; }
    public RoleController(RoleService roleService,IRoleRepository roleRepository)
    {
    RoleService = roleService;
    RoleRepository = roleRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]Role role)
    {
    return new ResponseMessageWrap<int>
    {
    Body = RoleService.Insert(role)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = RoleService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]Role role)
    {
    return new ResponseMessageWrap<int>
    {
    Body = RoleService.Update(role)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<Role> GetById(long id)
    {
    var role = RoleRepository.GetById(id);
    return new ResponseMessageWrap<Role>
    {
    Body = role
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<Role>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = RoleRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<Role>>
    {
    Body = new QueryResponse<Role>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<Role>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = RoleRepository.GetRecord(reqMsg);
    var list = RoleRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<Role>>
    {
    Body = new QueryByPageResponse<Role>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

