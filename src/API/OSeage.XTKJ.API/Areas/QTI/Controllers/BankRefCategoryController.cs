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
/// 题库与类别关系表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class BankRefCategoryController : Controller
    {
    public BankRefCategoryService BankRefCategoryService { get; }
    public IBankRefCategoryRepository BankRefCategoryRepository { get; }
    public BankRefCategoryController(BankRefCategoryService bankRefCategoryService,IBankRefCategoryRepository bankRefCategoryRepository)
    {
    BankRefCategoryService = bankRefCategoryService;
    BankRefCategoryRepository = bankRefCategoryRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]BankRefCategory bankRefCategory)
    {
    return new ResponseMessageWrap<int>
    {
    Body = BankRefCategoryService.Insert(bankRefCategory)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = BankRefCategoryService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]BankRefCategory bankRefCategory)
    {
    return new ResponseMessageWrap<int>
    {
    Body = BankRefCategoryService.Update(bankRefCategory)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<BankRefCategory> GetById(long id)
    {
    var bankRefCategory = BankRefCategoryRepository.GetById(id);
    return new ResponseMessageWrap<BankRefCategory>
    {
    Body = bankRefCategory
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<BankRefCategory>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = BankRefCategoryRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<BankRefCategory>>
    {
    Body = new QueryResponse<BankRefCategory>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<BankRefCategory>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = BankRefCategoryRepository.GetRecord(reqMsg);
    var list = BankRefCategoryRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<BankRefCategory>>
    {
    Body = new QueryByPageResponse<BankRefCategory>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

