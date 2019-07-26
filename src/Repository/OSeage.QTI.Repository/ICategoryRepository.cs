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
/// 类别表
///</summary>
public interface ICategoryRepository : IRepository<Category, long>
    ,IRepositoryAsync<Category, long>
        {

[Statement(Id = "GetEntity")]
        new Category GetById([Param("RowKey")]long id);
[Statement(Id = "GetEntity")]
        new Task<Category> GetByIdAsync([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new int DeleteById([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new Task<int> DeleteByIdAsync([Param("RowKey")]long id);
        }
        }

