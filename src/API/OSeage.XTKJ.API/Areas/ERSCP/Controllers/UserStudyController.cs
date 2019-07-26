//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:57
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OSeage.LMS.ERSCP.Entity;
using OSeage.LMS.ERSCP.Repository;
using OSeage.LMS.ERSCP.Service;
using OSeage.XTKJ.API.Message;

namespace OSeage.XTKJ.API.Areas.ERSCP.Controllers
{
    ///<summary>
/// 用户学习表
///</summary>
    [ApiController]
    [Route("erscp/[controller]/[action]")]
    public class UserStudyController : Controller
    {
    public UserStudyService UserStudyService { get; }
    public IUserStudyRepository UserStudyRepository { get; }
    public UserStudyController(UserStudyService userStudyService,IUserStudyRepository userStudyRepository)
    {
    UserStudyService = userStudyService;
    UserStudyRepository = userStudyRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]UserStudy userStudy)
    {
    return new ResponseMessageWrap<int>
    {
    Body = UserStudyService.Insert(userStudy)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = UserStudyService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]UserStudy userStudy)
    {
    return new ResponseMessageWrap<int>
    {
    Body = UserStudyService.Update(userStudy)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<UserStudy> GetById(long id)
    {
    var userStudy = UserStudyRepository.GetById(id);
    return new ResponseMessageWrap<UserStudy>
    {
    Body = userStudy
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<UserStudy>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = UserStudyRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<UserStudy>>
    {
    Body = new QueryResponse<UserStudy>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<UserStudy>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = UserStudyRepository.GetRecord(reqMsg);
    var list = UserStudyRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<UserStudy>>
    {
    Body = new QueryByPageResponse<UserStudy>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

