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
/// 物理文件
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class PhysicalFileController : Controller
    {
    public PhysicalFileService PhysicalFileService { get; }
    public IPhysicalFileRepository PhysicalFileRepository { get; }
    public PhysicalFileController(PhysicalFileService physicalFileService,IPhysicalFileRepository physicalFileRepository)
    {
    PhysicalFileService = physicalFileService;
    PhysicalFileRepository = physicalFileRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]PhysicalFile physicalFile)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PhysicalFileService.Insert(physicalFile)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PhysicalFileService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]PhysicalFile physicalFile)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PhysicalFileService.Update(physicalFile)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<PhysicalFile> GetById(long id)
    {
    var physicalFile = PhysicalFileRepository.GetById(id);
    return new ResponseMessageWrap<PhysicalFile>
    {
    Body = physicalFile
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<PhysicalFile>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = PhysicalFileRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<PhysicalFile>>
    {
    Body = new QueryResponse<PhysicalFile>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<PhysicalFile>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = PhysicalFileRepository.GetRecord(reqMsg);
    var list = PhysicalFileRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<PhysicalFile>>
    {
    Body = new QueryByPageResponse<PhysicalFile>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

