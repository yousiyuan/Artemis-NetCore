//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:49
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OSeage.QTI.Entity;
using OSeage.QTI.Repository;
using OSeage.QTI.Service;
using OSeage.XTKJ.API.Message;

namespace OSeage.XTKJ.API.Areas.QTI.Controllers
{
    ///<summary>
/// 考试题内容表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class ContentController : Controller
    {
    public ContentService ContentService { get; }
    public IContentRepository ContentRepository { get; }
    public ContentController(ContentService contentService,IContentRepository contentRepository)
    {
    ContentService = contentService;
    ContentRepository = contentRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]Content content)
    {
    return new ResponseMessageWrap<int>
    {
    Body = ContentService.Insert(content)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = ContentService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]Content content)
    {
    return new ResponseMessageWrap<int>
    {
    Body = ContentService.Update(content)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<Content> GetById(long id)
    {
    var content = ContentRepository.GetById(id);
    return new ResponseMessageWrap<Content>
    {
    Body = content
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<Content>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = ContentRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<Content>>
    {
    Body = new QueryResponse<Content>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<Content>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = ContentRepository.GetRecord(reqMsg);
    var list = ContentRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<Content>>
    {
    Body = new QueryByPageResponse<Content>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

