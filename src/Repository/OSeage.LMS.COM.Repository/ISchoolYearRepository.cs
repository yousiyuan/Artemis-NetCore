//*******************************
// Create By 流年 公子
// Date 2019-07-03 14:02
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
using OSeage.LMS.COM.Entity;

namespace OSeage.LMS.COM.Repository
{
///<summary>
/// 学年学期表
///</summary>
public interface ISchoolYearRepository : IRepository<SchoolYear, long>
    ,IRepositoryAsync<SchoolYear, long>
        {

[Statement(Id = "GetEntity")]
        new SchoolYear GetById([Param("RowKey")]long id);
[Statement(Id = "GetEntity")]
        new Task<SchoolYear> GetByIdAsync([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new int DeleteById([Param("RowKey")]long id);
[Statement(Id = "Delete")]
        new Task<int> DeleteByIdAsync([Param("RowKey")]long id);
        }
        }

