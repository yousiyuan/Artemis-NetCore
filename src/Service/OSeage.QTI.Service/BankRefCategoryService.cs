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
/// 题库与类别关系表
///</summary>
    public class BankRefCategoryService
    {
    public IBankRefCategoryRepository BankRefCategoryRepository { get; }

    public BankRefCategoryService (IBankRefCategoryRepository bankRefCategoryRepository)
    {
    BankRefCategoryRepository = bankRefCategoryRepository;
    }

    public int Insert(BankRefCategory bankRefCategory)
    {
    return BankRefCategoryRepository.Insert(bankRefCategory);
    }

    public int DeleteById(long id)
    {
    return  BankRefCategoryRepository.DeleteById(id);
    }

    public int Update(BankRefCategory bankRefCategory)
    {
    return  BankRefCategoryRepository.Update(bankRefCategory);
    }

    }
    }
