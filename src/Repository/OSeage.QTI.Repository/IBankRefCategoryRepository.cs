//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:49
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SmartSql.DyRepository;
using SmartSql.DyRepository.Annotations;
using OSeage.QTI.Entity;

namespace OSeage.QTI.Repository
{
///<summary>
/// 题库与类别关系表
///</summary>
public interface IBankRefCategoryRepository : IRepository<BankRefCategory, long>
    ,IRepositoryAsync<BankRefCategory, long>
        {

[Statement(Id = "GetEntity")]
        new BankRefCategory GetById([Param("CategoryKey")]long id);
[Statement(Id = "GetEntity")]
        new Task<BankRefCategory> GetByIdAsync([Param("CategoryKey")]long id);
[Statement(Id = "Delete")]
        new int DeleteById([Param("CategoryKey")]long id);
[Statement(Id = "Delete")]
        new Task<int> DeleteByIdAsync([Param("CategoryKey")]long id);
        }
        }

