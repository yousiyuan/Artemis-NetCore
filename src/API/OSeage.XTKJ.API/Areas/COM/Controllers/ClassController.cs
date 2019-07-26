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
/// 班级表
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class ClassController : Controller
    {
    public ClassService ClassService { get; }
    public IClassRepository ClassRepository { get; }
    public ClassController(ClassService classService,IClassRepository classRepository)
    {
    ClassService = classService;
    ClassRepository = classRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]Class clazz)
    {
    return new ResponseMessageWrap<int>
    {
    Body = ClassService.Insert(clazz)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = ClassService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]Class clazz)
    {
    return new ResponseMessageWrap<int>
    {
    Body = ClassService.Update(clazz)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<Class> GetById(long id)
    {
    var clazz = ClassRepository.GetById(id);
    return new ResponseMessageWrap<Class>
    {
    Body = clazz
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<Class>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = ClassRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<Class>>
    {
    Body = new QueryResponse<Class>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<Class>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = ClassRepository.GetRecord(reqMsg);
    var list = ClassRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<Class>>
    {
    Body = new QueryByPageResponse<Class>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

