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
/// 用户角色表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class UserRoleController : Controller
    {
    public UserRoleService UserRoleService { get; }
    public IUserRoleRepository UserRoleRepository { get; }
    public UserRoleController(UserRoleService userRoleService,IUserRoleRepository userRoleRepository)
    {
    UserRoleService = userRoleService;
    UserRoleRepository = userRoleRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]UserRole userRole)
    {
    return new ResponseMessageWrap<int>
    {
    Body = UserRoleService.Insert(userRole)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = UserRoleService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]UserRole userRole)
    {
    return new ResponseMessageWrap<int>
    {
    Body = UserRoleService.Update(userRole)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<UserRole> GetById(long id)
    {
    var userRole = UserRoleRepository.GetById(id);
    return new ResponseMessageWrap<UserRole>
    {
    Body = userRole
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<UserRole>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = UserRoleRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<UserRole>>
    {
    Body = new QueryResponse<UserRole>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<UserRole>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = UserRoleRepository.GetRecord(reqMsg);
    var list = UserRoleRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<UserRole>>
    {
    Body = new QueryByPageResponse<UserRole>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

