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
/// 新闻分类
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class NewsKindController : Controller
    {
    public NewsKindService NewsKindService { get; }
    public INewsKindRepository NewsKindRepository { get; }
    public NewsKindController(NewsKindService newsKindService,INewsKindRepository newsKindRepository)
    {
    NewsKindService = newsKindService;
    NewsKindRepository = newsKindRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]NewsKind newsKind)
    {
    return new ResponseMessageWrap<int>
    {
    Body = NewsKindService.Insert(newsKind)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = NewsKindService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]NewsKind newsKind)
    {
    return new ResponseMessageWrap<int>
    {
    Body = NewsKindService.Update(newsKind)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<NewsKind> GetById(long id)
    {
    var newsKind = NewsKindRepository.GetById(id);
    return new ResponseMessageWrap<NewsKind>
    {
    Body = newsKind
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<NewsKind>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = NewsKindRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<NewsKind>>
    {
    Body = new QueryResponse<NewsKind>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<NewsKind>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = NewsKindRepository.GetRecord(reqMsg);
    var list = NewsKindRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<NewsKind>>
    {
    Body = new QueryByPageResponse<NewsKind>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

