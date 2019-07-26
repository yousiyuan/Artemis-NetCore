//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:49
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Linq;
using OSeage.QTI.Entity;
using OSeage.QTI.Repository;

namespace OSeage.QTI.Service
{
    ///<summary>
/// 类别表
///</summary>
    public class CategoryService
    {
    public ICategoryRepository CategoryRepository { get; }

    public CategoryService (ICategoryRepository categoryRepository)
    {
    CategoryRepository = categoryRepository;
    }

    public int Insert(Category category)
    {
    return CategoryRepository.Insert(category);
    }

    public int DeleteById(long id)
    {
    return  CategoryRepository.DeleteById(id);
    }

    public int Update(Category category)
    {
    return  CategoryRepository.Update(category);
    }

    }
    }

