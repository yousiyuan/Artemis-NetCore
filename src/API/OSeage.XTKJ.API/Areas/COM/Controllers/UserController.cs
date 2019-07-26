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
/// 用户表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class UserController : Controller
    {
    public UserService UserService { get; }
    public IUserRepository UserRepository { get; }
    public UserController(UserService userService,IUserRepository userRepository)
    {
    UserService = userService;
    UserRepository = userRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]User user)
    {
    return new ResponseMessageWrap<int>
    {
    Body = UserService.Insert(user)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = UserService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]User user)
    {
    return new ResponseMessageWrap<int>
    {
    Body = UserService.Update(user)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<User> GetById(long id)
    {
    var user = UserRepository.GetById(id);
    return new ResponseMessageWrap<User>
    {
    Body = user
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<User>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = UserRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<User>>
    {
    Body = new QueryResponse<User>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<User>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = UserRepository.GetRecord(reqMsg);
    var list = UserRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<User>>
    {
    Body = new QueryByPageResponse<User>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

