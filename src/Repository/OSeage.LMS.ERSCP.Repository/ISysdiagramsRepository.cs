//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:57
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
using OSeage.LMS.ERSCP.Entity;

namespace OSeage.LMS.ERSCP.Repository
{
///<summary>
/// Table, sysdiagrams
///</summary>
public interface ISysdiagramsRepository : IRepository<Sysdiagrams, string>
    ,IRepositoryAsync<Sysdiagrams, string>
        {
        new string Insert(Sysdiagrams entity);
        new Task<string> InsertAsync(Sysdiagrams entity);

[Statement(Id = "GetEntity")]
        new Sysdiagrams GetById([Param("Name")]string id);
[Statement(Id = "GetEntity")]
        new Task<Sysdiagrams> GetByIdAsync([Param("Name")]string id);
[Statement(Id = "Delete")]
        new int DeleteById([Param("Name")]string id);
[Statement(Id = "Delete")]
        new Task<int> DeleteByIdAsync([Param("Name")]string id);
        }
        }

