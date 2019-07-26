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
/// 标签表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class TagController : Controller
    {
    public TagService TagService { get; }
    public ITagRepository TagRepository { get; }
    public TagController(TagService tagService,ITagRepository tagRepository)
    {
    TagService = tagService;
    TagRepository = tagRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]Tag tag)
    {
    return new ResponseMessageWrap<int>
    {
    Body = TagService.Insert(tag)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = TagService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]Tag tag)
    {
    return new ResponseMessageWrap<int>
    {
    Body = TagService.Update(tag)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<Tag> GetById(long id)
    {
    var tag = TagRepository.GetById(id);
    return new ResponseMessageWrap<Tag>
    {
    Body = tag
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<Tag>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = TagRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<Tag>>
    {
    Body = new QueryResponse<Tag>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<Tag>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = TagRepository.GetRecord(reqMsg);
    var list = TagRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<Tag>>
    {
    Body = new QueryByPageResponse<Tag>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

