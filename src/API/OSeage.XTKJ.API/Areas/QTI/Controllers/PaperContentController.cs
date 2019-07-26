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
/// 试卷内容表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class PaperContentController : Controller
    {
    public PaperContentService PaperContentService { get; }
    public IPaperContentRepository PaperContentRepository { get; }
    public PaperContentController(PaperContentService paperContentService,IPaperContentRepository paperContentRepository)
    {
    PaperContentService = paperContentService;
    PaperContentRepository = paperContentRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]PaperContent paperContent)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperContentService.Insert(paperContent)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperContentService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]PaperContent paperContent)
    {
    return new ResponseMessageWrap<int>
    {
    Body = PaperContentService.Update(paperContent)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<PaperContent> GetById(long id)
    {
    var paperContent = PaperContentRepository.GetById(id);
    return new ResponseMessageWrap<PaperContent>
    {
    Body = paperContent
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<PaperContent>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = PaperContentRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<PaperContent>>
    {
    Body = new QueryResponse<PaperContent>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<PaperContent>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = PaperContentRepository.GetRecord(reqMsg);
    var list = PaperContentRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<PaperContent>>
    {
    Body = new QueryByPageResponse<PaperContent>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

