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
/// 用户权限表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class UserPopedomController : Controller
    {
    public UserPopedomService UserPopedomService { get; }
    public IUserPopedomRepository UserPopedomRepository { get; }
    public UserPopedomController(UserPopedomService userPopedomService,IUserPopedomRepository userPopedomRepository)
    {
    UserPopedomService = userPopedomService;
    UserPopedomRepository = userPopedomRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]UserPopedom userPopedom)
    {
    return new ResponseMessageWrap<int>
    {
    Body = UserPopedomService.Insert(userPopedom)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = UserPopedomService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]UserPopedom userPopedom)
    {
    return new ResponseMessageWrap<int>
    {
    Body = UserPopedomService.Update(userPopedom)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<UserPopedom> GetById(long id)
    {
    var userPopedom = UserPopedomRepository.GetById(id);
    return new ResponseMessageWrap<UserPopedom>
    {
    Body = userPopedom
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<UserPopedom>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = UserPopedomRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<UserPopedom>>
    {
    Body = new QueryResponse<UserPopedom>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<UserPopedom>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = UserPopedomRepository.GetRecord(reqMsg);
    var list = UserPopedomRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<UserPopedom>>
    {
    Body = new QueryByPageResponse<UserPopedom>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

