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
/// 新闻
///</summary>
    [ApiController]
    [Route("com/[controller]/[action]")]
    public class NewsInfoController : Controller
    {
    public NewsInfoService NewsInfoService { get; }
    public INewsInfoRepository NewsInfoRepository { get; }
    public NewsInfoController(NewsInfoService newsInfoService,INewsInfoRepository newsInfoRepository)
    {
    NewsInfoService = newsInfoService;
    NewsInfoRepository = newsInfoRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]NewsInfo newsInfo)
    {
    return new ResponseMessageWrap<int>
    {
    Body = NewsInfoService.Insert(newsInfo)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = NewsInfoService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]NewsInfo newsInfo)
    {
    return new ResponseMessageWrap<int>
    {
    Body = NewsInfoService.Update(newsInfo)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<NewsInfo> GetById(long id)
    {
    var newsInfo = NewsInfoRepository.GetById(id);
    return new ResponseMessageWrap<NewsInfo>
    {
    Body = newsInfo
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<NewsInfo>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = NewsInfoRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<NewsInfo>>
    {
    Body = new QueryResponse<NewsInfo>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<NewsInfo>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = NewsInfoRepository.GetRecord(reqMsg);
    var list = NewsInfoRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<NewsInfo>>
    {
    Body = new QueryByPageResponse<NewsInfo>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

