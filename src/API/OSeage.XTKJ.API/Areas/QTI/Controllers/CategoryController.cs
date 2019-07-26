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
/// 类别表
///</summary>
    [ApiController]
    [Route("qti/[controller]/[action]")]
    public class CategoryController : Controller
    {
    public CategoryService CategoryService { get; }
    public ICategoryRepository CategoryRepository { get; }
    public CategoryController(CategoryService categoryService,ICategoryRepository categoryRepository)
    {
    CategoryService = categoryService;
    CategoryRepository = categoryRepository;
    }
    [HttpPost]
    public ResponseMessageWrap<int> Insert([FromBody]Category category)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CategoryService.Insert(category)
    };
    }
    [HttpDelete]
    public ResponseMessageWrap<int> DeleteById(long id)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CategoryService.DeleteById(id)
    };
    }
    [HttpPut]
    public ResponseMessageWrap<int> Update([FromBody]Category category)
    {
    return new ResponseMessageWrap<int>
    {
    Body = CategoryService.Update(category)
    };
    }

    [HttpGet]
    public ResponseMessageWrap<Category> GetById(long id)
    {
    var category = CategoryRepository.GetById(id);
    return new ResponseMessageWrap<Category>
    {
    Body = category
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryResponse<Category>> Query([FromBody]QueryRequest reqMsg)
    {
    var list = CategoryRepository.Query(reqMsg);
    return new ResponseMessageWrap<QueryResponse<Category>>
    {
    Body = new QueryResponse<Category>
    {
    List = list
    }
    };
    }
    [HttpPost]
    public ResponseMessageWrap<QueryByPageResponse<Category>> QueryByPage([FromBody]QueryByPageRequest reqMsg)
    {
    var total = CategoryRepository.GetRecord(reqMsg);
    var list = CategoryRepository.QueryByPage(reqMsg);
    return new ResponseMessageWrap<QueryByPageResponse<Category>>
    {
    Body = new QueryByPageResponse<Category>
    {
    Total = total,
    List = list
    }
    };
    }

    }
    }

